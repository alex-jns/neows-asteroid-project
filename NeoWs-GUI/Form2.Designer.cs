namespace NeoWs_GUI
{
    partial class Form2
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
            this.AdvancedSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.AbsoluteMagnitudeComboBox = new System.Windows.Forms.ComboBox();
            this.AsboluteMagnitudeSearchLabel = new System.Windows.Forms.Label();
            this.Form2Cancel = new System.Windows.Forms.Button();
            this.Form2Search = new System.Windows.Forms.Button();
            this.AbsoluteMagnitudeValueTextBox = new System.Windows.Forms.TextBox();
            this.AdvancedSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdvancedSearchGroupBox
            // 
            this.AdvancedSearchGroupBox.Controls.Add(this.AbsoluteMagnitudeValueTextBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AbsoluteMagnitudeComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AsboluteMagnitudeSearchLabel);
            this.AdvancedSearchGroupBox.Location = new System.Drawing.Point(13, 13);
            this.AdvancedSearchGroupBox.Name = "AdvancedSearchGroupBox";
            this.AdvancedSearchGroupBox.Size = new System.Drawing.Size(329, 100);
            this.AdvancedSearchGroupBox.TabIndex = 0;
            this.AdvancedSearchGroupBox.TabStop = false;
            this.AdvancedSearchGroupBox.Text = "Advanced Search";
            // 
            // AbsoluteMagnitudeComboBox
            // 
            this.AbsoluteMagnitudeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AbsoluteMagnitudeComboBox.FormattingEnabled = true;
            this.AbsoluteMagnitudeComboBox.Items.AddRange(new object[] {
            "is greater than",
            "is less than",
            "is equal to"});
            this.AbsoluteMagnitudeComboBox.Location = new System.Drawing.Point(120, 20);
            this.AbsoluteMagnitudeComboBox.Name = "AbsoluteMagnitudeComboBox";
            this.AbsoluteMagnitudeComboBox.Size = new System.Drawing.Size(97, 21);
            this.AbsoluteMagnitudeComboBox.TabIndex = 3;
            // 
            // AsboluteMagnitudeSearchLabel
            // 
            this.AsboluteMagnitudeSearchLabel.AutoSize = true;
            this.AsboluteMagnitudeSearchLabel.Location = new System.Drawing.Point(7, 23);
            this.AsboluteMagnitudeSearchLabel.Name = "AsboluteMagnitudeSearchLabel";
            this.AsboluteMagnitudeSearchLabel.Size = new System.Drawing.Size(101, 13);
            this.AsboluteMagnitudeSearchLabel.TabIndex = 2;
            this.AsboluteMagnitudeSearchLabel.Text = "Absolute Magnitude";
            // 
            // Form2Cancel
            // 
            this.Form2Cancel.Location = new System.Drawing.Point(12, 119);
            this.Form2Cancel.Name = "Form2Cancel";
            this.Form2Cancel.Size = new System.Drawing.Size(75, 23);
            this.Form2Cancel.TabIndex = 1;
            this.Form2Cancel.Text = "Cancel";
            this.Form2Cancel.UseVisualStyleBackColor = true;
            this.Form2Cancel.Click += new System.EventHandler(this.Form2Cancel_Click);
            // 
            // Form2Search
            // 
            this.Form2Search.Location = new System.Drawing.Point(93, 119);
            this.Form2Search.Name = "Form2Search";
            this.Form2Search.Size = new System.Drawing.Size(75, 23);
            this.Form2Search.TabIndex = 2;
            this.Form2Search.Text = "Search";
            this.Form2Search.UseVisualStyleBackColor = true;
            this.Form2Search.Click += new System.EventHandler(this.Form2Search_Click);
            // 
            // AbsoluteMagnitudeValueTextBox
            // 
            this.AbsoluteMagnitudeValueTextBox.Location = new System.Drawing.Point(223, 19);
            this.AbsoluteMagnitudeValueTextBox.Name = "AbsoluteMagnitudeValueTextBox";
            this.AbsoluteMagnitudeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AbsoluteMagnitudeValueTextBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 157);
            this.ControlBox = false;
            this.Controls.Add(this.Form2Search);
            this.Controls.Add(this.Form2Cancel);
            this.Controls.Add(this.AdvancedSearchGroupBox);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Small-Body Object Lookup";
            this.TopMost = true;
            this.AdvancedSearchGroupBox.ResumeLayout(false);
            this.AdvancedSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdvancedSearchGroupBox;
        private System.Windows.Forms.Label AsboluteMagnitudeSearchLabel;
        private System.Windows.Forms.Button Form2Cancel;
        private System.Windows.Forms.Button Form2Search;
        private System.Windows.Forms.ComboBox AbsoluteMagnitudeComboBox;
        private System.Windows.Forms.TextBox AbsoluteMagnitudeValueTextBox;
    }
}