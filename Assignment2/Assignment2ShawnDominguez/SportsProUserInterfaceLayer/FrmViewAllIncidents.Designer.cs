namespace SportsProUserInterfaceLayer
{
    partial class FrmViewAllIncidents
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
            this.dgvViewAllIncidents = new System.Windows.Forms.DataGridView();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllIncidents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewAllIncidents
            // 
            this.dgvViewAllIncidents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViewAllIncidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewAllIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAllIncidents.Location = new System.Drawing.Point(13, 6);
            this.dgvViewAllIncidents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewAllIncidents.Name = "dgvViewAllIncidents";
            this.dgvViewAllIncidents.Size = new System.Drawing.Size(1362, 514);
            this.dgvViewAllIncidents.TabIndex = 0;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(1143, 569);
            this.btnReturnToMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(226, 43);
            this.btnReturnToMainMenu.TabIndex = 1;
            this.btnReturnToMainMenu.Text = "Return To Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // FrmViewAllIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1382, 616);
            this.Controls.Add(this.btnReturnToMainMenu);
            this.Controls.Add(this.dgvViewAllIncidents);
            this.Name = "FrmViewAllIncidents";
            this.Text = "List of All Incidents";
            this.Load += new System.EventHandler(this.FrmViewAllIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAllIncidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewAllIncidents;
        private System.Windows.Forms.Button btnReturnToMainMenu;
    }
}