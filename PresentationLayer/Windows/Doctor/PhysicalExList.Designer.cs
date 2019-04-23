namespace MedicalClinic
{
    partial class PhysicalExList
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
            this.examinationList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.examinationResult = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.patientPhysExList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictionary_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientPhysExList)).BeginInit();
            this.SuspendLayout();
            // 
            // examinationList
            // 
            this.examinationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examinationList.Enabled = false;
            this.examinationList.Location = new System.Drawing.Point(6, 19);
            this.examinationList.Name = "examinationList";
            this.examinationList.Size = new System.Drawing.Size(174, 21);
            this.examinationList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.examinationList);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 52);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nazwa Badania";
            // 
            // examinationResult
            // 
            this.examinationResult.Enabled = false;
            this.examinationResult.Location = new System.Drawing.Point(18, 271);
            this.examinationResult.Multiline = true;
            this.examinationResult.Name = "examinationResult";
            this.examinationResult.Size = new System.Drawing.Size(435, 134);
            this.examinationResult.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(15, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rezultat";
            // 
            // patientPhysExList
            // 
            this.patientPhysExList.AllowUserToAddRows = false;
            this.patientPhysExList.AllowUserToDeleteRows = false;
            this.patientPhysExList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientPhysExList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dictionary_code,
            this.ex_name,
            this.ex_result});
            this.patientPhysExList.Location = new System.Drawing.Point(18, 12);
            this.patientPhysExList.Name = "patientPhysExList";
            this.patientPhysExList.ReadOnly = true;
            this.patientPhysExList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientPhysExList.Size = new System.Drawing.Size(435, 178);
            this.patientPhysExList.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dictionary_code
            // 
            this.dictionary_code.HeaderText = "Kod Badania";
            this.dictionary_code.Name = "dictionary_code";
            this.dictionary_code.ReadOnly = true;
            // 
            // ex_name
            // 
            this.ex_name.HeaderText = "Nazwa Badania";
            this.ex_name.Name = "ex_name";
            this.ex_name.ReadOnly = true;
            // 
            // ex_result
            // 
            this.ex_result.HeaderText = "Rezultat";
            this.ex_result.Name = "ex_result";
            this.ex_result.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(363, 196);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(363, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(267, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(282, 196);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nowe";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // PhysicalExList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.patientPhysExList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.examinationResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PhysicalExList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhysicalExList";
            this.Load += new System.EventHandler(this.PhysicalExList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientPhysExList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox examinationList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox examinationResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView patientPhysExList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictionary_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ex_result;
    }
}