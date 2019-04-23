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
    public partial class LaboratoryExaminationSummary : Form
    {
        LaboratoryExaminationService service;
        lab_examination labExData;
        user userData;

        public LaboratoryExaminationSummary(LaboratoryExaminationService service, int labExId, user userData)
        {
            this.service = service;
            this.labExData = this.service.getLabExaminationById(labExId);
            this.userData = userData;
            InitializeComponent();
        }

        private void LaboratoryExaminationSummary_Load(object sender, EventArgs e)
        {
            this.setup_view_depends_on_role();
            this.load_visit_data();
            this.draw_laborants_comboBox();
        }

        private void setup_view_depends_on_role()
        {
            switch (this.userData.role)
            {
                case "DOC":
                    this.doctorNote.Enabled = true;
                    this.btnCancel.Enabled = true;
                    break;

                case "LAB":
                    this.labResult.Enabled = true;
                    break;

                case "MAN":
                    if (!this.labExData.lab_id.HasValue)
                    {
                        this.labChoose.Enabled = true;
                    }

                    this.managerNote.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.btnSave.Enabled = true;
                    this.btnFinish.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void load_visit_data()
        {
            VisitStatusTranslator translator = new VisitStatusTranslator();

            this.doctorName.Text = this.labExData.visit.doctor.name;
            this.doctorLastName.Text = this.labExData.visit.doctor.last_name;
            this.labResult.Text = this.labExData.result;
            this.doctorNote.Text = this.labExData.doctor_note;
            this.examinationOrderDate.Text = this.labExData.order_date.ToString();
            this.examinationStatus.Text = translator.translate(this.labExData.status);
            this.orderedExaminationName.Text = this.labExData.lab_dictionary.name;
            this.managerNote.Text = this.labExData.manager_note;
        }

        private class lab_data
        {
            public lab_data(int _value, string _text)
            {
                this.value = _value;
                this.text = _text;
            }
            public int value { get; set; }
            public string text { get; set; }
        }

        private void draw_laborants_comboBox()
        {
            List<lab> allLaborants = this.service.getAllLaborants();
            labChoose.DisplayMember = "Text";
            labChoose.ValueMember = "Value";

            foreach (lab laborant in allLaborants)
            {
                var labData = new lab_data(laborant.id, $"{laborant.name} {laborant.last_name}");
                labChoose.Items.Add(labData);

                if(this.labExData.lab == null)
                {
                    continue;
                }

                if(this.labExData.lab_id.Value == laborant.id)
                {
                    labChoose.SelectedItem = labData;
                }
            }
        }

        private void fillLabExaminationDataFromForm()
        {
            this.labExData.doctor_note = this.doctorNote.Text;
            this.labExData.manager_note = this.managerNote.Text;
            this.labExData.result = this.labResult.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.changeVisitStatus(VisitStatuses.Statuses.Rejected);
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.changeVisitStatus(VisitStatuses.Statuses.Finished);
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lab_data selectedLaborant = (lab_data)this.labChoose.SelectedItem;

            this.labExData.doctor_note = this.doctorNote.Text;
            this.labExData.manager_note = this.managerNote.Text;
            this.labExData.result = this.labResult.Text;

            if(this.userData.role == "LAB")
            {
                this.changeVisitStatus(VisitStatuses.Statuses.Execution);
            }

            if(this.userData.role == "MAN")
            {
                this.labExData.manager_id = this.userData.personel_id;
            }

            if (!this.labExData.lab_id.HasValue)
            {
                this.labExData.lab = this.service.getLabById(selectedLaborant.value);
            }

            this.service.updateLabExamination(this.labExData);
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeVisitStatus(VisitStatuses.Statuses status)
        {
            this.service.changeVisitStatus(this.labExData.id, VisitStatuses.get(status));
        }
    }
}
