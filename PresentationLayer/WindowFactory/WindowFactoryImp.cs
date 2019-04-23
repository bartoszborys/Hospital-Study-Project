using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer.Services.RegistrationService;
using BizzLayer.Services.DoctorService;
using BizzLayer.Services.LabExamination;
using BizzLayer.Services.AdministratorService;

namespace MedicalClinic.windowFactory
{
    public class WindowFactoryImp : IWindowFactory
    {
        private Form parentWindow;
        public WindowFactoryImp(Form parentWindow)
        {
            this.parentWindow = parentWindow;
        }

        public Form GetCorrectWindow(user person)
        {
            switch (person.role)
            {
                case "REG":
                    return new Register(RegistrationService.getInstance(), person);

                case "DOC":
                    return new VisitsList(DoctorService.getInstance(), person);

                case "MAN":
                case "LAB":
                    return new LaboratoryExaminationList(LaboratoryExaminationService.getInstance(), person);

                case "ADM":
                    return new CreateUsers(AdministratorService.getInstance(), person);

                default:
                    throw new UnknowFactoryValueException(person.role);
            }
        }
    }
}
