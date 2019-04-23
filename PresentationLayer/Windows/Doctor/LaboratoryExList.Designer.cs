namespace MedicalClinic
{
    partial class LaboratoryExList
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
            this.LaboratoryExaminationList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryExaminationList)).BeginInit();
            this.SuspendLayout();
            // 
            // LaboratoryExaminationList
            // 
            this.LaboratoryExaminationList.AllowUserToAddRows = false;
            this.LaboratoryExaminationList.AllowUserToDeleteRows = false;
            this.LaboratoryExaminationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaboratoryExaminationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.status});
            this.LaboratoryExaminationList.Location = new System.Drawing.Point(12, 12);
            this.LaboratoryExaminationList.Name = "LaboratoryExaminationList";
            this.LaboratoryExaminationList.ReadOnly = true;
            this.LaboratoryExaminationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LaboratoryExaminationList.Size = new System.Drawing.Size(539, 178);
            this.LaboratoryExaminationList.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Nazwa Badania";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(303, 197);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(79, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Zleć";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(388, 197);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(82, 23);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Przeglaj";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(476, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Wróć";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LaboratoryExList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 232);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.LaboratoryExaminationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LaboratoryExList";
            this.Text = "LaboratoryExList";
            this.Load += new System.EventHandler(this.LaboratoryExList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaboratoryExaminationList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LaboratoryExaminationList;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}