namespace MedicalClinic
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.peselNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.visitsView = new System.Windows.Forms.DataGridView();
            this.visit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visit_doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration = new System.Windows.Forms.Button();
            this.editPatient = new System.Windows.Forms.Button();
            this.addPatient = new System.Windows.Forms.Button();
            this.cancelVisit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowVisists = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.GroupBox();
            this.showCanceled = new System.Windows.Forms.CheckBox();
            this.Pacjenci = new System.Windows.Forms.GroupBox();
            this.patientDataGrid = new System.Windows.Forms.DataGridView();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.visitsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.Rejestracja.SuspendLayout();
            this.Pacjenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(259, 8);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(150, 20);
            this.lastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwisko";
            // 
            // peselNumber
            // 
            this.peselNumber.Location = new System.Drawing.Point(454, 8);
            this.peselNumber.MaxLength = 11;
            this.peselNumber.Name = "peselNumber";
            this.peselNumber.Size = new System.Drawing.Size(163, 20);
            this.peselNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesel";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(626, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 23);
            this.search.TabIndex = 6;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Imie";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(44, 8);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 20);
            this.name.TabIndex = 3;
            // 
            // visitsView
            // 
            this.visitsView.AllowUserToAddRows = false;
            this.visitsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.visitsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visit_id,
            this.visit_name,
            this.visit_last_name,
            this.visit_start_date,
            this.visit_pesel,
            this.visit_status,
            this.visit_end_date,
            this.visit_doctor});
            this.visitsView.Location = new System.Drawing.Point(9, 24);
            this.visitsView.MultiSelect = false;
            this.visitsView.Name = "visitsView";
            this.visitsView.ReadOnly = true;
            this.visitsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitsView.Size = new System.Drawing.Size(768, 254);
            this.visitsView.TabIndex = 7;
            this.visitsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitsView_CellContentClick);
            // 
            // visit_id
            // 
            this.visit_id.HeaderText = "ID";
            this.visit_id.Name = "visit_id";
            this.visit_id.ReadOnly = true;
            this.visit_id.Visible = false;
            // 
            // visit_name
            // 
            this.visit_name.HeaderText = "Imie";
            this.visit_name.Name = "visit_name";
            this.visit_name.ReadOnly = true;
            this.visit_name.Width = 51;
            // 
            // visit_last_name
            // 
            this.visit_last_name.HeaderText = "Nazwisko";
            this.visit_last_name.Name = "visit_last_name";
            this.visit_last_name.ReadOnly = true;
            this.visit_last_name.Width = 78;
            // 
            // visit_start_date
            // 
            this.visit_start_date.HeaderText = "Data Wizyty";
            this.visit_start_date.Name = "visit_start_date";
            this.visit_start_date.ReadOnly = true;
            this.visit_start_date.Width = 82;
            // 
            // visit_pesel
            // 
            this.visit_pesel.HeaderText = "Pesel";
            this.visit_pesel.Name = "visit_pesel";
            this.visit_pesel.ReadOnly = true;
            this.visit_pesel.Width = 58;
            // 
            // visit_status
            // 
            this.visit_status.HeaderText = "Status";
            this.visit_status.Name = "visit_status";
            this.visit_status.ReadOnly = true;
            this.visit_status.Width = 62;
            // 
            // visit_end_date
            // 
            this.visit_end_date.HeaderText = "Data Zakończenia";
            this.visit_end_date.Name = "visit_end_date";
            this.visit_end_date.ReadOnly = true;
            this.visit_end_date.Width = 110;
            // 
            // visit_doctor
            // 
            this.visit_doctor.HeaderText = "Lekarz";
            this.visit_doctor.Name = "visit_doctor";
            this.visit_doctor.ReadOnly = true;
            this.visit_doctor.Width = 64;
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(458, 181);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(155, 23);
            this.registration.TabIndex = 8;
            this.registration.Text = "Rejestruj";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.register_Click);
            // 
            // editPatient
            // 
            this.editPatient.Location = new System.Drawing.Point(297, 181);
            this.editPatient.Name = "editPatient";
            this.editPatient.Size = new System.Drawing.Size(155, 23);
            this.editPatient.TabIndex = 9;
            this.editPatient.Text = "Edytuj dane pacjenta";
            this.editPatient.UseVisualStyleBackColor = true;
            this.editPatient.Click += new System.EventHandler(this.editPatient_Click);
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(149, 181);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(142, 23);
            this.addPatient.TabIndex = 10;
            this.addPatient.Text = "Nowy pacjent";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // cancelVisit
            // 
            this.cancelVisit.Location = new System.Drawing.Point(619, 284);
            this.cancelVisit.Name = "cancelVisit";
            this.cancelVisit.Size = new System.Drawing.Size(155, 23);
            this.cancelVisit.TabIndex = 11;
            this.cancelVisit.Text = "Anuluj wizytę";
            this.cancelVisit.UseVisualStyleBackColor = true;
            this.cancelVisit.Click += new System.EventHandler(this.cancelVisit_Click);
            // 
            // btnShowVisists
            // 
            this.btnShowVisists.Location = new System.Drawing.Point(622, 181);
            this.btnShowVisists.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowVisists.Name = "btnShowVisists";
            this.btnShowVisists.Size = new System.Drawing.Size(154, 23);
            this.btnShowVisists.TabIndex = 13;
            this.btnShowVisists.Text = "Pokaż Wizyty";
            this.btnShowVisists.UseVisualStyleBackColor = true;
            this.btnShowVisists.Click += new System.EventHandler(this.btnShowVisists_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.Controls.Add(this.showCanceled);
            this.Rejestracja.Controls.Add(this.visitsView);
            this.Rejestracja.Controls.Add(this.cancelVisit);
            this.Rejestracja.Location = new System.Drawing.Point(4, 244);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(783, 313);
            this.Rejestracja.TabIndex = 14;
            this.Rejestracja.TabStop = false;
            this.Rejestracja.Text = "Wizyty";
            // 
            // showCanceled
            // 
            this.showCanceled.AutoSize = true;
            this.showCanceled.Location = new System.Drawing.Point(502, 288);
            this.showCanceled.Name = "showCanceled";
            this.showCanceled.Size = new System.Drawing.Size(111, 17);
            this.showCanceled.TabIndex = 12;
            this.showCanceled.Text = "Pokaż anulowane";
            this.showCanceled.UseVisualStyleBackColor = true;
            // 
            // Pacjenci
            // 
            this.Pacjenci.Controls.Add(this.patientDataGrid);
            this.Pacjenci.Controls.Add(this.registration);
            this.Pacjenci.Controls.Add(this.addPatient);
            this.Pacjenci.Controls.Add(this.btnShowVisists);
            this.Pacjenci.Controls.Add(this.editPatient);
            this.Pacjenci.Location = new System.Drawing.Point(4, 29);
            this.Pacjenci.Name = "Pacjenci";
            this.Pacjenci.Size = new System.Drawing.Size(783, 209);
            this.Pacjenci.TabIndex = 15;
            this.Pacjenci.TabStop = false;
            this.Pacjenci.Text = "Pacjenci";
            // 
            // patientDataGrid
            // 
            this.patientDataGrid.AllowUserToAddRows = false;
            this.patientDataGrid.AllowUserToDeleteRows = false;
            this.patientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.patientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_name,
            this.patient_last_name,
            this.patient_pesel});
            this.patientDataGrid.Location = new System.Drawing.Point(6, 19);
            this.patientDataGrid.MultiSelect = false;
            this.patientDataGrid.Name = "patientDataGrid";
            this.patientDataGrid.ReadOnly = true;
            this.patientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientDataGrid.Size = new System.Drawing.Size(768, 156);
            this.patientDataGrid.TabIndex = 14;
            // 
            // patient_name
            // 
            this.patient_name.HeaderText = "Imię";
            this.patient_name.Name = "patient_name";
            this.patient_name.ReadOnly = true;
            this.patient_name.Width = 51;
            // 
            // patient_last_name
            // 
            this.patient_last_name.HeaderText = "Nazwisko";
            this.patient_last_name.Name = "patient_last_name";
            this.patient_last_name.ReadOnly = true;
            this.patient_last_name.Width = 78;
            // 
            // patient_pesel
            // 
            this.patient_pesel.HeaderText = "PESEL";
            this.patient_pesel.Name = "patient_pesel";
            this.patient_pesel.ReadOnly = true;
            this.patient_pesel.Width = 66;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 556);
            this.Controls.Add(this.Pacjenci);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.peselNumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.register_Close);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.Rejestracja.ResumeLayout(false);
            this.Rejestracja.PerformLayout();
            this.Pacjenci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox peselNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView visitsView;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.Button editPatient;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Button cancelVisit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnShowVisists;
        private System.Windows.Forms.GroupBox Rejestracja;
        private System.Windows.Forms.GroupBox Pacjenci;
        private System.Windows.Forms.DataGridView patientDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn visit_doctor;
        private System.Windows.Forms.CheckBox showCanceled;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}