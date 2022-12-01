namespace OS_lab_1
{
    partial class Threadscs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThreads = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 61);
            this.panel1.TabIndex = 0;
            // 
            // dgvThreads
            // 
            this.dgvThreads.AllowUserToAddRows = false;
            this.dgvThreads.AllowUserToDeleteRows = false;
            this.dgvThreads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThreads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThreads.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcId,
            this.dgvcPriority});
            this.dgvThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThreads.Location = new System.Drawing.Point(0, 61);
            this.dgvThreads.Name = "dgvThreads";
            this.dgvThreads.ReadOnly = true;
            this.dgvThreads.Size = new System.Drawing.Size(656, 239);
            this.dgvThreads.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(3, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblID.Location = new System.Drawing.Point(3, 33);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "label1";
            // 
            // dgvcId
            // 
            this.dgvcId.HeaderText = "Id потока";
            this.dgvcId.Name = "dgvcId";
            this.dgvcId.ReadOnly = true;
            // 
            // dgvcPriority
            // 
            this.dgvcPriority.HeaderText = "Приоритет";
            this.dgvcPriority.Name = "dgvcPriority";
            this.dgvcPriority.ReadOnly = true;
            // 
            // Threadscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 300);
            this.Controls.Add(this.dgvThreads);
            this.Controls.Add(this.panel1);
            this.Name = "Threadscs";
            this.Text = "Threadscs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThreads)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThreads;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcPriority;
    }
}