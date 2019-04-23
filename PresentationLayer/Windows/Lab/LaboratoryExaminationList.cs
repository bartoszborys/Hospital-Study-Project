using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizzLayer.Services.LabExamination;
using DataLayer;

namespace MedicalClinic
{
    public partial class LaboratoryExaminationList : Form
    {
        LaboratoryExaminationService service;
        user userData;
        public LaboratoryExaminationList(LaboratoryExaminationService service, user userData)
        {
            this.service = service;
            this.userData = userData;
            InitializeComponent();
        }

        private void LaboratoryExaminationList_Load(object sender, EventArgs e)
        {
            if(this.userData.role == "MAN")
            {
                this.manager_view();
            }
            else if(this.userData.role == "LAB")
            {
                this.lab_view();
            }

            this.laboratoryExaminations.Items.Clear();
       
            this.laboratoryExaminations.Items.Add("Dowolne");
            foreach (lab_dictionary examination in this.service.getAllLaboratoryExaminationsNames())
            {
                this.laboratoryExaminations.Items.Add(examination.name);
            }

            this.laboratoryExaminations.SelectedItem = "Dowolne";
        }

        private void manager_view()
        {
            this.filtersStatus.Visible = false;
        }

        private void lab_view()
        {
            this.filtersStatus.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> visitStatuses = this.getStatusesFiltersList();
            List<lab_examination> examinations = this.GetCorrectExaminationsList(visitStatuses);
            this.drawExaminationList(examinations);
        }

        private List<string> getStatusesFiltersList()
        {
            List<string> visitStatuses = new List<string>();

            visitStatuses.Add(this.chkStarted.Checked ? "S" : "");
            visitStatuses.Add(this.chkExecuting.Checked ? "E" : "");
            visitStatuses.Add(this.chkCanceled.Checked ? "R" : "");
            visitStatuses.Add(this.chkEnd.Checked ? "F" : "");

            return visitStatuses;
        }

        private void drawExaminationList(List<lab_examination> examinations)
        {
            VisitStatusTranslator translator = new VisitStatusTranslator();

            this.ExaminationList.Rows.Clear();
            foreach (lab_examination examination in examinations)
            {
                DataGridViewRow row = this.ExaminationList.Rows[this.ExaminationList.Rows.Add()];
                row.Cells["id"].Value = examination.id;
                row.Cells["orderDate"].Value = examination.order_date;
                row.Cells["status"].Value = translator.translate(examination.status);
                row.Cells["labCode"].Value = examination.dictionary_code;
                row.Cells["labName"].Value = examination.lab_dictionary.name;
            }
        }

        private List<lab_examination> GetCorrectExaminationsList(List<string> visitStatuses)
        {
            List<lab_examination> examinations = null;

            if (this.userData.role == "MAN")
            {
                examinations = this.service.getAllLaboratoryExaminations(visitStatuses);
            }
            else if (this.userData.role == "LAB")
            {
                examinations = this.service.getAllLaboratoryExaminationsForLab(this.userData, visitStatuses);
            }

            string labNameFilter = (string)this.laboratoryExaminations.SelectedItem;
            if (labNameFilter != "Dowolne")
            {
                examinations = examinations.Where(x => x.lab_dictionary.name == labNameFilter).ToList();
            }

            return examinations;
        }

        private void btnAcceptEdit_Click(object sender, EventArgs e)
        {
            DataGridFocusedRow focusedRow = new DataGridFocusedRow(this.ExaminationList);
            new LaboratoryExaminationSummary(this.service, (int)focusedRow.get("id"), this.userData).ShowDialog();
        }
    }
}
