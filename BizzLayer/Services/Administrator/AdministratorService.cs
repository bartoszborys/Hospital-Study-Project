using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;
using BizzLayer.Services.LabExamination;

namespace BizzLayer.Services.AdministratorService
{
    public class AdministratorService
    {
        private static AdministratorService instance = null;
        private DatabaseConnectionContext db;

        private AdministratorService()
        {
            this.db = new DatabaseConnectionContext();
        }

        public static AdministratorService getInstance()
        {
            if (instance == null)
            {
                AdministratorService.instance = new AdministratorService();
            }
            return AdministratorService.instance;
        }

        public AdministratorService getLaboratoryExaminationService()
        {
            return AdministratorService.getInstance();
        }
        
        public List<string> getRoles()
        {
            List<string> roles = new List<string>();
            roles.Add("REG");
            roles.Add("MAN");
            roles.Add("LAB");
            roles.Add("DOC");
            roles.Add("ADM");

            return roles;
        }

        public void addUserToDatabase(user newUser)
        {
            this.db.users.InsertOnSubmit(newUser);
            this.submitDatabase();
        }

        public int addRegistrator(registration regData)
        {
            this.db.registrations.InsertOnSubmit(regData);
            this.submitDatabase();
            return regData.id;
        }

        public int addDoctor(doctor docData)
        {
            this.db.doctors.InsertOnSubmit(docData);
            this.submitDatabase();
            return docData.id;
        }

        public int addManager(lab_manager manData)
        {
            this.db.lab_managers.InsertOnSubmit(manData);
            this.submitDatabase();
            return manData.id;
        }

        public int addLaborant(lab labData)
        {
            this.db.labs.InsertOnSubmit(labData);
            this.submitDatabase();
            return labData.id;
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
