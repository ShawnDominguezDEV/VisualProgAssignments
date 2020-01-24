namespace SportsProUserInterfaceLayer
{
    partial class FrmViewIncidentsByTechnician
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
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.dgvIncidentsByTechnician = new System.Windows.Forms.DataGridView();
            this.txtTechnician = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetIncidents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(952, 399);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(282, 72);
            this.btnReturnToMainMenu.TabIndex = 9;
            this.btnReturnToMainMenu.Text = "Return To Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // dgvIncidentsByTechnician
            // 
            this.dgvIncidentsByTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIncidentsByTechnician.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncidentsByTechnician.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvIncidentsByTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidentsByTechnician.Location = new System.Drawing.Point(31, 92);
            this.dgvIncidentsByTechnician.Name = "dgvIncidentsByTechnician";
            this.dgvIncidentsByTechnician.RowTemplate.Height = 28;
            this.dgvIncidentsByTechnician.Size = new System.Drawing.Size(1203, 274);
            this.dgvIncidentsByTechnician.TabIndex = 8;
            // 
            // txtTechnician
            // 
            this.txtTechnician.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechnician.Location = new System.Drawing.Point(380, 21);
            this.txtTechnician.Name = "txtTechnician";
            this.txtTechnician.Size = new System.Drawing.Size(270, 35);
            this.txtTechnician.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter Technician ID:";
            // 
            // btnGetIncidents
            // 
            this.btnGetIncidents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGetIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetIncidents.Location = new System.Drawing.Point(736, 18);
            this.btnGetIncidents.Name = "btnGetIncidents";
            this.btnGetIncidents.Size = new System.Drawing.Size(170, 41);
            this.btnGetIncidents.TabIndex = 5;
            this.btnGetIncidents.Text = "Get Incidents";
            this.btnGetIncidents.UseVisualStyleBackColor = true;
            this.btnGetIncidents.Click += new System.EventHandler(this.btnGetIncidents_Click);
            // 
            // FrmViewIncidentsByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 483);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.dgvIncidentsByTechnician);
            this.Controls.Add(this.txtTechnician);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetIncidents);
            this.Name = "FrmViewIncidentsByTechnician";
            this.Text = "FrmViewIncidentsByTechnician";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidentsByTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.DataGridView dgvIncidentsByTechnician;
        private System.Windows.Forms.TextBox txtTechnician;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetIncidents;
    }
}