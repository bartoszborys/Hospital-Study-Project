namespace MedicalClinic
{
    partial class VisitsList
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
            this.visits = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.peselNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.visitDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showVisit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visits
            // 
            this.visits.AllowUserToAddRows = false;
            this.visits.AllowUserToDeleteRows = false;
            this.visits.AllowUserToResizeColumns = false;
            this.visits.AllowUserToResizeRows = false;
            this.visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.patient_name,
            this.patient_last_name,
            this.patient_pesel,
            this.registration_date,
            this.status});
            this.visits.Location = new System.Drawing.Point(7, 84);
            this.visits.MultiSelect = false;
            this.visits.Name = "visits";
            this.visits.ReadOnly = true;
            this.visits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visits.Size = new System.Drawing.Size(765, 334);
            this.visits.TabIndex = 0;
            this.visits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visits_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // patient_name
            // 
            this.patient_name.HeaderText = "Imie";
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
            // registration_date
            // 
            this.registration_date.HeaderText = "Data Rejestracji";
            this.registration_date.Name = "registration_date";
            this.registration_date.ReadOnly = true;
            this.registration_date.Width = 98;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 62;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(620, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(152, 67);
            this.search.TabIndex = 13;
            this.search.Text = "Szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pesel";
            // 
            // peselNumber
            // 
            this.peselNumber.Location = new System.Drawing.Point(451, 12);
            this.peselNumber.MaxLength = 11;
            this.peselNumber.Name = "peselNumber";
            this.peselNumber.Size = new System.Drawing.Size(163, 20);
            this.peselNumber.TabIndex = 11;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(41, 13);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 20);
            this.name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Imie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwisko";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(256, 13);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(150, 20);
            this.lastName.TabIndex = 7;
            // 
            // visitDate
            // 
            this.visitDate.Location = new System.Drawing.Point(6, 14);
            this.visitDate.Name = "visitDate";
            this.visitDate.Size = new System.Drawing.Size(595, 20);
            this.visitDate.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visitDate);
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 40);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // showVisit
            // 
            this.showVisit.Location = new System.Drawing.Point(600, 424);
            this.showVisit.Name = "showVisit";
            this.showVisit.Size = new System.Drawing.Size(172, 23);
            this.showVisit.TabIndex = 17;
            this.showVisit.Text = "Pokaż Wizyte";
            this.showVisit.UseVisualStyleBackColor = true;
            this.showVisit.Click += new System.EventHandler(this.showVisit_Click);
            // 
            // VisitsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.showVisit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.peselNumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.visits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VisitsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitsList";
            this.Load += new System.EventHandler(this.VisitsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView visits;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox peselNumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.DateTimePicker visitDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}