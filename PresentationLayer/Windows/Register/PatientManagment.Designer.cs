namespace MedicalClinic
{
    partial class PatientManagment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.peselNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesel";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(9, 84);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(111, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Zatwierdź";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(126, 84);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(65, 12);
            this.name.MaxLength = 50;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 20);
            this.name.TabIndex = 14;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(65, 35);
            this.lastName.MaxLength = 50;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(165, 20);
            this.lastName.TabIndex = 15;
            // 
            // peselNumber
            // 
            this.peselNumber.Location = new System.Drawing.Point(65, 58);
            this.peselNumber.MaxLength = 11;
            this.peselNumber.Name = "peselNumber";
            this.peselNumber.Size = new System.Drawing.Size(165, 20);
            this.peselNumber.TabIndex = 16;
            // 
            // PatientManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 114);
            this.Controls.Add(this.peselNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PatientManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPatientRowManagment";
            this.Load += new System.EventHandler(this.RegisterPatientRowManagment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox peselNumber;
    }
}