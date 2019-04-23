namespace MedicalClinic
{
    partial class Visit
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
            this.patientData = new System.Windows.Forms.GroupBox();
            this.patient_pesel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_last_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patient_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visit_diagnostic = new System.Windows.Forms.TextBox();
            this.visit_descritpion = new System.Windows.Forms.TextBox();
            this.visit_status = new System.Windows.Forms.TextBox();
            this.visit_registration_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPhysicsExa = new System.Windows.Forms.Button();
            this.btnLabolatoryEx = new System.Windows.Forms.Button();
            this.btnCancelVisit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFinishVisit = new System.Windows.Forms.Button();
            this.patientData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientData
            // 
            this.patientData.Controls.Add(this.patient_pesel);
            this.patientData.Controls.Add(this.label3);
            this.patientData.Controls.Add(this.patient_last_name);
            this.patientData.Controls.Add(this.label2);
            this.patientData.Controls.Add(this.patient_name);
            this.patientData.Controls.Add(this.label9);
            this.patientData.Location = new System.Drawing.Point(12, 12);
            this.patientData.Name = "patientData";
            this.patientData.Size = new System.Drawing.Size(230, 153);
            this.patientData.TabIndex = 0;
            this.patientData.TabStop = false;
            this.patientData.Text = "Dane pacjęta";
            // 
            // patient_pesel
            // 
            this.patient_pesel.Location = new System.Drawing.Point(9, 123);
            this.patient_pesel.Name = "patient_pesel";
            this.patient_pesel.ReadOnly = true;
            this.patient_pesel.Size = new System.Drawing.Size(214, 20);
            this.patient_pesel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PESEL";
            // 
            // patient_last_name
            // 
            this.patient_last_name.Location = new System.Drawing.Point(9, 78);
            this.patient_last_name.Name = "patient_last_name";
            this.patient_last_name.ReadOnly = true;
            this.patient_last_name.Size = new System.Drawing.Size(214, 20);
            this.patient_last_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // patient_name
            // 
            this.patient_name.Location = new System.Drawing.Point(9, 32);
            this.patient_name.Name = "patient_name";
            this.patient_name.ReadOnly = true;
            this.patient_name.Size = new System.Drawing.Size(214, 20);
            this.patient_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Imię";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveAll);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.visit_diagnostic);
            this.groupBox1.Controls.Add(this.visit_descritpion);
            this.groupBox1.Controls.Add(this.visit_status);
            this.groupBox1.Controls.Add(this.visit_registration_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(248, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 451);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane wizyty";
            // 
            // saveAll
            // 
            this.saveAll.Location = new System.Drawing.Point(416, 422);
            this.saveAll.Name = "saveAll";
            this.saveAll.Size = new System.Drawing.Size(118, 23);
            this.saveAll.TabIndex = 14;
            this.saveAll.Text = "Zapisz Wszystko";
            this.saveAll.UseVisualStyleBackColor = true;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(7, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagnoza";
            // 
            // visit_diagnostic
            // 
            this.visit_diagnostic.Location = new System.Drawing.Point(10, 258);
            this.visit_diagnostic.Multiline = true;
            this.visit_diagnostic.Name = "visit_diagnostic";
            this.visit_diagnostic.Size = new System.Drawing.Size(524, 156);
            this.visit_diagnostic.TabIndex = 11;
            // 
            // visit_descritpion
            // 
            this.visit_descritpion.Location = new System.Drawing.Point(10, 78);
            this.visit_descritpion.Multiline = true;
            this.visit_descritpion.Name = "visit_descritpion";
            this.visit_descritpion.Size = new System.Drawing.Size(524, 153);
            this.visit_descritpion.TabIndex = 10;
            // 
            // visit_status
            // 
            this.visit_status.Location = new System.Drawing.Point(287, 32);
            this.visit_status.Name = "visit_status";
            this.visit_status.ReadOnly = true;
            this.visit_status.Size = new System.Drawing.Size(247, 20);
            this.visit_status.TabIndex = 9;
            // 
            // visit_registration_date
            // 
            this.visit_registration_date.Location = new System.Drawing.Point(10, 32);
            this.visit_registration_date.Name = "visit_registration_date";
            this.visit_registration_date.ReadOnly = true;
            this.visit_registration_date.Size = new System.Drawing.Size(242, 20);
            this.visit_registration_date.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Rejestracji";
            // 
            // btnPhysicsExa
            // 
            this.btnPhysicsExa.Location = new System.Drawing.Point(12, 171);
            this.btnPhysicsExa.Name = "btnPhysicsExa";
            this.btnPhysicsExa.Size = new System.Drawing.Size(230, 40);
            this.btnPhysicsExa.TabIndex = 2;
            this.btnPhysicsExa.Text = "Badania Fizykalne";
            this.btnPhysicsExa.UseVisualStyleBackColor = true;
            this.btnPhysicsExa.Click += new System.EventHandler(this.btnPhysicsExa_Click);
            // 
            // btnLabolatoryEx
            // 
            this.btnLabolatoryEx.Location = new System.Drawing.Point(12, 217);
            this.btnLabolatoryEx.Name = "btnLabolatoryEx";
            this.btnLabolatoryEx.Size = new System.Drawing.Size(230, 40);
            this.btnLabolatoryEx.TabIndex = 3;
            this.btnLabolatoryEx.Text = "Badania Laboratoryjne";
            this.btnLabolatoryEx.UseVisualStyleBackColor = true;
            this.btnLabolatoryEx.Click += new System.EventHandler(this.btnLabolatoryEx_Click);
            // 
            // btnCancelVisit
            // 
            this.btnCancelVisit.Location = new System.Drawing.Point(12, 376);
            this.btnCancelVisit.Name = "btnCancelVisit";
            this.btnCancelVisit.Size = new System.Drawing.Size(230, 40);
            this.btnCancelVisit.TabIndex = 5;
            this.btnCancelVisit.Text = "Anuluj Wizytę";
            this.btnCancelVisit.UseVisualStyleBackColor = true;
            this.btnCancelVisit.Click += new System.EventHandler(this.btnCancelVisit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 330);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(230, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFinishVisit
            // 
            this.btnFinishVisit.Location = new System.Drawing.Point(12, 422);
            this.btnFinishVisit.Name = "btnFinishVisit";
            this.btnFinishVisit.Size = new System.Drawing.Size(230, 40);
            this.btnFinishVisit.TabIndex = 6;
            this.btnFinishVisit.Text = "Zakończ wizytę";
            this.btnFinishVisit.UseVisualStyleBackColor = true;
            this.btnFinishVisit.Click += new System.EventHandler(this.btnFinishVisit_Click);
            // 
            // Visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnFinishVisit);
            this.Controls.Add(this.btnCancelVisit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLabolatoryEx);
            this.Controls.Add(this.btnPhysicsExa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.patientData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Visit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit";
            this.Load += new System.EventHandler(this.Visit_Load);
            this.patientData.ResumeLayout(false);
            this.patientData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patientData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patient_pesel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patient_last_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patient_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox visit_status;
        private System.Windows.Forms.TextBox visit_registration_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visit_diagnostic;
        private System.Windows.Forms.TextBox visit_descritpion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPhysicsExa;
        private System.Windows.Forms.Button btnLabolatoryEx;
        private System.Windows.Forms.Button btnCancelVisit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFinishVisit;
        private System.Windows.Forms.Button saveAll;
    }
}