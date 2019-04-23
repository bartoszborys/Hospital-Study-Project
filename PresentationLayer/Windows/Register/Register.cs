using BizzLayer.Services.RegistrationService;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BizzLayer.Services.Registration.Exceptions;

namespace MedicalClinic
{
    public partial class Register : Form
    {
        private RegistrationService service;
        private user person;

        public Register(RegistrationService service, user person)
        {
            this.service = service;
            this.person = person;
            InitializeComponent();
        }
        private void register_Close(object sender, FormClosingEventArgs e)
        {
        }

        public void search_Click(object sender, EventArgs e)
        {
            patient patientsFilter = new patient();
            patientsFilter.first_name = this.name.Text;
            patientsFilter.last_name = this.lastName.Text;
            patientsFilter.PESEL = this.peselNumber.Text;

            try
            {
                PatientDataValidate validator = new PatientDataValidate(PatientDataValidate.State.AllowEmpty);
                validator.validate(patientsFilter);
            }
            catch(InvalidPropertyException ex)
            {
                MessageBoxDecorator.InfoBox(ex.Message);
                return;
            }

            this.patientDataGrid.Rows.Clear();
            List<patient> filteredPatients = this.service.getFilteredPatients(patientsFilter);
            foreach ( patient filteredPatient in filteredPatients )
            {
                int index = this.patientDataGrid.Rows.Add();
                this.patientDataGrid.Rows[index].Cells["patient_name"].Value = filteredPatient.first_name;
                this.patientDataGrid.Rows[index].Cells["patient_last_name"].Value = filteredPatient.last_name;
                this.patientDataGrid.Rows[index].Cells["patient_pesel"].Value = filteredPatient.PESEL;
            }

            this.setup_buttons_if_there_any_patient();
        }

        private void setup_buttons_if_there_any_patient()
        {
            bool thereIsAnyPatient = this.patientDataGrid.Rows.Count != 0;

            if (thereIsAnyPatient)
            {
                this.editPatient.Enabled = true;
                this.registration.Enabled = true;
                this.btnShowVisists.Enabled = true;
            }
            else
            {
                this.editPatient.Enabled = false;
                this.registration.Enabled = false;
                this.btnShowVisists.Enabled = false;
            }
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            var window = new PatientManagment(this.service);
            window.ShowDialog(this);
            this.search_Click(sender, e);
        }

        private void editPatient_Click(object sender, EventArgs e)
        {
            patient patientsFilter = this.get_focused_patient_details_from_grid_view();
            Form window = new PatientManagment(this.service, patientsFilter);
            window.ShowDialog(this);
            this.search_Click(sender, e);
        }
        private void register_Click(object sender, EventArgs e)
        {
            patient patientsFilter = this.get_focused_patient_details_from_grid_view();
            Form window = new RejestracjaPacjenta(this.service, this.person, patientsFilter);
            window.ShowDialog(this);
        }

        private void btnShowVisists_Click(object sender, EventArgs e)
        {
            this.visitsView.Rows.Clear();
            patient patientsFilter = this.get_focused_patient_details_from_grid_view();
            List<visit> visitsData = this.service.getVisits( this.service.getPatientId(patientsFilter.PESEL) );

            if (visitsData.Count == 0)
            {
                MessageBoxDecorator.InfoBox("Pacjent nie posiada żadnej wizyty!");
                return;
            }

            VisitStatusTranslator statusTranslator = new VisitStatusTranslator();
            string rejectedStatus = VisitStatuses.get(VisitStatuses.Statuses.Rejected);
            bool showCanceled = this.showCanceled.Checked;

            foreach (visit visitData in visitsData)
            {
                if ( !showCanceled && (visitData.status == rejectedStatus) )
                {
                    continue;
                }

                int index = this.visitsView.Rows.Add();
                this.visitsView.Rows[index].Cells["visit_ID"].Value = visitData.id;
                this.visitsView.Rows[index].Cells["visit_name"].Value = patientsFilter.first_name;
                this.visitsView.Rows[index].Cells["visit_last_name"].Value = patientsFilter.last_name;
                this.visitsView.Rows[index].Cells["visit_pesel"].Value = patientsFilter.PESEL;
                this.visitsView.Rows[index].Cells["visit_start_date"].Value = visitData.registration_date;
                this.visitsView.Rows[index].Cells["visit_status"].Value = statusTranslator.translate(visitData.status);
                this.visitsView.Rows[index].Cells["visit_end_date"].Value = visitData.end_date != null ? visitData.end_date.ToString() : "-";
                this.visitsView.Rows[index].Cells["visit_doctor"].Value = this.service.getDoctorName(visitData.doctor_id);
            }

            this.visitsView.Rows[0].Selected = false;
            setup_cancel_visit_button();
        }

        private patient get_focused_patient_details_from_grid_view()
        {
            DataGridViewRow row = this.get_focused_row_from_grid_view(this.patientDataGrid);

            patient patientData = new patient();
            patientData.first_name = (String)row.Cells["patient_name"].Value;
            patientData.last_name = (String)row.Cells["patient_last_name"].Value;
            patientData.PESEL = (String)row.Cells["patient_pesel"].Value;

            PatientDataValidate validator = new PatientDataValidate(PatientDataValidate.State.NotAllowEmpty);
            validator.validate(patientData);

            return patientData;
        }

        private DataGridViewRow get_focused_row_from_grid_view(DataGridView view)
        {
            int focusedRow = view.CurrentCell.RowIndex;
            return view.Rows[focusedRow];
        }

        private void Register_Load(object sender, EventArgs e)
        {
            setup_buttons_if_there_any_patient();
        }

        private void cancelVisit_Click(object sender, EventArgs e)
        {
            visit visitData = new visit();
            visitData.id = this.get_focused_visit_id_from_grid_view();
            visitData.end_date = DateTime.Now;
            visitData.status = VisitStatuses.get( VisitStatuses.Statuses.Rejected );

            try
            {
                this.service.cancelVisit(visitData);
            }
            catch (DatabaseSubmitErrorException ex)
            {
                MessageBoxDecorator.ErrorBox("Wystąpił błąd podczas komunikacji z serwerem. Proszę skontaktuj się z administratorem");
            }

            MessageBoxDecorator.ActionSuccess();
            this.btnShowVisists_Click(sender, e);
        }

        private int get_focused_visit_id_from_grid_view()
        {
            DataGridViewRow row = this.get_focused_row_from_grid_view(this.visitsView);
            return (int)row.Cells["visit_ID"].Value;
        }

        private void setup_cancel_visit_button()
        {
            DataGridViewRow selectedRow = this.get_focused_row_from_grid_view(this.visitsView);
            string selectedVisitStatus = (string)selectedRow.Cells["visit_status"].Value;
            VisitStatusTranslator translator = new VisitStatusTranslator();
            this.cancelVisit.Enabled = (translator.untranslate(selectedVisitStatus) == VisitStatuses.get(VisitStatuses.Statuses.Start));
        }

        private void visitsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            setup_cancel_visit_button();
        }
    }
}
