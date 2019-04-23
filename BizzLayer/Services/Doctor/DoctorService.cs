using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;
using BizzLayer.Services.LabExamination;

namespace BizzLayer.Services.DoctorService
{
    public class DoctorService
    {
        private static DoctorService instance = null;
        private DatabaseConnectionContext db;

        private DoctorService()
        {
            this.db = new DatabaseConnectionContext();
        }

        public static DoctorService getInstance()
        {
            if (instance == null)
            {
                DoctorService.instance = new DoctorService();
            }
            return DoctorService.instance;
        }

        public LaboratoryExaminationService getLaboratoryExaminationService()
        {
            return LaboratoryExaminationService.getInstance();
        }

        public List<visit> getVisits(int doctorId, DateTime dateTime)
        {
            return (from visit in this.db.visits
                    where visit.doctor_id == doctorId
                    where visit.registration_date.Date == dateTime.Date
                    select visit).ToList();
        }

        public visit getVisitById(int visitId)
        {
            return (from visit in this.db.visits
                    where visit.id == visitId
                    select visit).SingleOrDefault();
        }

        public List<visit> getFilteredVisits(int doctorId, patient patientData, DateTime dateTime)
        {
            return (from visit in this.db.visits
                    where visit.doctor_id == doctorId
                    where visit.patient.first_name.Contains(patientData.first_name.Trim())
                    where visit.patient.last_name.Contains(patientData.last_name.Trim())
                    where visit.patient.PESEL.Contains(patientData.PESEL.Trim())
                    where visit.registration_date.Date == dateTime.Date
                    select visit).ToList();
        }

        public void changeVisitStatus(int visitId, string status)
        {
            visit exeVisit = this.getVisitById(visitId);
            exeVisit.status = status;
            this.submitDatabase();
        }

        public List<phys_examination> getVisitPhysicalExaminations(int visitId)
        {
            return (from phys_examination in this.db.phys_examinations
                    where phys_examination.visit_id == visitId
                    select phys_examination).ToList();
        }

        public List<lab_examination> getVisitLaboratoryExaminations(int visitId)
        {
            return (from lab_examination in this.db.lab_examinations
                    where lab_examination.visit_id == visitId
                    select lab_examination).ToList();
        }

        public void update_visit_with_desc_and_diag(visit visitData)
        {
            visit visitToUpdate = this.getVisitById(visitData.id);
            visitToUpdate.description = visitData.description;
            visitToUpdate.diagnosis = visitData.diagnosis;
            this.submitDatabase();
        }

        public List<lab_dictionary> getAllPhysicsExaminations()
        {
            return (from lab_dictionary in this.db.lab_dictionaries
                    where lab_dictionary.type == 'P'
                    select lab_dictionary).ToList();
        }

        public List<lab_dictionary> getAllLaboratoryExaminations()
        {
            return (from lab_dictionary in this.db.lab_dictionaries
                    where lab_dictionary.type == 'L'
                    select lab_dictionary).ToList();
        }

        public void insertPhysicExamination(phys_examination examData)
        {
            this.db.phys_examinations.InsertOnSubmit(examData);
            this.submitDatabase();
        }

        public void insertLaboratoryExamination(lab_examination labData)
        {
            this.db.lab_examinations.InsertOnSubmit(labData);
            this.submitDatabase();
        }

        public void updatePhysicExamination(phys_examination examData)
        {
            var data = (from phys_examination in this.db.phys_examinations
                        where phys_examination.id == examData.id
                        select phys_examination).FirstOrDefault();

            data.result = examData.result;
            data.lab_dictionary = this.db.lab_dictionaries.Single(x => x.code == examData.dictionary_code);

            this.submitDatabase();
        }

        public string getExaminationIdFromDictionary(string name)
        {
            return (from lab_dictionaries in this.db.lab_dictionaries
                        where lab_dictionaries.name == name
                        select lab_dictionaries).FirstOrDefault().code;
        }

        private void submitDatabase()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new DatabaseSubmitErrorException();
            }
        }
    }
}
