namespace NeoWs_GUI
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.NeoListBox = new System.Windows.Forms.ListBox();
            this.ShowInformationButton = new System.Windows.Forms.Button();
            this.RetrieveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.GeneralInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.PotentiallyHazardousTextBox = new System.Windows.Forms.TextBox();
            this.SentryObjectTextBox = new System.Windows.Forms.TextBox();
            this.SentryObjectLabel = new System.Windows.Forms.Label();
            this.AbsoluteMagnitudeTextBox = new System.Windows.Forms.TextBox();
            this.PotentiallyHazardousLabel = new System.Windows.Forms.Label();
            this.CloseApproachDateTextBox = new System.Windows.Forms.TextBox();
            this.OrbitingBodyTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AbsoluteMagnitudeLabel = new System.Windows.Forms.Label();
            this.CloseApproachDateLabel = new System.Windows.Forms.Label();
            this.OrbitingBodyLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EstimatedDiameterGroupBox = new System.Windows.Forms.GroupBox();
            this.MaximumGroupBox = new System.Windows.Forms.GroupBox();
            this.MaximumKilometersTextBox = new System.Windows.Forms.TextBox();
            this.MaximumMetersLabel = new System.Windows.Forms.Label();
            this.MaximumKilometersLabel = new System.Windows.Forms.Label();
            this.MaximumFeetLabel = new System.Windows.Forms.Label();
            this.MaximumMilesTextBox = new System.Windows.Forms.TextBox();
            this.MaximumFeetTextBox = new System.Windows.Forms.TextBox();
            this.MaximumMilesLabel = new System.Windows.Forms.Label();
            this.MaximumMetersTextBox = new System.Windows.Forms.TextBox();
            this.MinimumGroupBox = new System.Windows.Forms.GroupBox();
            this.MinimumKilometersTextBox = new System.Windows.Forms.TextBox();
            this.MinimumKilometersLabel = new System.Windows.Forms.Label();
            this.MinimumMilesTextBox = new System.Windows.Forms.TextBox();
            this.MinimumMilesLabel = new System.Windows.Forms.Label();
            this.MinimumMetersTextBox = new System.Windows.Forms.TextBox();
            this.MinimumMetersLabel = new System.Windows.Forms.Label();
            this.MinimumFeetTextBox = new System.Windows.Forms.TextBox();
            this.MinimumFeetLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MilesPerHourTextBox = new System.Windows.Forms.TextBox();
            this.KilometersPerHourTextBox = new System.Windows.Forms.TextBox();
            this.KilometersPerSecondTextBox = new System.Windows.Forms.TextBox();
            this.MilesPerHourLabel = new System.Windows.Forms.Label();
            this.KilometersPerHourLabel = new System.Windows.Forms.Label();
            this.KilometersPerSecondLabel = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MissDistanceLunarTextBox = new System.Windows.Forms.TextBox();
            this.MissDistanceAstronomicalTextBox = new System.Windows.Forms.TextBox();
            this.MissDistanceKilometersTextBox = new System.Windows.Forms.TextBox();
            this.MissDistanceAstronomicalLabel = new System.Windows.Forms.Label();
            this.MissDistanceLunarLabel = new System.Windows.Forms.Label();
            this.MissDistanceKilometersLabel = new System.Windows.Forms.Label();
            this.MissDistanceMilesTextBox = new System.Windows.Forms.TextBox();
            this.MissDistanceMilesLabel = new System.Windows.Forms.Label();
            this.DatabaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ElementCountLabel = new System.Windows.Forms.Label();
            this.ElementCountTextBox = new System.Windows.Forms.TextBox();
            this.RetrieveDataGroupBox.SuspendLayout();
            this.GeneralInformationGroupBox.SuspendLayout();
            this.EstimatedDiameterGroupBox.SuspendLayout();
            this.MaximumGroupBox.SuspendLayout();
            this.MinimumGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(6, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(91, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // NeoListBox
            // 
            this.NeoListBox.FormattingEnabled = true;
            this.NeoListBox.Location = new System.Drawing.Point(12, 121);
            this.NeoListBox.Name = "NeoListBox";
            this.NeoListBox.Size = new System.Drawing.Size(200, 290);
            this.NeoListBox.TabIndex = 1;
            // 
            // ShowInformationButton
            // 
            this.ShowInformationButton.Location = new System.Drawing.Point(12, 415);
            this.ShowInformationButton.Name = "ShowInformationButton";
            this.ShowInformationButton.Size = new System.Drawing.Size(200, 23);
            this.ShowInformationButton.TabIndex = 2;
            this.ShowInformationButton.Text = "Show Information";
            this.ShowInformationButton.UseVisualStyleBackColor = true;
            this.ShowInformationButton.Click += new System.EventHandler(this.ShowInformationButton_Click);
            // 
            // RetrieveDataGroupBox
            // 
            this.RetrieveDataGroupBox.Controls.Add(this.AdvancedSearchButton);
            this.RetrieveDataGroupBox.Controls.Add(this.DateTextBox);
            this.RetrieveDataGroupBox.Controls.Add(this.DateLabel);
            this.RetrieveDataGroupBox.Controls.Add(this.SearchButton);
            this.RetrieveDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RetrieveDataGroupBox.Name = "RetrieveDataGroupBox";
            this.RetrieveDataGroupBox.Size = new System.Drawing.Size(200, 77);
            this.RetrieveDataGroupBox.TabIndex = 4;
            this.RetrieveDataGroupBox.TabStop = false;
            this.RetrieveDataGroupBox.Text = "Retrieve Data";
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Location = new System.Drawing.Point(103, 46);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(91, 23);
            this.AdvancedSearchButton.TabIndex = 11;
            this.AdvancedSearchButton.Text = "Advanced";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            this.AdvancedSearchButton.Click += new System.EventHandler(this.AdvancedSearchButton_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(45, 20);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(149, 20);
            this.DateTextBox.TabIndex = 2;
            this.DateTextBox.Text = "YYYY-MM-DD";
            this.DateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(6, 23);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(33, 13);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Date:";
            // 
            // GeneralInformationGroupBox
            // 
            this.GeneralInformationGroupBox.Controls.Add(this.PotentiallyHazardousTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.SentryObjectTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.SentryObjectLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.AbsoluteMagnitudeTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.PotentiallyHazardousLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.CloseApproachDateTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.OrbitingBodyTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.IDTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.NameTextBox);
            this.GeneralInformationGroupBox.Controls.Add(this.AbsoluteMagnitudeLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.CloseApproachDateLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.OrbitingBodyLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.IDLabel);
            this.GeneralInformationGroupBox.Controls.Add(this.NameLabel);
            this.GeneralInformationGroupBox.Location = new System.Drawing.Point(219, 13);
            this.GeneralInformationGroupBox.Name = "GeneralInformationGroupBox";
            this.GeneralInformationGroupBox.Size = new System.Drawing.Size(314, 127);
            this.GeneralInformationGroupBox.TabIndex = 5;
            this.GeneralInformationGroupBox.TabStop = false;
            this.GeneralInformationGroupBox.Text = "General Information";
            // 
            // PotentiallyHazardousTextBox
            // 
            this.PotentiallyHazardousTextBox.BackColor = System.Drawing.Color.White;
            this.PotentiallyHazardousTextBox.Location = new System.Drawing.Point(120, 97);
            this.PotentiallyHazardousTextBox.Name = "PotentiallyHazardousTextBox";
            this.PotentiallyHazardousTextBox.ReadOnly = true;
            this.PotentiallyHazardousTextBox.Size = new System.Drawing.Size(60, 20);
            this.PotentiallyHazardousTextBox.TabIndex = 14;
            // 
            // SentryObjectTextBox
            // 
            this.SentryObjectTextBox.BackColor = System.Drawing.Color.White;
            this.SentryObjectTextBox.Location = new System.Drawing.Point(260, 97);
            this.SentryObjectTextBox.Name = "SentryObjectTextBox";
            this.SentryObjectTextBox.ReadOnly = true;
            this.SentryObjectTextBox.Size = new System.Drawing.Size(46, 20);
            this.SentryObjectTextBox.TabIndex = 13;
            // 
            // SentryObjectLabel
            // 
            this.SentryObjectLabel.AutoSize = true;
            this.SentryObjectLabel.Location = new System.Drawing.Point(183, 100);
            this.SentryObjectLabel.Name = "SentryObjectLabel";
            this.SentryObjectLabel.Size = new System.Drawing.Size(74, 13);
            this.SentryObjectLabel.TabIndex = 12;
            this.SentryObjectLabel.Text = "Sentry Object:";
            // 
            // AbsoluteMagnitudeTextBox
            // 
            this.AbsoluteMagnitudeTextBox.BackColor = System.Drawing.Color.White;
            this.AbsoluteMagnitudeTextBox.Location = new System.Drawing.Point(257, 44);
            this.AbsoluteMagnitudeTextBox.Name = "AbsoluteMagnitudeTextBox";
            this.AbsoluteMagnitudeTextBox.ReadOnly = true;
            this.AbsoluteMagnitudeTextBox.Size = new System.Drawing.Size(49, 20);
            this.AbsoluteMagnitudeTextBox.TabIndex = 10;
            // 
            // PotentiallyHazardousLabel
            // 
            this.PotentiallyHazardousLabel.AutoSize = true;
            this.PotentiallyHazardousLabel.Location = new System.Drawing.Point(6, 100);
            this.PotentiallyHazardousLabel.Name = "PotentiallyHazardousLabel";
            this.PotentiallyHazardousLabel.Size = new System.Drawing.Size(112, 13);
            this.PotentiallyHazardousLabel.TabIndex = 11;
            this.PotentiallyHazardousLabel.Text = "Potentially Hazardous:";
            // 
            // CloseApproachDateTextBox
            // 
            this.CloseApproachDateTextBox.BackColor = System.Drawing.Color.White;
            this.CloseApproachDateTextBox.Location = new System.Drawing.Point(124, 71);
            this.CloseApproachDateTextBox.Name = "CloseApproachDateTextBox";
            this.CloseApproachDateTextBox.ReadOnly = true;
            this.CloseApproachDateTextBox.Size = new System.Drawing.Size(182, 20);
            this.CloseApproachDateTextBox.TabIndex = 9;
            // 
            // OrbitingBodyTextBox
            // 
            this.OrbitingBodyTextBox.BackColor = System.Drawing.Color.White;
            this.OrbitingBodyTextBox.Location = new System.Drawing.Point(86, 44);
            this.OrbitingBodyTextBox.Name = "OrbitingBodyTextBox";
            this.OrbitingBodyTextBox.ReadOnly = true;
            this.OrbitingBodyTextBox.Size = new System.Drawing.Size(61, 20);
            this.OrbitingBodyTextBox.TabIndex = 8;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.White;
            this.IDTextBox.Location = new System.Drawing.Point(227, 19);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(79, 20);
            this.IDTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(51, 18);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(143, 20);
            this.NameTextBox.TabIndex = 6;
            // 
            // AbsoluteMagnitudeLabel
            // 
            this.AbsoluteMagnitudeLabel.AutoSize = true;
            this.AbsoluteMagnitudeLabel.Location = new System.Drawing.Point(153, 47);
            this.AbsoluteMagnitudeLabel.Name = "AbsoluteMagnitudeLabel";
            this.AbsoluteMagnitudeLabel.Size = new System.Drawing.Size(104, 13);
            this.AbsoluteMagnitudeLabel.TabIndex = 5;
            this.AbsoluteMagnitudeLabel.Text = "Absolute Magnitude:";
            // 
            // CloseApproachDateLabel
            // 
            this.CloseApproachDateLabel.AutoSize = true;
            this.CloseApproachDateLabel.Location = new System.Drawing.Point(7, 74);
            this.CloseApproachDateLabel.Name = "CloseApproachDateLabel";
            this.CloseApproachDateLabel.Size = new System.Drawing.Size(111, 13);
            this.CloseApproachDateLabel.TabIndex = 4;
            this.CloseApproachDateLabel.Text = "Close Approach Date:";
            // 
            // OrbitingBodyLabel
            // 
            this.OrbitingBodyLabel.AutoSize = true;
            this.OrbitingBodyLabel.Location = new System.Drawing.Point(7, 47);
            this.OrbitingBodyLabel.Name = "OrbitingBodyLabel";
            this.OrbitingBodyLabel.Size = new System.Drawing.Size(73, 13);
            this.OrbitingBodyLabel.TabIndex = 3;
            this.OrbitingBodyLabel.Text = "Orbiting Body:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(200, 22);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // EstimatedDiameterGroupBox
            // 
            this.EstimatedDiameterGroupBox.Controls.Add(this.MaximumGroupBox);
            this.EstimatedDiameterGroupBox.Controls.Add(this.MinimumGroupBox);
            this.EstimatedDiameterGroupBox.Location = new System.Drawing.Point(219, 146);
            this.EstimatedDiameterGroupBox.Name = "EstimatedDiameterGroupBox";
            this.EstimatedDiameterGroupBox.Size = new System.Drawing.Size(523, 153);
            this.EstimatedDiameterGroupBox.TabIndex = 6;
            this.EstimatedDiameterGroupBox.TabStop = false;
            this.EstimatedDiameterGroupBox.Text = "Estimated Diameter";
            // 
            // MaximumGroupBox
            // 
            this.MaximumGroupBox.Controls.Add(this.MaximumKilometersTextBox);
            this.MaximumGroupBox.Controls.Add(this.MaximumMetersLabel);
            this.MaximumGroupBox.Controls.Add(this.MaximumKilometersLabel);
            this.MaximumGroupBox.Controls.Add(this.MaximumFeetLabel);
            this.MaximumGroupBox.Controls.Add(this.MaximumMilesTextBox);
            this.MaximumGroupBox.Controls.Add(this.MaximumFeetTextBox);
            this.MaximumGroupBox.Controls.Add(this.MaximumMilesLabel);
            this.MaximumGroupBox.Controls.Add(this.MaximumMetersTextBox);
            this.MaximumGroupBox.Location = new System.Drawing.Point(266, 20);
            this.MaximumGroupBox.Name = "MaximumGroupBox";
            this.MaximumGroupBox.Size = new System.Drawing.Size(251, 125);
            this.MaximumGroupBox.TabIndex = 1;
            this.MaximumGroupBox.TabStop = false;
            this.MaximumGroupBox.Text = "Maximum";
            // 
            // MaximumKilometersTextBox
            // 
            this.MaximumKilometersTextBox.BackColor = System.Drawing.Color.White;
            this.MaximumKilometersTextBox.Location = new System.Drawing.Point(78, 95);
            this.MaximumKilometersTextBox.Name = "MaximumKilometersTextBox";
            this.MaximumKilometersTextBox.ReadOnly = true;
            this.MaximumKilometersTextBox.Size = new System.Drawing.Size(159, 20);
            this.MaximumKilometersTextBox.TabIndex = 18;
            // 
            // MaximumMetersLabel
            // 
            this.MaximumMetersLabel.AutoSize = true;
            this.MaximumMetersLabel.Location = new System.Drawing.Point(6, 46);
            this.MaximumMetersLabel.Name = "MaximumMetersLabel";
            this.MaximumMetersLabel.Size = new System.Drawing.Size(42, 13);
            this.MaximumMetersLabel.TabIndex = 13;
            this.MaximumMetersLabel.Text = "Meters:";
            // 
            // MaximumKilometersLabel
            // 
            this.MaximumKilometersLabel.AutoSize = true;
            this.MaximumKilometersLabel.Location = new System.Drawing.Point(6, 98);
            this.MaximumKilometersLabel.Name = "MaximumKilometersLabel";
            this.MaximumKilometersLabel.Size = new System.Drawing.Size(58, 13);
            this.MaximumKilometersLabel.TabIndex = 17;
            this.MaximumKilometersLabel.Text = "Kilometers:";
            // 
            // MaximumFeetLabel
            // 
            this.MaximumFeetLabel.AutoSize = true;
            this.MaximumFeetLabel.Location = new System.Drawing.Point(6, 20);
            this.MaximumFeetLabel.Name = "MaximumFeetLabel";
            this.MaximumFeetLabel.Size = new System.Drawing.Size(31, 13);
            this.MaximumFeetLabel.TabIndex = 11;
            this.MaximumFeetLabel.Text = "Feet:";
            // 
            // MaximumMilesTextBox
            // 
            this.MaximumMilesTextBox.BackColor = System.Drawing.Color.White;
            this.MaximumMilesTextBox.Location = new System.Drawing.Point(78, 69);
            this.MaximumMilesTextBox.Name = "MaximumMilesTextBox";
            this.MaximumMilesTextBox.ReadOnly = true;
            this.MaximumMilesTextBox.Size = new System.Drawing.Size(159, 20);
            this.MaximumMilesTextBox.TabIndex = 16;
            // 
            // MaximumFeetTextBox
            // 
            this.MaximumFeetTextBox.BackColor = System.Drawing.Color.White;
            this.MaximumFeetTextBox.Location = new System.Drawing.Point(78, 17);
            this.MaximumFeetTextBox.Name = "MaximumFeetTextBox";
            this.MaximumFeetTextBox.ReadOnly = true;
            this.MaximumFeetTextBox.Size = new System.Drawing.Size(159, 20);
            this.MaximumFeetTextBox.TabIndex = 12;
            // 
            // MaximumMilesLabel
            // 
            this.MaximumMilesLabel.AutoSize = true;
            this.MaximumMilesLabel.Location = new System.Drawing.Point(6, 72);
            this.MaximumMilesLabel.Name = "MaximumMilesLabel";
            this.MaximumMilesLabel.Size = new System.Drawing.Size(34, 13);
            this.MaximumMilesLabel.TabIndex = 15;
            this.MaximumMilesLabel.Text = "Miles:";
            // 
            // MaximumMetersTextBox
            // 
            this.MaximumMetersTextBox.BackColor = System.Drawing.Color.White;
            this.MaximumMetersTextBox.Location = new System.Drawing.Point(78, 43);
            this.MaximumMetersTextBox.Name = "MaximumMetersTextBox";
            this.MaximumMetersTextBox.ReadOnly = true;
            this.MaximumMetersTextBox.Size = new System.Drawing.Size(159, 20);
            this.MaximumMetersTextBox.TabIndex = 14;
            // 
            // MinimumGroupBox
            // 
            this.MinimumGroupBox.Controls.Add(this.MinimumKilometersTextBox);
            this.MinimumGroupBox.Controls.Add(this.MinimumKilometersLabel);
            this.MinimumGroupBox.Controls.Add(this.MinimumMilesTextBox);
            this.MinimumGroupBox.Controls.Add(this.MinimumMilesLabel);
            this.MinimumGroupBox.Controls.Add(this.MinimumMetersTextBox);
            this.MinimumGroupBox.Controls.Add(this.MinimumMetersLabel);
            this.MinimumGroupBox.Controls.Add(this.MinimumFeetTextBox);
            this.MinimumGroupBox.Controls.Add(this.MinimumFeetLabel);
            this.MinimumGroupBox.Location = new System.Drawing.Point(10, 20);
            this.MinimumGroupBox.Name = "MinimumGroupBox";
            this.MinimumGroupBox.Size = new System.Drawing.Size(250, 125);
            this.MinimumGroupBox.TabIndex = 0;
            this.MinimumGroupBox.TabStop = false;
            this.MinimumGroupBox.Text = "Minimum";
            // 
            // MinimumKilometersTextBox
            // 
            this.MinimumKilometersTextBox.BackColor = System.Drawing.Color.White;
            this.MinimumKilometersTextBox.Location = new System.Drawing.Point(76, 95);
            this.MinimumKilometersTextBox.Name = "MinimumKilometersTextBox";
            this.MinimumKilometersTextBox.ReadOnly = true;
            this.MinimumKilometersTextBox.Size = new System.Drawing.Size(159, 20);
            this.MinimumKilometersTextBox.TabIndex = 10;
            // 
            // MinimumKilometersLabel
            // 
            this.MinimumKilometersLabel.AutoSize = true;
            this.MinimumKilometersLabel.Location = new System.Drawing.Point(6, 98);
            this.MinimumKilometersLabel.Name = "MinimumKilometersLabel";
            this.MinimumKilometersLabel.Size = new System.Drawing.Size(58, 13);
            this.MinimumKilometersLabel.TabIndex = 9;
            this.MinimumKilometersLabel.Text = "Kilometers:";
            // 
            // MinimumMilesTextBox
            // 
            this.MinimumMilesTextBox.BackColor = System.Drawing.Color.White;
            this.MinimumMilesTextBox.Location = new System.Drawing.Point(76, 69);
            this.MinimumMilesTextBox.Name = "MinimumMilesTextBox";
            this.MinimumMilesTextBox.ReadOnly = true;
            this.MinimumMilesTextBox.Size = new System.Drawing.Size(159, 20);
            this.MinimumMilesTextBox.TabIndex = 8;
            // 
            // MinimumMilesLabel
            // 
            this.MinimumMilesLabel.AutoSize = true;
            this.MinimumMilesLabel.Location = new System.Drawing.Point(6, 72);
            this.MinimumMilesLabel.Name = "MinimumMilesLabel";
            this.MinimumMilesLabel.Size = new System.Drawing.Size(34, 13);
            this.MinimumMilesLabel.TabIndex = 7;
            this.MinimumMilesLabel.Text = "Miles:";
            // 
            // MinimumMetersTextBox
            // 
            this.MinimumMetersTextBox.BackColor = System.Drawing.Color.White;
            this.MinimumMetersTextBox.Location = new System.Drawing.Point(76, 43);
            this.MinimumMetersTextBox.Name = "MinimumMetersTextBox";
            this.MinimumMetersTextBox.ReadOnly = true;
            this.MinimumMetersTextBox.Size = new System.Drawing.Size(159, 20);
            this.MinimumMetersTextBox.TabIndex = 6;
            // 
            // MinimumMetersLabel
            // 
            this.MinimumMetersLabel.AutoSize = true;
            this.MinimumMetersLabel.Location = new System.Drawing.Point(6, 46);
            this.MinimumMetersLabel.Name = "MinimumMetersLabel";
            this.MinimumMetersLabel.Size = new System.Drawing.Size(42, 13);
            this.MinimumMetersLabel.TabIndex = 5;
            this.MinimumMetersLabel.Text = "Meters:";
            // 
            // MinimumFeetTextBox
            // 
            this.MinimumFeetTextBox.BackColor = System.Drawing.Color.White;
            this.MinimumFeetTextBox.Location = new System.Drawing.Point(76, 17);
            this.MinimumFeetTextBox.Name = "MinimumFeetTextBox";
            this.MinimumFeetTextBox.ReadOnly = true;
            this.MinimumFeetTextBox.Size = new System.Drawing.Size(159, 20);
            this.MinimumFeetTextBox.TabIndex = 4;
            // 
            // MinimumFeetLabel
            // 
            this.MinimumFeetLabel.AutoSize = true;
            this.MinimumFeetLabel.Location = new System.Drawing.Point(6, 20);
            this.MinimumFeetLabel.Name = "MinimumFeetLabel";
            this.MinimumFeetLabel.Size = new System.Drawing.Size(31, 13);
            this.MinimumFeetLabel.TabIndex = 0;
            this.MinimumFeetLabel.Text = "Feet:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MilesPerHourTextBox);
            this.groupBox4.Controls.Add(this.KilometersPerHourTextBox);
            this.groupBox4.Controls.Add(this.KilometersPerSecondTextBox);
            this.groupBox4.Controls.Add(this.MilesPerHourLabel);
            this.groupBox4.Controls.Add(this.KilometersPerHourLabel);
            this.groupBox4.Controls.Add(this.KilometersPerSecondLabel);
            this.groupBox4.Location = new System.Drawing.Point(219, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 100);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relative Velocity";
            // 
            // MilesPerHourTextBox
            // 
            this.MilesPerHourTextBox.BackColor = System.Drawing.Color.White;
            this.MilesPerHourTextBox.Location = new System.Drawing.Point(129, 71);
            this.MilesPerHourTextBox.Name = "MilesPerHourTextBox";
            this.MilesPerHourTextBox.ReadOnly = true;
            this.MilesPerHourTextBox.Size = new System.Drawing.Size(100, 20);
            this.MilesPerHourTextBox.TabIndex = 5;
            // 
            // KilometersPerHourTextBox
            // 
            this.KilometersPerHourTextBox.BackColor = System.Drawing.Color.White;
            this.KilometersPerHourTextBox.Location = new System.Drawing.Point(129, 45);
            this.KilometersPerHourTextBox.Name = "KilometersPerHourTextBox";
            this.KilometersPerHourTextBox.ReadOnly = true;
            this.KilometersPerHourTextBox.Size = new System.Drawing.Size(100, 20);
            this.KilometersPerHourTextBox.TabIndex = 4;
            // 
            // KilometersPerSecondTextBox
            // 
            this.KilometersPerSecondTextBox.BackColor = System.Drawing.Color.White;
            this.KilometersPerSecondTextBox.Location = new System.Drawing.Point(129, 19);
            this.KilometersPerSecondTextBox.Name = "KilometersPerSecondTextBox";
            this.KilometersPerSecondTextBox.ReadOnly = true;
            this.KilometersPerSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.KilometersPerSecondTextBox.TabIndex = 3;
            // 
            // MilesPerHourLabel
            // 
            this.MilesPerHourLabel.AutoSize = true;
            this.MilesPerHourLabel.Location = new System.Drawing.Point(7, 74);
            this.MilesPerHourLabel.Name = "MilesPerHourLabel";
            this.MilesPerHourLabel.Size = new System.Drawing.Size(78, 13);
            this.MilesPerHourLabel.TabIndex = 2;
            this.MilesPerHourLabel.Text = "Miles per Hour:";
            // 
            // KilometersPerHourLabel
            // 
            this.KilometersPerHourLabel.AutoSize = true;
            this.KilometersPerHourLabel.Location = new System.Drawing.Point(7, 48);
            this.KilometersPerHourLabel.Name = "KilometersPerHourLabel";
            this.KilometersPerHourLabel.Size = new System.Drawing.Size(102, 13);
            this.KilometersPerHourLabel.TabIndex = 1;
            this.KilometersPerHourLabel.Text = "Kilometers per Hour:";
            // 
            // KilometersPerSecondLabel
            // 
            this.KilometersPerSecondLabel.AutoSize = true;
            this.KilometersPerSecondLabel.Location = new System.Drawing.Point(7, 22);
            this.KilometersPerSecondLabel.Name = "KilometersPerSecondLabel";
            this.KilometersPerSecondLabel.Size = new System.Drawing.Size(116, 13);
            this.KilometersPerSecondLabel.TabIndex = 0;
            this.KilometersPerSecondLabel.Text = "Kilometers per Second:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MissDistanceLunarTextBox);
            this.groupBox5.Controls.Add(this.MissDistanceAstronomicalTextBox);
            this.groupBox5.Controls.Add(this.MissDistanceKilometersTextBox);
            this.groupBox5.Controls.Add(this.MissDistanceAstronomicalLabel);
            this.groupBox5.Controls.Add(this.MissDistanceLunarLabel);
            this.groupBox5.Controls.Add(this.MissDistanceKilometersLabel);
            this.groupBox5.Controls.Add(this.MissDistanceMilesTextBox);
            this.groupBox5.Controls.Add(this.MissDistanceMilesLabel);
            this.groupBox5.Location = new System.Drawing.Point(539, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 127);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Miss Distance";
            // 
            // MissDistanceLunarTextBox
            // 
            this.MissDistanceLunarTextBox.BackColor = System.Drawing.Color.White;
            this.MissDistanceLunarTextBox.Location = new System.Drawing.Point(85, 71);
            this.MissDistanceLunarTextBox.Name = "MissDistanceLunarTextBox";
            this.MissDistanceLunarTextBox.ReadOnly = true;
            this.MissDistanceLunarTextBox.Size = new System.Drawing.Size(112, 20);
            this.MissDistanceLunarTextBox.TabIndex = 9;
            // 
            // MissDistanceAstronomicalTextBox
            // 
            this.MissDistanceAstronomicalTextBox.BackColor = System.Drawing.Color.White;
            this.MissDistanceAstronomicalTextBox.Location = new System.Drawing.Point(85, 97);
            this.MissDistanceAstronomicalTextBox.Name = "MissDistanceAstronomicalTextBox";
            this.MissDistanceAstronomicalTextBox.ReadOnly = true;
            this.MissDistanceAstronomicalTextBox.Size = new System.Drawing.Size(112, 20);
            this.MissDistanceAstronomicalTextBox.TabIndex = 8;
            // 
            // MissDistanceKilometersTextBox
            // 
            this.MissDistanceKilometersTextBox.BackColor = System.Drawing.Color.White;
            this.MissDistanceKilometersTextBox.Location = new System.Drawing.Point(85, 45);
            this.MissDistanceKilometersTextBox.Name = "MissDistanceKilometersTextBox";
            this.MissDistanceKilometersTextBox.ReadOnly = true;
            this.MissDistanceKilometersTextBox.Size = new System.Drawing.Size(112, 20);
            this.MissDistanceKilometersTextBox.TabIndex = 6;
            // 
            // MissDistanceAstronomicalLabel
            // 
            this.MissDistanceAstronomicalLabel.AutoSize = true;
            this.MissDistanceAstronomicalLabel.Location = new System.Drawing.Point(9, 100);
            this.MissDistanceAstronomicalLabel.Name = "MissDistanceAstronomicalLabel";
            this.MissDistanceAstronomicalLabel.Size = new System.Drawing.Size(70, 13);
            this.MissDistanceAstronomicalLabel.TabIndex = 3;
            this.MissDistanceAstronomicalLabel.Text = "Astronomical:";
            // 
            // MissDistanceLunarLabel
            // 
            this.MissDistanceLunarLabel.AutoSize = true;
            this.MissDistanceLunarLabel.Location = new System.Drawing.Point(9, 74);
            this.MissDistanceLunarLabel.Name = "MissDistanceLunarLabel";
            this.MissDistanceLunarLabel.Size = new System.Drawing.Size(37, 13);
            this.MissDistanceLunarLabel.TabIndex = 2;
            this.MissDistanceLunarLabel.Text = "Lunar:";
            // 
            // MissDistanceKilometersLabel
            // 
            this.MissDistanceKilometersLabel.AutoSize = true;
            this.MissDistanceKilometersLabel.Location = new System.Drawing.Point(9, 48);
            this.MissDistanceKilometersLabel.Name = "MissDistanceKilometersLabel";
            this.MissDistanceKilometersLabel.Size = new System.Drawing.Size(58, 13);
            this.MissDistanceKilometersLabel.TabIndex = 1;
            this.MissDistanceKilometersLabel.Text = "Kilometers:";
            // 
            // MissDistanceMilesTextBox
            // 
            this.MissDistanceMilesTextBox.BackColor = System.Drawing.Color.White;
            this.MissDistanceMilesTextBox.Location = new System.Drawing.Point(85, 19);
            this.MissDistanceMilesTextBox.Name = "MissDistanceMilesTextBox";
            this.MissDistanceMilesTextBox.ReadOnly = true;
            this.MissDistanceMilesTextBox.Size = new System.Drawing.Size(112, 20);
            this.MissDistanceMilesTextBox.TabIndex = 7;
            // 
            // MissDistanceMilesLabel
            // 
            this.MissDistanceMilesLabel.AutoSize = true;
            this.MissDistanceMilesLabel.Location = new System.Drawing.Point(9, 22);
            this.MissDistanceMilesLabel.Name = "MissDistanceMilesLabel";
            this.MissDistanceMilesLabel.Size = new System.Drawing.Size(34, 13);
            this.MissDistanceMilesLabel.TabIndex = 0;
            this.MissDistanceMilesLabel.Text = "Miles:";
            // 
            // DatabaseLinkLabel
            // 
            this.DatabaseLinkLabel.AutoSize = true;
            this.DatabaseLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseLinkLabel.Location = new System.Drawing.Point(218, 420);
            this.DatabaseLinkLabel.Name = "DatabaseLinkLabel";
            this.DatabaseLinkLabel.Size = new System.Drawing.Size(147, 13);
            this.DatabaseLinkLabel.TabIndex = 0;
            this.DatabaseLinkLabel.TabStop = true;
            this.DatabaseLinkLabel.Text = "Small-Body Database Lookup";
            this.DatabaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DatabaseLinkLabel_LinkClicked);
            // 
            // ElementCountLabel
            // 
            this.ElementCountLabel.AutoSize = true;
            this.ElementCountLabel.Location = new System.Drawing.Point(12, 98);
            this.ElementCountLabel.Name = "ElementCountLabel";
            this.ElementCountLabel.Size = new System.Drawing.Size(79, 13);
            this.ElementCountLabel.TabIndex = 9;
            this.ElementCountLabel.Text = "Element Count:";
            // 
            // ElementCountTextBox
            // 
            this.ElementCountTextBox.BackColor = System.Drawing.Color.White;
            this.ElementCountTextBox.Location = new System.Drawing.Point(97, 95);
            this.ElementCountTextBox.Name = "ElementCountTextBox";
            this.ElementCountTextBox.ReadOnly = true;
            this.ElementCountTextBox.Size = new System.Drawing.Size(115, 20);
            this.ElementCountTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.ElementCountTextBox);
            this.Controls.Add(this.ElementCountLabel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.EstimatedDiameterGroupBox);
            this.Controls.Add(this.GeneralInformationGroupBox);
            this.Controls.Add(this.RetrieveDataGroupBox);
            this.Controls.Add(this.ShowInformationButton);
            this.Controls.Add(this.NeoListBox);
            this.Controls.Add(this.DatabaseLinkLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Near Earth Object Web Service GUI";
            this.RetrieveDataGroupBox.ResumeLayout(false);
            this.RetrieveDataGroupBox.PerformLayout();
            this.GeneralInformationGroupBox.ResumeLayout(false);
            this.GeneralInformationGroupBox.PerformLayout();
            this.EstimatedDiameterGroupBox.ResumeLayout(false);
            this.MaximumGroupBox.ResumeLayout(false);
            this.MaximumGroupBox.PerformLayout();
            this.MinimumGroupBox.ResumeLayout(false);
            this.MinimumGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox NeoListBox;
        private System.Windows.Forms.Button ShowInformationButton;
        private System.Windows.Forms.GroupBox RetrieveDataGroupBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.GroupBox GeneralInformationGroupBox;
        private System.Windows.Forms.LinkLabel DatabaseLinkLabel;
        private System.Windows.Forms.GroupBox EstimatedDiameterGroupBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label AbsoluteMagnitudeLabel;
        private System.Windows.Forms.Label CloseApproachDateLabel;
        private System.Windows.Forms.Label OrbitingBodyLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox AbsoluteMagnitudeTextBox;
        private System.Windows.Forms.TextBox CloseApproachDateTextBox;
        private System.Windows.Forms.TextBox OrbitingBodyTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.GroupBox MaximumGroupBox;
        private System.Windows.Forms.GroupBox MinimumGroupBox;
        private System.Windows.Forms.TextBox MinimumFeetTextBox;
        private System.Windows.Forms.Label MinimumFeetLabel;
        private System.Windows.Forms.TextBox MaximumKilometersTextBox;
        private System.Windows.Forms.Label MaximumMetersLabel;
        private System.Windows.Forms.Label MaximumKilometersLabel;
        private System.Windows.Forms.Label MaximumFeetLabel;
        private System.Windows.Forms.TextBox MaximumMilesTextBox;
        private System.Windows.Forms.TextBox MaximumFeetTextBox;
        private System.Windows.Forms.Label MaximumMilesLabel;
        private System.Windows.Forms.TextBox MaximumMetersTextBox;
        private System.Windows.Forms.TextBox MinimumKilometersTextBox;
        private System.Windows.Forms.Label MinimumKilometersLabel;
        private System.Windows.Forms.TextBox MinimumMilesTextBox;
        private System.Windows.Forms.Label MinimumMilesLabel;
        private System.Windows.Forms.TextBox MinimumMetersTextBox;
        private System.Windows.Forms.Label MinimumMetersLabel;
        private System.Windows.Forms.Label ElementCountLabel;
        private System.Windows.Forms.TextBox ElementCountTextBox;
        private System.Windows.Forms.Label MilesPerHourLabel;
        private System.Windows.Forms.Label KilometersPerHourLabel;
        private System.Windows.Forms.Label KilometersPerSecondLabel;
        private System.Windows.Forms.Label MissDistanceAstronomicalLabel;
        private System.Windows.Forms.Label MissDistanceLunarLabel;
        private System.Windows.Forms.Label MissDistanceKilometersLabel;
        private System.Windows.Forms.Label MissDistanceMilesLabel;
        private System.Windows.Forms.Label PotentiallyHazardousLabel;
        private System.Windows.Forms.Label SentryObjectLabel;
        private System.Windows.Forms.TextBox PotentiallyHazardousTextBox;
        private System.Windows.Forms.TextBox SentryObjectTextBox;
        private System.Windows.Forms.TextBox MilesPerHourTextBox;
        private System.Windows.Forms.TextBox KilometersPerHourTextBox;
        private System.Windows.Forms.TextBox KilometersPerSecondTextBox;
        private System.Windows.Forms.TextBox MissDistanceLunarTextBox;
        private System.Windows.Forms.TextBox MissDistanceAstronomicalTextBox;
        private System.Windows.Forms.TextBox MissDistanceKilometersTextBox;
        private System.Windows.Forms.TextBox MissDistanceMilesTextBox;
        private System.Windows.Forms.Button AdvancedSearchButton;
    }
}

