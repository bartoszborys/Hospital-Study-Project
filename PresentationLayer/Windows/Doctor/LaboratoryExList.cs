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
using BizzLayer.Services.DoctorService;

namespace MedicalClinic
{
    public partial class LaboratoryExList : Form
    {
        DoctorService service;
        user UserData;
        visit visitData;
        public LaboratoryExList(DoctorService service, visit visitData, user userData)
        {
            this.service = service;
            this.UserData = userData;
            this.visitData = visitData;
            InitializeComponent();
        }

        private void LaboratoryExList_Load(object sender, EventArgs e)
        {
            this.draw_lab_examinations_grid();
        }
        
        private void draw_lab_examinations_grid()
        {
            VisitStatusTranslator translator = new VisitStatusTranslator();

            List<lab_examination> examinations = this.service.getVisitLaboratoryExaminations(visitData.id);

            this.LaboratoryExaminationList.Rows.Clear();
            foreach (lab_examination examination in examinations)
            {
                int index = this.LaboratoryExaminationList.Rows.Add();
                DataGridViewRow row = this.LaboratoryExaminationList.Rows[index];
                row.Cells["id"].Value = examination.id;
                row.Cells["name"].Value = examination.lab_dictionary.name;
                row.Cells["status"].Value = translator.translate(examination.status);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Form window = new OrderLaboratory(this.service, this.visitData, this.UserData);
            window.ShowDialog();
            this.draw_lab_examinations_grid();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataGridFocusedRow focusedRow = new DataGridFocusedRow(this.LaboratoryExaminationList);
            int labExId = (int)focusedRow.get("id");
            Form window = new LaboratoryExaminationSummary(this.service.getLaboratoryExaminationService(), labExId, this.UserData);
            window.ShowDialog();
            this.draw_lab_examinations_grid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
