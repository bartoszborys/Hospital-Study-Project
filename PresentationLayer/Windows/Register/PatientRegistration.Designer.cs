namespace MedicalClinic
{
    partial class RejestracjaPacjenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejestracjaPacjenta));
            this.doctorsGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patients_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.pesel = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.warning = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorsGridView
            // 
            this.doctorsGridView.AllowUserToAddRows = false;
            this.doctorsGridView.AllowUserToDeleteRows = false;
            this.doctorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.doctor_name,
            this.patients_count});
            this.doctorsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.doctorsGridView, "doctorsGridView");
            this.doctorsGridView.MultiSelect = false;
            this.doctorsGridView.Name = "doctorsGridView";
            this.doctorsGridView.ReadOnly = true;
            this.doctorsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorsGridView.Click += new System.EventHandler(this.clickDoctorsGrid);
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // doctor_name
            // 
            resources.ApplyResources(this.doctor_name, "doctor_name");
            this.doctor_name.Name = "doctor_name";
            this.doctor_name.ReadOnly = true;
            // 
            // patients_count
            // 
            resources.ApplyResources(this.patients_count, "patients_count");
            this.patients_count.Name = "patients_count";
            this.patients_count.ReadOnly = true;
            // 
            // doctor
            // 
            resources.ApplyResources(this.doctor, "doctor");
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            this.doctor.TextChanged += new System.EventHandler(this.doctor_TextChanged);
            // 
            // submit
            // 
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.return_Click);
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Name = "date";
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // pesel
            // 
            resources.ApplyResources(this.pesel, "pesel");
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            // 
            // lastName
            // 
            resources.ApplyResources(this.lastName, "lastName");
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // name
            // 
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doctor);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pesel);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lastName);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.name);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // warning
            // 
            resources.ApplyResources(this.warning, "warning");
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Name = "warning";
            // 
            // warning2
            // 
            resources.ApplyResources(this.warning2, "warning2");
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Name = "warning2";
            // 
            // RejestracjaPacjenta
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.doctorsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RejestracjaPacjenta";
            this.Load += new System.EventHandler(this.RejestracjaPacjenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox doctor;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox name;
        public System.Windows.Forms.DataGridView doctorsGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patients_count;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label warning2;
    }
}