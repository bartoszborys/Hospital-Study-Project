using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;

namespace BizzLayer.Services.RegistrationService
{
    public class RegistrationService
    {
        private static RegistrationService instance = null;
        private DatabaseConnectionContext db;

        private RegistrationService()
        {
            this.db = new DatabaseConnectionContext();
        }

        public static RegistrationService getInstance()
        {
            if (instance == null)
            {
                RegistrationService.instance = new RegistrationService();
            }
            return RegistrationService.instance;
        }

        public bool existsPatientWithPesel(string pesel)
        {
            int elements = (from patient in this.db.patients
                              where patient.PESEL.Contains(pesel)
                              select patient).ToList().Count;
            return elements > 0;
        }

        public List<patient> getFilteredPatients(patient patientsFilter)
        {
            return (from patient in this.db.patients
                    where patient.first_name.Contains(patientsFilter.first_name.Trim())
                    where patient.last_name.Contains(patientsFilter.last_name.Trim())
                    where patient.PESEL.Contains(patientsFilter.PESEL)
                    select patient).ToList();
        }

        public void insertPatient(patient newPatient)
        {
            if ( existsPatientWithPesel(newPatient.PESEL) )
            {
                throw new PeselExistsException(newPatient.PESEL);
            }

            this.db.patients.InsertOnSubmit(newPatient);
            this.submitDatabase();
        }

        public void updatePatient(patient editedPatient, patient patientToUpdate)
        {
            if (existsPatientWithPesel(editedPatient.PESEL) && !(editedPatient.PESEL == patientToUpdate.PESEL) )
            {
                throw new PeselExistsException(editedPatient.PESEL);
            }

            patient result = (from patient in this.db.patients
                          where patient.PESEL.Contains(patientToUpdate.PESEL)
                          select patient).SingleOrDefault();

            result.first_name = editedPatient.first_name;
            result.last_name = editedPatient.last_name;
            result.PESEL = editedPatient.PESEL;

            this.submitDatabase();
        }

        public List<doctor> getDoctors()
        {
            return this.db.doctors.ToList();
        }

        public int patientsToady(int doctorId)
        {
            return (from visit in this.db.visits
                    where visit.doctor_id == doctorId
                    where visit.registration_date.Date == DateTime.Today.Date
                    select visit).ToList().Count;
        }

        public int getPatientId(string pesel)
        {
            return (from patient in this.db.patients
                    where patient.PESEL == pesel
                    select patient).FirstOrDefault().id;
        }

        public void registerVisit(visit visitData)
        {
            this.db.visits.InsertOnSubmit(visitData);
            this.submitDatabase();
        }

        public List<visit> getVisits(int patientId)
        {
            return (from visit in this.db.visits
                    where visit.patient_id == patientId
                    select visit).ToList();
        }

        public void cancelVisit(visit cancelDetails)
        {
            visit visitData = ( from visit in this.db.visits
                            where visit.id == cancelDetails.id
                            select visit).SingleOrDefault();

            visitData.end_date = cancelDetails.end_date;
            visitData.status = cancelDetails.status;

            this.submitDatabase();
        }

        public string getDoctorName(int doctorId)
        {
            doctor dbResult = (from doctor in this.db.doctors
                            where doctor.id == doctorId
                            select doctor).SingleOrDefault();

            return dbResult.name.ToString() + " " + dbResult.last_name.ToString();
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
