using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Services.RegistrationService;
using DataLayer;
using BizzLayer.Services.Registration.Exceptions;

namespace MedicalClinic
{
    public partial class RejestracjaPacjenta : Form
    {
        RegistrationService service;
        patient patientData;
        user registration;

        public RejestracjaPacjenta(RegistrationService service, user registration, patient patientData)
        {
            this.service = service;
            this.patientData = patientData;
            this.registration = registration;

            InitializeComponent();
        }

        private void return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RejestracjaPacjenta_Load(object sender, EventArgs e)
        {
            foreach (doctor doctorData in this.service.getDoctors())
            {
                int index = this.doctorsGridView.Rows.Add();
                this.doctorsGridView.Rows[index].Cells["ID"].Value = doctorData.id;
                this.doctorsGridView.Rows[index].Cells["doctor_name"].Value = doctorData.name + " " + doctorData.last_name;
                this.doctorsGridView.Rows[index].Cells["patients_count"].Value = this.service.patientsToady(doctorData.id);
            }

            this.name.Text = patientData.first_name;
            this.lastName.Text = patientData.last_name;
            this.pesel.Text = patientData.PESEL;

            this.doctorsGridView.Rows[0].Selected = false;
        }

        private void clickDoctorsGrid(object sender, EventArgs e)
        {
            DataGridViewRow row = this.getFocusedGridRow(); 
            this.doctor.Text = (String)row.Cells[1].Value;
        }

        private DataGridViewRow getFocusedGridRow()
        {
            int focusedRow = this.doctorsGridView.CurrentCell.RowIndex;
            return this.doctorsGridView.Rows[focusedRow];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            visit visitData = this.getVisitDataFromForm();
            try
            {
                this.service.registerVisit(visitData);
            }
            catch (DatabaseSubmitErrorException ex)
            {
                MessageBoxDecorator.ErrorBox("Wystąpił błąd podczas komunikacji z serwerem. Proszę skontaktuj się z administratorem");
            }
            this.Close();
        }

        private visit getVisitDataFromForm()
        {
            DataGridViewRow row = this.getFocusedGridRow();

            visit visitData = new visit();
            visitData.patient_id = this.service.getPatientId(this.pesel.Text);
            visitData.registration_id = (int)this.registration.personel_id;
            visitData.doctor_id = (int)row.Cells["ID"].Value;
            visitData.status = VisitStatuses.get( VisitStatuses.Statuses.Start );
            visitData.registration_date = this.date.Value;

            return visitData;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            this.setupSubmitButton();
        }
        private void doctor_TextChanged(object sender, EventArgs e)
        {
            this.setupSubmitButton();
        }

        private void setupSubmitButton()
        {
            DateTime pickedDateTime = this.date.Value;
            

            if (pickedDateTime < DateTime.Now)
            {
                this.submit.Enabled = false;
                this.warning2.Show();
                this.warning.Hide();
                return;
            }

            if (this.doctor.Text.Length <= 0)
            {
                this.submit.Enabled = false;
                this.warning.Show();
                this.warning2.Hide();
                return;
            }

            this.warning.Hide();
            this.warning2.Hide();
            this.submit.Enabled = true;
        }
    }
}
