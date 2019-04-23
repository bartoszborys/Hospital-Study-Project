using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BizzLayer.Services.RegistrationService;
using BizzLayer.Services.Registration.Exceptions;

namespace MedicalClinic
{
    public partial class PatientManagment : Form
    {
        patient patientData;
        RegistrationService service;

        public PatientManagment(RegistrationService service)
        {
            this.service = service;
            this.patientData = null;
            InitializeComponent();
        }
        public PatientManagment(RegistrationService service, patient patientData)
        {
            this.service = service;
            this.patientData = patientData;
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            PatientDataValidate validator = new PatientDataValidate( PatientDataValidate.State.NotAllowEmpty );
            patient editedPatientData = this.getPatientDataFromForm();

            try
            {
                validator.validate(editedPatientData);
            }
            catch (InvalidPropertyException ex)
            {
                MessageBoxDecorator.InfoBox(ex.Message);
                return;
            }

            try
            {
                this.dataTransfer(editedPatientData);
            }
            catch (PeselExistsException ex)
            {
                MessageBoxDecorator.ErrorBox("Osoba z numerem PESEL: " + ex.pesel + " juz istnieje!");
                return;
            }

            this.Close();
            MessageBoxDecorator.SuccessBox("Operacja zakończona pomyślnie!");
        }

        private patient getPatientDataFromForm()
        {
            patient editedPatientData = new patient();
            editedPatientData.first_name = this.name.Text;
            editedPatientData.last_name = this.lastName.Text;
            editedPatientData.PESEL = this.peselNumber.Text;

            return editedPatientData;
        }

        private void dataTransfer(patient editedPatientData)
        {
            try
            {
                if (this.patientData == null)
                {
                    this.service.insertPatient(editedPatientData);
                }
                else
                {
                    this.service.updatePatient(editedPatientData, this.patientData);
                }
            }
            catch (DatabaseSubmitErrorException e)
            {
                MessageBoxDecorator.ErrorBox("Wystąpił błąd podczas komunikacji z serwerem. Proszę skontaktuj się z administratorem");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterPatientRowManagment_Load(object sender, EventArgs e)
        {
            if (patientData != null)
            {
                this.name.Text = patientData.first_name;
                this.lastName.Text = patientData.last_name;
                this.peselNumber.Text = patientData.PESEL;
            }
         }
    }
}
