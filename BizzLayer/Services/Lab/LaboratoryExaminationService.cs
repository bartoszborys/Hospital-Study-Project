using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;

namespace BizzLayer.Services.LabExamination
{
    public class LaboratoryExaminationService
    {
        private static LaboratoryExaminationService instance = null;
        private DatabaseConnectionContext db;

        private LaboratoryExaminationService()
        {
            this.db = new DatabaseConnectionContext();
        }

        public static LaboratoryExaminationService getInstance()
        {
            if (instance == null)
            {
                LaboratoryExaminationService.instance = new LaboratoryExaminationService();
            }
            return LaboratoryExaminationService.instance;
        }

        public lab_examination getLabExaminationById(int labExData)
        {
            return (from lab_examination in this.db.lab_examinations
                    where lab_examination.id == labExData
                    select lab_examination).Single();
        }

        public List<lab_dictionary> getAllLaboratoryExaminationsNames()
        {
            return (from lab_dictionary in this.db.lab_dictionaries
                    where lab_dictionary.type == 'L'
                    select lab_dictionary).ToList();
        }

        public List<lab_examination> getAllLaboratoryExaminations(List<string> visitStatuses)
        {
            return (from lab_examination in this.db.lab_examinations
                    where visitStatuses.Contains(lab_examination.status)
                    select lab_examination).ToList();
        }
        public List<lab_examination> getAllLaboratoryExaminationsForLab(user userData, List<string> visitStatuses)
        {
            return (from lab_examination in this.db.lab_examinations
                    where visitStatuses.Contains(lab_examination.status)
                    where lab_examination.lab.id == userData.personel_id
                    select lab_examination).ToList();
        }

        public void changeVisitStatus(int examinationId, string status)
        {
            lab_examination examinationData = this.getLabExaminationById(examinationId);
            examinationData.status = status;
            this.submitDatabase();
        }

        public List<lab> getAllLaborants()
        {
            return (from lab in this.db.labs
                    select lab).ToList();
        }

        public void updateLabExamination(lab_examination labExData)
        {
            this.submitDatabase();
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

        public lab getLabById(int value)
        {
            return (from lab in this.db.labs
                    where lab.id == value
                    select lab).Single();
        }
    }
}
