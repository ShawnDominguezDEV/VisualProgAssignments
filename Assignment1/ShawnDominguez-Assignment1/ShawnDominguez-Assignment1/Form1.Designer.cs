namespace ShawnDominguez_Assignment1
{
    partial class Form1
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
            this.listPromptLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.prompt2Label = new System.Windows.Forms.Label();
            this.currencyListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.prompt1Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPromptLabel
            // 
            this.listPromptLabel.AutoSize = true;
            this.listPromptLabel.Location = new System.Drawing.Point(16, 157);
            this.listPromptLabel.Name = "listPromptLabel";
            this.listPromptLabel.Size = new System.Drawing.Size(237, 20);
            this.listPromptLabel.TabIndex = 20;
            this.listPromptLabel.Text = "Choose a currency to convert to:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(334, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 50);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(175, 359);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 50);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(12, 359);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(118, 50);
            this.convertButton.TabIndex = 17;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(313, 308);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(139, 26);
            this.outputLabel.TabIndex = 16;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prompt2Label
            // 
            this.prompt2Label.Location = new System.Drawing.Point(8, 295);
            this.prompt2Label.Name = "prompt2Label";
            this.prompt2Label.Size = new System.Drawing.Size(245, 53);
            this.prompt2Label.TabIndex = 15;
            this.prompt2Label.Text = "The conversion value is:";
            this.prompt2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyListBox
            // 
            this.currencyListBox.FormattingEnabled = true;
            this.currencyListBox.ItemHeight = 20;
            this.currencyListBox.Items.AddRange(new object[] {
            "Australian Dollar",
            "Chinese Yuan",
            "Euro",
            "Japanese Yen",
            "UK Pound"});
            this.currencyListBox.Location = new System.Drawing.Point(12, 180);
            this.currencyListBox.Name = "currencyListBox";
            this.currencyListBox.Size = new System.Drawing.Size(440, 104);
            this.currencyListBox.TabIndex = 14;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(313, 75);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(139, 26);
            this.inputTextBox.TabIndex = 13;
            // 
            // prompt1Label
            // 
            this.prompt1Label.Location = new System.Drawing.Point(8, 48);
            this.prompt1Label.Name = "prompt1Label";
            this.prompt1Label.Size = new System.Drawing.Size(245, 80);
            this.prompt1Label.TabIndex = 12;
            this.prompt1Label.Text = "Please enter the amount in US Dollars ($) you would like to convert:";
            this.prompt1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(8, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(416, 25);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Currency Converter by Shawn Dominguez";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 430);
            this.Controls.Add(this.listPromptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.prompt2Label);
            this.Controls.Add(this.currencyListBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.prompt1Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Shawn Dominguez - Assignment 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listPromptLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label prompt2Label;
        private System.Windows.Forms.ListBox currencyListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label prompt1Label;
        private System.Windows.Forms.Label titleLabel;
    }
}

