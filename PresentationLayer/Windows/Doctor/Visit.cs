using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Services.DoctorService;
using DataLayer;

namespace MedicalClinic
{
    public partial class Visit : Form
    {
        DoctorService service;
        Form parentWindow;
        user UserData;
        visit visitData;

        public Visit(DoctorService service, Form parentWindow, user userData, visit visitData)
        {
            this.service = service;
            this.parentWindow = parentWindow;
            this.UserData = userData;
            this.visitData = visitData;
            InitializeComponent();
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            VisitStatusTranslator translator = new VisitStatusTranslator();
            if (this.visitData.status == "S")
            {
                this.service.changeVisitStatus(this.visitData.id, VisitStatuses.get(VisitStatuses.Statuses.Execution));
            }

            this.patient_name.Text = this.visitData.patient.first_name;
            this.patient_last_name.Text = this.visitData.patient.last_name;
            this.patient_pesel.Text = this.visitData.patient.PESEL;
            this.visit_registration_date.Text = this.visitData.registration_date.ToString();
            this.visit_status.Text = translator.translate( this.visitData.status );
            this.visit_descritpion.Text = this.visitData.description;
            this.visit_diagnostic.Text = this.visitData.diagnosis;
        }

        private void btnPhysicsExa_Click(object sender, EventArgs e)
        {
            Form window = new PhysicalExList(this.service, this, this.visitData, this.UserData);
            window.ShowDialog(this);
        }

        private void btnLabolatoryEx_Click(object sender, EventArgs e)
        {
            Form window = new LaboratoryExList(this.service, this.visitData, this.UserData);
            window.ShowDialog(this);
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelVisit_Click(object sender, EventArgs e)
        {
            this.service.changeVisitStatus(this.visitData.id, VisitStatuses.get(VisitStatuses.Statuses.Rejected));
            this.saveAll_Click(sender, e);
            this.btnBack_Click(sender, e);
        }

        private void btnFinishVisit_Click(object sender, EventArgs e)
        {
            this.service.changeVisitStatus(this.visitData.id, VisitStatuses.get(VisitStatuses.Statuses.Finished));
            this.saveAll_Click(sender, e);
            this.btnBack_Click(sender, e);
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            this.visitData.diagnosis = this.visit_diagnostic.Text;
            this.visitData.description = this.visit_descritpion.Text;
            this.service.update_visit_with_desc_and_diag(visitData);
        }
    }
}
