namespace MedicalClinic
{
    partial class OrderLaboratory
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.doctorNote = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.examinationList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(357, 224);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Location = new System.Drawing.Point(261, 223);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Zleć";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(9, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Komentarz";
            // 
            // doctorNote
            // 
            this.doctorNote.Location = new System.Drawing.Point(6, 83);
            this.doctorNote.Multiline = true;
            this.doctorNote.Name = "doctorNote";
            this.doctorNote.Size = new System.Drawing.Size(435, 134);
            this.doctorNote.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.examinationList);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nazwa Badania";
            // 
            // examinationList
            // 
            this.examinationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.examinationList.Location = new System.Drawing.Point(6, 19);
            this.examinationList.Name = "examinationList";
            this.examinationList.Size = new System.Drawing.Size(174, 21);
            this.examinationList.TabIndex = 0;
            this.examinationList.SelectedIndexChanged += new System.EventHandler(this.examinationList_SelectedIndexChanged);
            // 
            // OrderLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 259);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.doctorNote);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderLaboratory";
            this.Text = "OrderLaboratory";
            this.Load += new System.EventHandler(this.OrderLaboratory_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox doctorNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox examinationList;
    }
}