namespace MedicalClinic
{
    partial class CreateUsers
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.boxUserType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 20);
            this.txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Location = new System.Drawing.Point(4, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nazwisko";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 19);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(326, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imię";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLogin);
            this.groupBox3.Location = new System.Drawing.Point(4, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 49);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 19);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(326, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Location = new System.Drawing.Point(4, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 49);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasło";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(326, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // boxUserType
            // 
            this.boxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxUserType.FormattingEnabled = true;
            this.boxUserType.Location = new System.Drawing.Point(6, 19);
            this.boxUserType.Name = "boxUserType";
            this.boxUserType.Size = new System.Drawing.Size(326, 21);
            this.boxUserType.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.boxUserType);
            this.groupBox5.Location = new System.Drawing.Point(4, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 49);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Typ uzytkownika";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(267, 342);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(186, 342);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Wyczyść";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(105, 342);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Utwórz";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.expirationDate);
            this.groupBox6.Location = new System.Drawing.Point(4, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 49);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data wygaśnięcia";
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(6, 19);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(326, 20);
            this.expirationDate.TabIndex = 0;
            // 
            // CreateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 372);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateUsers";
            this.Load += new System.EventHandler(this.CreateUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox boxUserType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker expirationDate;
    }
}