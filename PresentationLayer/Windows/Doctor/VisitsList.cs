using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BizzLayer.Services.DoctorService;
using System.Windows.Forms;
using DataLayer;
using MedicalClinic;

namespace MedicalClinic
{
    public partial class VisitsList : Form
    {
        DoctorService service;
        user person;

        public VisitsList(DoctorService service, user person)
        {
            this.service = service;
            this.person = person;
            InitializeComponent();
        }

        private void VisitsList_Load(object sender, EventArgs e)
        {
            this.draw_data_grid( this.service.getVisits((int)this.person.personel_id, DateTime.Today) );
        }

        private void draw_data_grid(List<visit> visits)
        {
            VisitStatusTranslator tranlator = new VisitStatusTranslator();
            this.visits.Rows.Clear();

            foreach (visit visitDetails in visits)
            {
                int index = this.visits.Rows.Add();
                DataGridViewRow row = this.visits.Rows[index];
                row.Cells["id"].Value = visitDetails.id;
                row.Cells["patient_name"].Value = visitDetails.patient.first_name;
                row.Cells["patient_last_name"].Value = visitDetails.patient.last_name;
                row.Cells["patient_pesel"].Value = visitDetails.patient.PESEL;
                row.Cells["registration_date"].Value = visitDetails.registration_date;
                row.Cells["status"].Value = tranlator.translate(visitDetails.status);
            }
            this.visits.Sort(this.visits.Columns["registration_date"], ListSortDirection.Descending);
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.draw_data_grid( this.service.getFilteredVisits((int)this.person.personel_id, this.get_patient_data_from_form(), this.visitDate.Value) );
        }

        private patient get_patient_data_from_form()
        {
            patient patientFormData = new patient();
            patientFormData.first_name = this.name.Text;
            patientFormData.last_name = this.lastName.Text;
            patientFormData.PESEL = this.peselNumber.Text;

            return patientFormData;
        }

        private void showVisit_Click(object sender, EventArgs e)
        {
            int focusedRow = this.visits.CurrentCell.RowIndex;
            int visitId = (int)this.visits.Rows[focusedRow].Cells["id"].Value;
            visit visitData = this.service.getVisitById(visitId);
            
            Form window = new Visit(this.service, this, this.person, visitData);
            window.ShowDialog(this);
            this.search_Click(sender, e);
        }

        private void visits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
