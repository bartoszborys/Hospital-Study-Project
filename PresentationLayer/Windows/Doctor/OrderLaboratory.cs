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
    public partial class OrderLaboratory : Form
    {
        DoctorService service;
        user UserData;
        visit visitData;
        public OrderLaboratory(DoctorService service, visit visitData, user userData)
        {
            this.service = service;
            this.UserData = userData;
            this.visitData = visitData;
            InitializeComponent();
        }

        private void OrderLaboratory_Load(object sender, EventArgs e)
        {
            this.examinationList.Items.Clear();

            foreach (lab_dictionary examination in this.service.getAllLaboratoryExaminations())
            {
                this.examinationList.Items.Add(examination.name);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lab_examination labData = new lab_examination();
            labData.visit = this.visitData;
            labData.dictionary_code = this.service.getExaminationIdFromDictionary(this.examinationList.Text.ToString()).Trim();
            labData.status = VisitStatuses.get(VisitStatuses.Statuses.Start);
            labData.order_date = DateTime.Now;
            labData.doctor_note = this.doctorNote.Text;

            this.service.insertLaboratoryExamination(labData);

            this.btnBack_Click(sender, e);
        }

        private void examinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOrder.Enabled = true;
        }
    }
}
