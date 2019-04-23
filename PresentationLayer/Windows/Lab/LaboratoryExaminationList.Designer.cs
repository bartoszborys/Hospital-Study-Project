namespace MedicalClinic
{
    partial class LaboratoryExaminationList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filtersStatus = new System.Windows.Forms.GroupBox();
            this.chkEnd = new System.Windows.Forms.CheckBox();
            this.chkCanceled = new System.Windows.Forms.CheckBox();
            this.chkExecuting = new System.Windows.Forms.CheckBox();
            this.chkStarted = new System.Windows.Forms.CheckBox();
            this.laboratoryExaminations = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ExaminationList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAcceptEdit = new System.Windows.Forms.Button();
            this.filtersStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationList)).BeginInit();
            this.SuspendLayout();
            // 
            // filtersStatus
            // 
            this.filtersStatus.Controls.Add(this.chkEnd);
            this.filtersStatus.Controls.Add(this.chkCanceled);
            this.filtersStatus.Controls.Add(this.chkExecuting);
            this.filtersStatus.Controls.Add(this.chkStarted);
            this.filtersStatus.Location = new System.Drawing.Point(8, 5);
            this.filtersStatus.Name = "filtersStatus";
            this.filtersStatus.Size = new System.Drawing.Size(411, 44);
            this.filtersStatus.TabIndex = 0;
            this.filtersStatus.TabStop = false;
            this.filtersStatus.Text = "Status badania";
            // 
            // chkEnd
            // 
            this.chkEnd.AutoSize = true;
            this.chkEnd.Location = new System.Drawing.Point(277, 19);
            this.chkEnd.Name = "chkEnd";
            this.chkEnd.Size = new System.Drawing.Size(86, 17);
            this.chkEnd.TabIndex = 3;
            this.chkEnd.Text = "Zakończone";
            this.chkEnd.UseVisualStyleBackColor = true;
            // 
            // chkCanceled
            // 
            this.chkCanceled.AutoSize = true;
            this.chkCanceled.Location = new System.Drawing.Point(192, 19);
            this.chkCanceled.Name = "chkCanceled";
            this.chkCanceled.Size = new System.Drawing.Size(79, 17);
            this.chkCanceled.TabIndex = 2;
            this.chkCanceled.Text = "Anulowane";
            this.chkCanceled.UseVisualStyleBackColor = true;
            // 
            // chkExecuting
            // 
            this.chkExecuting.AutoSize = true;
            this.chkExecuting.Location = new System.Drawing.Point(95, 19);
            this.chkExecuting.Name = "chkExecuting";
            this.chkExecuting.Size = new System.Drawing.Size(91, 17);
            this.chkExecuting.TabIndex = 1;
            this.chkExecuting.Text = "Wykonywane";
            this.chkExecuting.UseVisualStyleBackColor = true;
            // 
            // chkStarted
            // 
            this.chkStarted.AutoSize = true;
            this.chkStarted.Checked = true;
            this.chkStarted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStarted.Location = new System.Drawing.Point(6, 19);
            this.chkStarted.Name = "chkStarted";
            this.chkStarted.Size = new System.Drawing.Size(83, 17);
            this.chkStarted.TabIndex = 0;
            this.chkStarted.Text = "Rozpoczęte";
            this.chkStarted.UseVisualStyleBackColor = true;
            // 
            // laboratoryExaminations
            // 
            this.laboratoryExaminations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laboratoryExaminations.FormattingEnabled = true;
            this.laboratoryExaminations.Location = new System.Drawing.Point(6, 15);
            this.laboratoryExaminations.Name = "laboratoryExaminations";
            this.laboratoryExaminations.Size = new System.Drawing.Size(194, 21);
            this.laboratoryExaminations.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.laboratoryExaminations);
            this.groupBox2.Location = new System.Drawing.Point(425, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 44);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Badanie";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(637, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ExaminationList
            // 
            this.ExaminationList.AllowUserToAddRows = false;
            this.ExaminationList.AllowUserToDeleteRows = false;
            this.ExaminationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExaminationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.orderDate,
            this.status,
            this.labCode,
            this.labName});
            this.ExaminationList.Location = new System.Drawing.Point(8, 55);
            this.ExaminationList.Name = "ExaminationList";
            this.ExaminationList.ReadOnly = true;
            this.ExaminationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExaminationList.Size = new System.Drawing.Size(780, 405);
            this.ExaminationList.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "Data Zlecenia";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // labCode
            // 
            this.labCode.HeaderText = "Kod badania";
            this.labCode.Name = "labCode";
            this.labCode.ReadOnly = true;
            // 
            // labName
            // 
            this.labName.HeaderText = "Nazwa badania";
            this.labName.Name = "labName";
            this.labName.ReadOnly = true;
            // 
            // btnAcceptEdit
            // 
            this.btnAcceptEdit.Location = new System.Drawing.Point(688, 466);
            this.btnAcceptEdit.Name = "btnAcceptEdit";
            this.btnAcceptEdit.Size = new System.Drawing.Size(100, 23);
            this.btnAcceptEdit.TabIndex = 5;
            this.btnAcceptEdit.Text = "Edytuj";
            this.btnAcceptEdit.UseVisualStyleBackColor = true;
            this.btnAcceptEdit.Click += new System.EventHandler(this.btnAcceptEdit_Click);
            // 
            // LaboratoryExaminationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnAcceptEdit);
            this.Controls.Add(this.ExaminationList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.filtersStatus);
            this.Name = "LaboratoryExaminationList";
            this.Text = "LaboratoryExaminationList";
            this.Load += new System.EventHandler(this.LaboratoryExaminationList_Load);
            this.filtersStatus.ResumeLayout(false);
            this.filtersStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExaminationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filtersStatus;
        private System.Windows.Forms.CheckBox chkEnd;
        private System.Windows.Forms.CheckBox chkCanceled;
        private System.Windows.Forms.CheckBox chkExecuting;
        private System.Windows.Forms.CheckBox chkStarted;
        private System.Windows.Forms.ComboBox laboratoryExaminations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView ExaminationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn labCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn labName;
        private System.Windows.Forms.Button btnAcceptEdit;
    }
}