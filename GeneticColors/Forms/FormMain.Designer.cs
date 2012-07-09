namespace GeneticColors.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbxColors = new System.Windows.Forms.GroupBox();
            this.dgvPopulations = new System.Windows.Forms.DataGridView();
            this.clmnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnElite = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSimilarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPopulation = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.nudMutabilityMax = new System.Windows.Forms.NumericUpDown();
            this.lblMutabilityMax = new System.Windows.Forms.Label();
            this.lblComparsion = new System.Windows.Forms.Label();
            this.cbxComparsion = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.nudMutabilityMin = new System.Windows.Forms.NumericUpDown();
            this.lblMutabilityMin = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnTarget = new System.Windows.Forms.Button();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblSeed = new System.Windows.Forms.Label();
            this.nudIterations = new System.Windows.Forms.NumericUpDown();
            this.lblIterations = new System.Windows.Forms.Label();
            this.nudElitism = new System.Windows.Forms.NumericUpDown();
            this.lblElitism = new System.Windows.Forms.Label();
            this.lblMutation = new System.Windows.Forms.Label();
            this.nudMutation = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblSize = new System.Windows.Forms.Label();
            this.clrdlgTarget = new System.Windows.Forms.ColorDialog();
            this.gbxProcess = new System.Windows.Forms.GroupBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEliteValue = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnEliteColor = new System.Windows.Forms.Button();
            this.lblEliteColor = new System.Windows.Forms.Label();
            this.tbxEliteValue = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.ofdlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.sfdlgSave = new System.Windows.Forms.SaveFileDialog();
            this.sfdlgExport = new System.Windows.Forms.SaveFileDialog();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulations)).BeginInit();
            this.gbxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutabilityMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutabilityMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElitism)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.gbxProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxColors
            // 
            this.gbxColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxColors.Controls.Add(this.dgvPopulations);
            this.gbxColors.Location = new System.Drawing.Point(8, 0);
            this.gbxColors.Name = "gbxColors";
            this.gbxColors.Size = new System.Drawing.Size(400, 535);
            this.gbxColors.TabIndex = 2;
            this.gbxColors.TabStop = false;
            this.gbxColors.Text = "Populations";
            // 
            // dgvPopulations
            // 
            this.dgvPopulations.AllowUserToAddRows = false;
            this.dgvPopulations.AllowUserToDeleteRows = false;
            this.dgvPopulations.AllowUserToResizeColumns = false;
            this.dgvPopulations.AllowUserToResizeRows = false;
            this.dgvPopulations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopulations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPopulations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPopulations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnNumber,
            this.clmnElite,
            this.clmnValue,
            this.clmnDifference,
            this.clmnSimilarity,
            this.clmnPopulation});
            this.dgvPopulations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPopulations.Location = new System.Drawing.Point(8, 16);
            this.dgvPopulations.Name = "dgvPopulations";
            this.dgvPopulations.ReadOnly = true;
            this.dgvPopulations.RowHeadersVisible = false;
            this.dgvPopulations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopulations.ShowCellErrors = false;
            this.dgvPopulations.ShowCellToolTips = false;
            this.dgvPopulations.ShowEditingIcon = false;
            this.dgvPopulations.ShowRowErrors = false;
            this.dgvPopulations.Size = new System.Drawing.Size(384, 511);
            this.dgvPopulations.TabIndex = 0;
            // 
            // clmnNumber
            // 
            this.clmnNumber.HeaderText = "#";
            this.clmnNumber.Name = "clmnNumber";
            this.clmnNumber.ReadOnly = true;
            this.clmnNumber.Width = 39;
            // 
            // clmnElite
            // 
            this.clmnElite.HeaderText = "Elite color";
            this.clmnElite.Name = "clmnElite";
            this.clmnElite.ReadOnly = true;
            this.clmnElite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnElite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnElite.Width = 78;
            // 
            // clmnValue
            // 
            this.clmnValue.HeaderText = "Elite value";
            this.clmnValue.Name = "clmnValue";
            this.clmnValue.ReadOnly = true;
            this.clmnValue.Width = 81;
            // 
            // clmnDifference
            // 
            this.clmnDifference.HeaderText = "Elite difference, unit";
            this.clmnDifference.Name = "clmnDifference";
            this.clmnDifference.ReadOnly = true;
            this.clmnDifference.Width = 125;
            // 
            // clmnSimilarity
            // 
            this.clmnSimilarity.HeaderText = "Elite similarity, %";
            this.clmnSimilarity.Name = "clmnSimilarity";
            this.clmnSimilarity.ReadOnly = true;
            this.clmnSimilarity.Width = 107;
            // 
            // clmnPopulation
            // 
            this.clmnPopulation.HeaderText = "Population colors";
            this.clmnPopulation.Name = "clmnPopulation";
            this.clmnPopulation.ReadOnly = true;
            this.clmnPopulation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnPopulation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnPopulation.Width = 113;
            // 
            // gbxSettings
            // 
            this.gbxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSettings.Controls.Add(this.nudAge);
            this.gbxSettings.Controls.Add(this.lblAge);
            this.gbxSettings.Controls.Add(this.nudMutabilityMax);
            this.gbxSettings.Controls.Add(this.lblMutabilityMax);
            this.gbxSettings.Controls.Add(this.lblComparsion);
            this.gbxSettings.Controls.Add(this.cbxComparsion);
            this.gbxSettings.Controls.Add(this.lblValue);
            this.gbxSettings.Controls.Add(this.tbxValue);
            this.gbxSettings.Controls.Add(this.nudMutabilityMin);
            this.gbxSettings.Controls.Add(this.lblMutabilityMin);
            this.gbxSettings.Controls.Add(this.lblLoad);
            this.gbxSettings.Controls.Add(this.lblTarget);
            this.gbxSettings.Controls.Add(this.btnTarget);
            this.gbxSettings.Controls.Add(this.nudSeed);
            this.gbxSettings.Controls.Add(this.lblSave);
            this.gbxSettings.Controls.Add(this.lblSeed);
            this.gbxSettings.Controls.Add(this.btnLoad);
            this.gbxSettings.Controls.Add(this.btnSave);
            this.gbxSettings.Controls.Add(this.nudIterations);
            this.gbxSettings.Controls.Add(this.lblIterations);
            this.gbxSettings.Controls.Add(this.nudElitism);
            this.gbxSettings.Controls.Add(this.lblElitism);
            this.gbxSettings.Controls.Add(this.lblMutation);
            this.gbxSettings.Controls.Add(this.nudMutation);
            this.gbxSettings.Controls.Add(this.nudSize);
            this.gbxSettings.Controls.Add(this.lblSize);
            this.gbxSettings.Location = new System.Drawing.Point(416, 0);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(208, 360);
            this.gbxSettings.TabIndex = 3;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(136, 170);
            this.nudAge.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(64, 20);
            this.nudAge.TabIndex = 34;
            this.nudAge.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudAge.ValueChanged += new System.EventHandler(this.nudAge_ValueChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(8, 174);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(85, 13);
            this.lblAge.TabIndex = 33;
            this.lblAge.Text = "Sample max age";
            // 
            // nudMutabilityMax
            // 
            this.nudMutabilityMax.Location = new System.Drawing.Point(136, 96);
            this.nudMutabilityMax.Name = "nudMutabilityMax";
            this.nudMutabilityMax.Size = new System.Drawing.Size(64, 20);
            this.nudMutabilityMax.TabIndex = 32;
            this.nudMutabilityMax.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.nudMutabilityMax.ValueChanged += new System.EventHandler(this.nudMutabilityMax_ValueChanged);
            // 
            // lblMutabilityMax
            // 
            this.lblMutabilityMax.AutoSize = true;
            this.lblMutabilityMax.Location = new System.Drawing.Point(8, 100);
            this.lblMutabilityMax.Name = "lblMutabilityMax";
            this.lblMutabilityMax.Size = new System.Drawing.Size(114, 13);
            this.lblMutabilityMax.TabIndex = 31;
            this.lblMutabilityMax.Text = "Mutation max affect, %";
            // 
            // lblComparsion
            // 
            this.lblComparsion.AutoSize = true;
            this.lblComparsion.Location = new System.Drawing.Point(8, 228);
            this.lblComparsion.Name = "lblComparsion";
            this.lblComparsion.Size = new System.Drawing.Size(100, 13);
            this.lblComparsion.TabIndex = 17;
            this.lblComparsion.Text = "Comparsion method";
            // 
            // cbxComparsion
            // 
            this.cbxComparsion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComparsion.FormattingEnabled = true;
            this.cbxComparsion.Items.AddRange(new object[] {
            "Linear",
            "Square"});
            this.cbxComparsion.Location = new System.Drawing.Point(136, 224);
            this.cbxComparsion.Name = "cbxComparsion";
            this.cbxComparsion.Size = new System.Drawing.Size(64, 21);
            this.cbxComparsion.TabIndex = 16;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(8, 280);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(67, 13);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "Target value";
            // 
            // tbxValue
            // 
            this.tbxValue.Location = new System.Drawing.Point(136, 276);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.ReadOnly = true;
            this.tbxValue.Size = new System.Drawing.Size(68, 20);
            this.tbxValue.TabIndex = 14;
            this.tbxValue.Text = "100 200 100";
            this.tbxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudMutabilityMin
            // 
            this.nudMutabilityMin.Location = new System.Drawing.Point(136, 72);
            this.nudMutabilityMin.Name = "nudMutabilityMin";
            this.nudMutabilityMin.Size = new System.Drawing.Size(64, 20);
            this.nudMutabilityMin.TabIndex = 13;
            this.nudMutabilityMin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMutabilityMin.ValueChanged += new System.EventHandler(this.nudMutabilityMin_ValueChanged);
            // 
            // lblMutabilityMin
            // 
            this.lblMutabilityMin.AutoSize = true;
            this.lblMutabilityMin.Location = new System.Drawing.Point(8, 76);
            this.lblMutabilityMin.Name = "lblMutabilityMin";
            this.lblMutabilityMin.Size = new System.Drawing.Size(111, 13);
            this.lblMutabilityMin.TabIndex = 12;
            this.lblMutabilityMin.Text = "Mutation min affect, %";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(8, 333);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(75, 13);
            this.lblLoad.TabIndex = 30;
            this.lblLoad.Text = "Import settings";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(8, 253);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(64, 13);
            this.lblTarget.TabIndex = 11;
            this.lblTarget.Text = "Target color";
            // 
            // btnTarget
            // 
            this.btnTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnTarget.Location = new System.Drawing.Point(136, 248);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(67, 23);
            this.btnTarget.TabIndex = 10;
            this.btnTarget.UseVisualStyleBackColor = false;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(136, 200);
            this.nudSeed.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.nudSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(64, 20);
            this.nudSeed.TabIndex = 9;
            this.nudSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(8, 306);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(76, 13);
            this.lblSave.TabIndex = 24;
            this.lblSave.Text = "Export settings";
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(8, 204);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(104, 13);
            this.lblSeed.TabIndex = 8;
            this.lblSeed.Text = "First population seed";
            // 
            // nudIterations
            // 
            this.nudIterations.Location = new System.Drawing.Point(136, 144);
            this.nudIterations.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIterations.Name = "nudIterations";
            this.nudIterations.Size = new System.Drawing.Size(64, 20);
            this.nudIterations.TabIndex = 7;
            this.nudIterations.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nudIterations.ValueChanged += new System.EventHandler(this.nudIterations_ValueChanged);
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(8, 148);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(112, 13);
            this.lblIterations.TabIndex = 6;
            this.lblIterations.Text = "Analysis max iterations";
            // 
            // nudElitism
            // 
            this.nudElitism.Location = new System.Drawing.Point(136, 120);
            this.nudElitism.Name = "nudElitism";
            this.nudElitism.Size = new System.Drawing.Size(64, 20);
            this.nudElitism.TabIndex = 5;
            this.nudElitism.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblElitism
            // 
            this.lblElitism.AutoSize = true;
            this.lblElitism.Location = new System.Drawing.Point(8, 124);
            this.lblElitism.Name = "lblElitism";
            this.lblElitism.Size = new System.Drawing.Size(102, 13);
            this.lblElitism.TabIndex = 4;
            this.lblElitism.Text = "Population elitism, %";
            // 
            // lblMutation
            // 
            this.lblMutation.AutoSize = true;
            this.lblMutation.Location = new System.Drawing.Point(8, 52);
            this.lblMutation.Name = "lblMutation";
            this.lblMutation.Size = new System.Drawing.Size(114, 13);
            this.lblMutation.TabIndex = 3;
            this.lblMutation.Text = "Population mutation, %";
            // 
            // nudMutation
            // 
            this.nudMutation.Location = new System.Drawing.Point(136, 48);
            this.nudMutation.Name = "nudMutation";
            this.nudMutation.Size = new System.Drawing.Size(64, 20);
            this.nudMutation.TabIndex = 2;
            this.nudMutation.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(136, 24);
            this.nudSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(64, 20);
            this.nudSize.TabIndex = 1;
            this.nudSize.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(8, 28);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(78, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Population size";
            // 
            // clrdlgTarget
            // 
            this.clrdlgTarget.FullOpen = true;
            // 
            // gbxProcess
            // 
            this.gbxProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProcess.Controls.Add(this.lblExport);
            this.gbxProcess.Controls.Add(this.btnExport);
            this.gbxProcess.Controls.Add(this.lblResult);
            this.gbxProcess.Controls.Add(this.lblEliteValue);
            this.gbxProcess.Controls.Add(this.tbxResult);
            this.gbxProcess.Controls.Add(this.btnEliteColor);
            this.gbxProcess.Controls.Add(this.lblEliteColor);
            this.gbxProcess.Controls.Add(this.tbxEliteValue);
            this.gbxProcess.Controls.Add(this.lblProgress);
            this.gbxProcess.Controls.Add(this.pbProgress);
            this.gbxProcess.Controls.Add(this.lblAnalysis);
            this.gbxProcess.Controls.Add(this.btnAnalysis);
            this.gbxProcess.Location = new System.Drawing.Point(416, 360);
            this.gbxProcess.Name = "gbxProcess";
            this.gbxProcess.Size = new System.Drawing.Size(208, 176);
            this.gbxProcess.TabIndex = 4;
            this.gbxProcess.TabStop = false;
            this.gbxProcess.Text = "Control";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(8, 149);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(98, 13);
            this.lblExport.TabIndex = 38;
            this.lblExport.Text = "Populations images";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(8, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 13);
            this.lblResult.TabIndex = 36;
            this.lblResult.Text = "Analysis result";
            // 
            // lblEliteValue
            // 
            this.lblEliteValue.AutoSize = true;
            this.lblEliteValue.Location = new System.Drawing.Point(8, 101);
            this.lblEliteValue.Name = "lblEliteValue";
            this.lblEliteValue.Size = new System.Drawing.Size(56, 13);
            this.lblEliteValue.TabIndex = 35;
            this.lblEliteValue.Text = "Elite value";
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(136, 121);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(68, 20);
            this.tbxResult.TabIndex = 34;
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEliteColor
            // 
            this.btnEliteColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliteColor.Enabled = false;
            this.btnEliteColor.Location = new System.Drawing.Point(136, 70);
            this.btnEliteColor.Name = "btnEliteColor";
            this.btnEliteColor.Size = new System.Drawing.Size(67, 23);
            this.btnEliteColor.TabIndex = 33;
            this.btnEliteColor.UseVisualStyleBackColor = false;
            // 
            // lblEliteColor
            // 
            this.lblEliteColor.AutoSize = true;
            this.lblEliteColor.Location = new System.Drawing.Point(8, 76);
            this.lblEliteColor.Name = "lblEliteColor";
            this.lblEliteColor.Size = new System.Drawing.Size(53, 13);
            this.lblEliteColor.TabIndex = 32;
            this.lblEliteColor.Text = "Elite color";
            // 
            // tbxEliteValue
            // 
            this.tbxEliteValue.Location = new System.Drawing.Point(136, 97);
            this.tbxEliteValue.Name = "tbxEliteValue";
            this.tbxEliteValue.ReadOnly = true;
            this.tbxEliteValue.Size = new System.Drawing.Size(68, 20);
            this.tbxEliteValue.TabIndex = 31;
            this.tbxEliteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(8, 49);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 29;
            this.lblProgress.Text = "Progress";
            // 
            // pbProgress
            // 
            this.pbProgress.Enabled = false;
            this.pbProgress.Location = new System.Drawing.Point(136, 43);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(67, 23);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgress.TabIndex = 28;
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.AutoSize = true;
            this.lblAnalysis.Location = new System.Drawing.Point(8, 21);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(84, 13);
            this.lblAnalysis.TabIndex = 21;
            this.lblAnalysis.Text = "Genetic analysis";
            // 
            // ofdlgLoad
            // 
            this.ofdlgLoad.Filter = "Genetic colors settings (*.gcs) | *.gcs";
            this.ofdlgLoad.Title = "Load settings";
            // 
            // sfdlgSave
            // 
            this.sfdlgSave.Filter = "Genetic colors settings (*.gcs) | *.gcs";
            this.sfdlgSave.Title = "Save settings";
            // 
            // sfdlgExport
            // 
            this.sfdlgExport.Filter = "PNG images (*.png)|*.png";
            this.sfdlgExport.Title = "Export image to file";
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Image = global::GeneticColors.Properties.Resources.image;
            this.btnExport.Location = new System.Drawing.Point(136, 144);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(67, 23);
            this.btnExport.TabIndex = 37;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Image = global::GeneticColors.Properties.Resources.chart_curve;
            this.btnAnalysis.Location = new System.Drawing.Point(136, 16);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(67, 23);
            this.btnAnalysis.TabIndex = 20;
            this.btnAnalysis.Text = "Start";
            this.btnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::GeneticColors.Properties.Resources.folder;
            this.btnLoad.Location = new System.Drawing.Point(136, 328);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(67, 23);
            this.btnLoad.TabIndex = 23;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::GeneticColors.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(136, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 542);
            this.Controls.Add(this.gbxProcess);
            this.Controls.Add(this.gbxSettings);
            this.Controls.Add(this.gbxColors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(646, 580);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic colors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopulations)).EndInit();
            this.gbxSettings.ResumeLayout(false);
            this.gbxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutabilityMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutabilityMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElitism)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.gbxProcess.ResumeLayout(false);
            this.gbxProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxColors;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button btnTarget;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.NumericUpDown nudIterations;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.NumericUpDown nudElitism;
        private System.Windows.Forms.Label lblElitism;
        private System.Windows.Forms.Label lblMutation;
        private System.Windows.Forms.NumericUpDown nudMutation;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ColorDialog clrdlgTarget;
        private System.Windows.Forms.DataGridView dgvPopulations;
        private System.Windows.Forms.GroupBox gbxProcess;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.OpenFileDialog ofdlgLoad;
        private System.Windows.Forms.SaveFileDialog sfdlgSave;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.NumericUpDown nudMutabilityMin;
        private System.Windows.Forms.Label lblMutabilityMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNumber;
        private System.Windows.Forms.DataGridViewImageColumn clmnElite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSimilarity;
        private System.Windows.Forms.DataGridViewImageColumn clmnPopulation;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEliteValue;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnEliteColor;
        private System.Windows.Forms.Label lblEliteColor;
        private System.Windows.Forms.TextBox tbxEliteValue;
        private System.Windows.Forms.Label lblComparsion;
        private System.Windows.Forms.ComboBox cbxComparsion;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdlgExport;
        private System.Windows.Forms.NumericUpDown nudMutabilityMax;
        private System.Windows.Forms.Label lblMutabilityMax;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblAge;
    }
}

