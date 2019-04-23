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
    public partial class PhysicalExList : Form
    {
        private DoctorService service;
        private Form parentWindow;
        private visit visitData;
        private user userData;
        private bool addingNewRecord;

        public PhysicalExList(DoctorService service, Form parentWindow, visit visitData, user userData)
        {
            this.service = service;
            this.parentWindow = parentWindow;
            this.visitData = visitData;
            this.userData = userData;
            InitializeComponent();
        }

        private void PhysicalExList_Load(object sender, EventArgs e)
        {
            List<phys_examination> examinations = this.service.getVisitPhysicalExaminations(visitData.id);
            foreach( phys_examination examination in examinations)
            {
                int index = this.patientPhysExList.Rows.Add();
                DataGridViewRow row = this.patientPhysExList.Rows[index];
                row.Cells["id"].Value = examination.id;
                row.Cells["dictionary_code"].Value = examination.dictionary_code;
                row.Cells["ex_name"].Value = examination.lab_dictionary.name;
                row.Cells["ex_result"].Value = examination.result;
            }

            this.examinationList.Items.Clear();
            foreach (lab_dictionary examination in this.service.getAllPhysicsExaminations())
            {
                this.examinationList.Items.Add(examination.name);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.examinationResult.Text = "";
            this.examinationList.SelectedIndex = -1;

            this.examinationList.Enabled = true;
            this.examinationResult.Enabled = true;
            this.btnSave.Enabled = true;
            this.addingNewRecord = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridFocusedRow focusedRow = new DataGridFocusedRow(this.patientPhysExList);
            this.examinationList.SelectedIndex = this.examinationList.Items.IndexOf(focusedRow.get("ex_name"));
            this.examinationResult.Text = focusedRow.get("ex_result").ToString();

            this.examinationList.Enabled = true;
            this.examinationResult.Enabled = true;
            this.btnSave.Enabled = true;
            this.addingNewRecord = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            phys_examination physData = new phys_examination();
            physData.result = this.examinationResult.Text;
            physData.visit_id = this.visitData.id;
            physData.dictionary_code = this.service.getExaminationIdFromDictionary( this.examinationList.Text.ToString() ).Trim();

            if (this.addingNewRecord)
            {
                this.service.insertPhysicExamination(physData);
            }
            else
            {
                DataGridFocusedRow focusedRow = new DataGridFocusedRow(this.patientPhysExList);
                physData.id = (int)focusedRow.get("id");
                this.service.updatePhysicExamination(physData);
            }

            this.btnBack_Click(sender, e);
        }
    }
}
