namespace NAVY
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNeural = new System.Windows.Forms.TabPage();
			this.btnNeuralActivate = new System.Windows.Forms.Button();
			this.btnNeuralNeuronsNoAugment = new System.Windows.Forms.Button();
			this.btnNeuralNeuronsDefault = new System.Windows.Forms.Button();
			this.btnNeuralNeuronsRandom = new System.Windows.Forms.Button();
			this.btnNeuralSynapsesZero = new System.Windows.Forms.Button();
			this.btnNeuralSynapseRandom = new System.Windows.Forms.Button();
			this.btnNeuralLoadConfiguration = new System.Windows.Forms.Button();
			this.btnNeuralSaveConfiguration = new System.Windows.Forms.Button();
			this.barNeuralProgress = new System.Windows.Forms.ProgressBar();
			this.barNeuralMatch = new System.Windows.Forms.ProgressBar();
			this.cmbNeuralAlgorithm = new System.Windows.Forms.ComboBox();
			this.btnNeuralSchema = new System.Windows.Forms.Button();
			this.numNeuralEpoch = new System.Windows.Forms.NumericUpDown();
			this.lblNeuralEpoch = new System.Windows.Forms.Label();
			this.btnNeuralExpectedLoad = new System.Windows.Forms.Button();
			this.btnNeuralInputLoad = new System.Windows.Forms.Button();
			this.lblNeuralExpected = new System.Windows.Forms.Label();
			this.txtNeuralExpected = new System.Windows.Forms.TextBox();
			this.btnNeuralRun = new System.Windows.Forms.Button();
			this.lblNeuralOutput = new System.Windows.Forms.Label();
			this.lblNeuralInput = new System.Windows.Forms.Label();
			this.txtNeuralOutput = new System.Windows.Forms.TextBox();
			this.txtNeuralInput = new System.Windows.Forms.TextBox();
			this.gridNeuralNeurons = new System.Windows.Forms.DataGridView();
			this.columnNeuron = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnSlope = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAugment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNeuralSynapses = new System.Windows.Forms.Label();
			this.txtNeuralSynapses = new System.Windows.Forms.TextBox();
			this.btnNeuralDeleteLayer = new System.Windows.Forms.Button();
			this.btnNeuralAddLayer = new System.Windows.Forms.Button();
			this.gridNeuralLayers = new System.Windows.Forms.DataGridView();
			this.columnLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNeurons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tabHopfield = new System.Windows.Forms.TabPage();
			this.btnHopfieldNoise = new System.Windows.Forms.Button();
			this.cmbHopfieldSymbols = new System.Windows.Forms.ComboBox();
			this.pciHopfieldClassify = new System.Windows.Forms.Button();
			this.picHopfieldLearn = new System.Windows.Forms.Button();
			this.btnHopfieldRandom = new System.Windows.Forms.Button();
			this.cmbHopfieldValue = new System.Windows.Forms.ComboBox();
			this.btnHopfieldClear = new System.Windows.Forms.Button();
			this.picHopfieldInput = new System.Windows.Forms.PictureBox();
			this.tabFractals = new System.Windows.Forms.TabPage();
			this.tabControlFractals = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.numFractalsYOffset = new System.Windows.Forms.NumericUpDown();
			this.numFractalsXOffset = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numFractalsScale = new System.Windows.Forms.NumericUpDown();
			this.btnFractalsLoad = new System.Windows.Forms.Button();
			this.btnFractalsReset = new System.Windows.Forms.Button();
			this.numFractalsIterations = new System.Windows.Forms.NumericUpDown();
			this.btnFractalsDraw = new System.Windows.Forms.Button();
			this.gridFractalsParameters = new System.Windows.Forms.DataGridView();
			this.columnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFractalsSave = new System.Windows.Forms.Button();
			this.btnFractalsRandomize = new System.Windows.Forms.Button();
			this.btnFractalsAttractorDelete = new System.Windows.Forms.Button();
			this.btnFractalsAttractorAdd = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.numFractalsGOCKoef = new System.Windows.Forms.NumericUpDown();
			this.btnFractalsGOCDraw = new System.Windows.Forms.Button();
			this.numFractalsGOCCount = new System.Windows.Forms.NumericUpDown();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnFractalsTEAReset = new System.Windows.Forms.Button();
			this.picFractalsPicture = new System.Windows.Forms.PictureBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.chartLSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl.SuspendLayout();
			this.tabNeural.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralNeurons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralLayers)).BeginInit();
			this.tabHopfield.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picHopfieldInput)).BeginInit();
			this.tabFractals.SuspendLayout();
			this.tabControlFractals.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsYOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsXOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsScale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsIterations)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFractalsParameters)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsGOCKoef)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsGOCCount)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFractalsPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartLSP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabNeural);
			this.tabControl.Controls.Add(this.tabHopfield);
			this.tabControl.Controls.Add(this.tabFractals);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1310, 401);
			this.tabControl.TabIndex = 0;
			// 
			// tabNeural
			// 
			this.tabNeural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.tabNeural.Controls.Add(this.btnNeuralActivate);
			this.tabNeural.Controls.Add(this.btnNeuralNeuronsNoAugment);
			this.tabNeural.Controls.Add(this.btnNeuralNeuronsDefault);
			this.tabNeural.Controls.Add(this.btnNeuralNeuronsRandom);
			this.tabNeural.Controls.Add(this.btnNeuralSynapsesZero);
			this.tabNeural.Controls.Add(this.btnNeuralSynapseRandom);
			this.tabNeural.Controls.Add(this.btnNeuralLoadConfiguration);
			this.tabNeural.Controls.Add(this.btnNeuralSaveConfiguration);
			this.tabNeural.Controls.Add(this.barNeuralProgress);
			this.tabNeural.Controls.Add(this.barNeuralMatch);
			this.tabNeural.Controls.Add(this.cmbNeuralAlgorithm);
			this.tabNeural.Controls.Add(this.btnNeuralSchema);
			this.tabNeural.Controls.Add(this.numNeuralEpoch);
			this.tabNeural.Controls.Add(this.lblNeuralEpoch);
			this.tabNeural.Controls.Add(this.btnNeuralExpectedLoad);
			this.tabNeural.Controls.Add(this.btnNeuralInputLoad);
			this.tabNeural.Controls.Add(this.lblNeuralExpected);
			this.tabNeural.Controls.Add(this.txtNeuralExpected);
			this.tabNeural.Controls.Add(this.btnNeuralRun);
			this.tabNeural.Controls.Add(this.lblNeuralOutput);
			this.tabNeural.Controls.Add(this.lblNeuralInput);
			this.tabNeural.Controls.Add(this.txtNeuralOutput);
			this.tabNeural.Controls.Add(this.txtNeuralInput);
			this.tabNeural.Controls.Add(this.gridNeuralNeurons);
			this.tabNeural.Controls.Add(this.lblNeuralSynapses);
			this.tabNeural.Controls.Add(this.txtNeuralSynapses);
			this.tabNeural.Controls.Add(this.btnNeuralDeleteLayer);
			this.tabNeural.Controls.Add(this.btnNeuralAddLayer);
			this.tabNeural.Controls.Add(this.gridNeuralLayers);
			this.tabNeural.ForeColor = System.Drawing.Color.Silver;
			this.tabNeural.Location = new System.Drawing.Point(4, 25);
			this.tabNeural.Name = "tabNeural";
			this.tabNeural.Size = new System.Drawing.Size(1302, 372);
			this.tabNeural.TabIndex = 0;
			this.tabNeural.Text = "Neural";
			// 
			// btnNeuralActivate
			// 
			this.btnNeuralActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralActivate.Location = new System.Drawing.Point(695, 82);
			this.btnNeuralActivate.Name = "btnNeuralActivate";
			this.btnNeuralActivate.Size = new System.Drawing.Size(142, 35);
			this.btnNeuralActivate.TabIndex = 59;
			this.btnNeuralActivate.Text = "Activate";
			this.btnNeuralActivate.UseVisualStyleBackColor = true;
			this.btnNeuralActivate.Click += new System.EventHandler(this.btnNeuralActivate_Click);
			// 
			// btnNeuralNeuronsNoAugment
			// 
			this.btnNeuralNeuronsNoAugment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralNeuronsNoAugment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralNeuronsNoAugment.Location = new System.Drawing.Point(397, 334);
			this.btnNeuralNeuronsNoAugment.Name = "btnNeuralNeuronsNoAugment";
			this.btnNeuralNeuronsNoAugment.Size = new System.Drawing.Size(85, 35);
			this.btnNeuralNeuronsNoAugment.TabIndex = 58;
			this.btnNeuralNeuronsNoAugment.Text = "No Augment";
			this.btnNeuralNeuronsNoAugment.UseVisualStyleBackColor = true;
			this.btnNeuralNeuronsNoAugment.Click += new System.EventHandler(this.btnNeuralNeuronsNoAugment_Click);
			// 
			// btnNeuralNeuronsDefault
			// 
			this.btnNeuralNeuronsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralNeuronsDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralNeuronsDefault.Location = new System.Drawing.Point(339, 334);
			this.btnNeuralNeuronsDefault.Name = "btnNeuralNeuronsDefault";
			this.btnNeuralNeuronsDefault.Size = new System.Drawing.Size(52, 35);
			this.btnNeuralNeuronsDefault.TabIndex = 57;
			this.btnNeuralNeuronsDefault.Text = "Default";
			this.btnNeuralNeuronsDefault.UseVisualStyleBackColor = true;
			this.btnNeuralNeuronsDefault.Click += new System.EventHandler(this.btnNeuralNeuronsDefault_Click);
			// 
			// btnNeuralNeuronsRandom
			// 
			this.btnNeuralNeuronsRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralNeuronsRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralNeuronsRandom.Location = new System.Drawing.Point(275, 334);
			this.btnNeuralNeuronsRandom.Name = "btnNeuralNeuronsRandom";
			this.btnNeuralNeuronsRandom.Size = new System.Drawing.Size(58, 35);
			this.btnNeuralNeuronsRandom.TabIndex = 56;
			this.btnNeuralNeuronsRandom.Text = "Random";
			this.btnNeuralNeuronsRandom.UseVisualStyleBackColor = true;
			this.btnNeuralNeuronsRandom.Click += new System.EventHandler(this.btnNeuralNeuronsRandom_Click);
			// 
			// btnNeuralSynapsesZero
			// 
			this.btnNeuralSynapsesZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralSynapsesZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesZero.Location = new System.Drawing.Point(613, 334);
			this.btnNeuralSynapsesZero.Name = "btnNeuralSynapsesZero";
			this.btnNeuralSynapsesZero.Size = new System.Drawing.Size(77, 35);
			this.btnNeuralSynapsesZero.TabIndex = 55;
			this.btnNeuralSynapsesZero.Text = "Zero";
			this.btnNeuralSynapsesZero.UseVisualStyleBackColor = true;
			this.btnNeuralSynapsesZero.Click += new System.EventHandler(this.btnNeuralSynapsesZero_Click);
			// 
			// btnNeuralSynapseRandom
			// 
			this.btnNeuralSynapseRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralSynapseRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapseRandom.Location = new System.Drawing.Point(488, 334);
			this.btnNeuralSynapseRandom.Name = "btnNeuralSynapseRandom";
			this.btnNeuralSynapseRandom.Size = new System.Drawing.Size(119, 35);
			this.btnNeuralSynapseRandom.TabIndex = 54;
			this.btnNeuralSynapseRandom.Text = "Random";
			this.btnNeuralSynapseRandom.UseVisualStyleBackColor = true;
			this.btnNeuralSynapseRandom.Click += new System.EventHandler(this.btnNeuralSynapseRandom_Click);
			// 
			// btnNeuralLoadConfiguration
			// 
			this.btnNeuralLoadConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralLoadConfiguration.Location = new System.Drawing.Point(3, 6);
			this.btnNeuralLoadConfiguration.Name = "btnNeuralLoadConfiguration";
			this.btnNeuralLoadConfiguration.Size = new System.Drawing.Size(130, 35);
			this.btnNeuralLoadConfiguration.TabIndex = 53;
			this.btnNeuralLoadConfiguration.Text = "Load Config";
			this.btnNeuralLoadConfiguration.UseVisualStyleBackColor = true;
			this.btnNeuralLoadConfiguration.Click += new System.EventHandler(this.btnNeuralLoadConfiguration_Click);
			// 
			// btnNeuralSaveConfiguration
			// 
			this.btnNeuralSaveConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSaveConfiguration.Location = new System.Drawing.Point(139, 6);
			this.btnNeuralSaveConfiguration.Name = "btnNeuralSaveConfiguration";
			this.btnNeuralSaveConfiguration.Size = new System.Drawing.Size(130, 35);
			this.btnNeuralSaveConfiguration.TabIndex = 52;
			this.btnNeuralSaveConfiguration.Text = "Save Config";
			this.btnNeuralSaveConfiguration.UseVisualStyleBackColor = true;
			this.btnNeuralSaveConfiguration.Click += new System.EventHandler(this.btnNeuralSaveConfiguration_Click);
			// 
			// barNeuralProgress
			// 
			this.barNeuralProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.barNeuralProgress.Location = new System.Drawing.Point(695, 164);
			this.barNeuralProgress.Maximum = 10000;
			this.barNeuralProgress.Name = "barNeuralProgress";
			this.barNeuralProgress.Size = new System.Drawing.Size(142, 23);
			this.barNeuralProgress.TabIndex = 51;
			this.barNeuralProgress.Value = 100;
			// 
			// barNeuralMatch
			// 
			this.barNeuralMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.barNeuralMatch.Location = new System.Drawing.Point(1105, 350);
			this.barNeuralMatch.Name = "barNeuralMatch";
			this.barNeuralMatch.Size = new System.Drawing.Size(194, 19);
			this.barNeuralMatch.TabIndex = 50;
			// 
			// cmbNeuralAlgorithm
			// 
			this.cmbNeuralAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNeuralAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbNeuralAlgorithm.ForeColor = System.Drawing.Color.Silver;
			this.cmbNeuralAlgorithm.FormattingEnabled = true;
			this.cmbNeuralAlgorithm.Items.AddRange(new object[] {
            "Activate",
            "SOMA",
            "Fixed Increments",
            "Back Propagation"});
			this.cmbNeuralAlgorithm.Location = new System.Drawing.Point(695, 52);
			this.cmbNeuralAlgorithm.Name = "cmbNeuralAlgorithm";
			this.cmbNeuralAlgorithm.Size = new System.Drawing.Size(142, 24);
			this.cmbNeuralAlgorithm.TabIndex = 49;
			this.cmbNeuralAlgorithm.Text = "Back Propagation";
			// 
			// btnNeuralSchema
			// 
			this.btnNeuralSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSchema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSchema.Location = new System.Drawing.Point(695, 193);
			this.btnNeuralSchema.Name = "btnNeuralSchema";
			this.btnNeuralSchema.Size = new System.Drawing.Size(142, 35);
			this.btnNeuralSchema.TabIndex = 48;
			this.btnNeuralSchema.Text = "Schema";
			this.btnNeuralSchema.UseVisualStyleBackColor = true;
			this.btnNeuralSchema.Click += new System.EventHandler(this.btnNeuralSchema_Click);
			// 
			// numNeuralEpoch
			// 
			this.numNeuralEpoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numNeuralEpoch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.numNeuralEpoch.ForeColor = System.Drawing.Color.Silver;
			this.numNeuralEpoch.Location = new System.Drawing.Point(757, 24);
			this.numNeuralEpoch.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numNeuralEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numNeuralEpoch.Name = "numNeuralEpoch";
			this.numNeuralEpoch.Size = new System.Drawing.Size(80, 22);
			this.numNeuralEpoch.TabIndex = 47;
			this.numNeuralEpoch.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lblNeuralEpoch
			// 
			this.lblNeuralEpoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralEpoch.AutoSize = true;
			this.lblNeuralEpoch.Location = new System.Drawing.Point(696, 26);
			this.lblNeuralEpoch.Name = "lblNeuralEpoch";
			this.lblNeuralEpoch.Size = new System.Drawing.Size(55, 17);
			this.lblNeuralEpoch.TabIndex = 46;
			this.lblNeuralEpoch.Text = "Epochs";
			// 
			// btnNeuralExpectedLoad
			// 
			this.btnNeuralExpectedLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralExpectedLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralExpectedLoad.Location = new System.Drawing.Point(969, 334);
			this.btnNeuralExpectedLoad.Name = "btnNeuralExpectedLoad";
			this.btnNeuralExpectedLoad.Size = new System.Drawing.Size(130, 35);
			this.btnNeuralExpectedLoad.TabIndex = 44;
			this.btnNeuralExpectedLoad.Text = "Load";
			this.btnNeuralExpectedLoad.UseVisualStyleBackColor = true;
			this.btnNeuralExpectedLoad.Click += new System.EventHandler(this.btnNeuralExpectedLoad_Click);
			// 
			// btnNeuralInputLoad
			// 
			this.btnNeuralInputLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralInputLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralInputLoad.Location = new System.Drawing.Point(843, 334);
			this.btnNeuralInputLoad.Name = "btnNeuralInputLoad";
			this.btnNeuralInputLoad.Size = new System.Drawing.Size(120, 35);
			this.btnNeuralInputLoad.TabIndex = 43;
			this.btnNeuralInputLoad.Text = "Load";
			this.btnNeuralInputLoad.UseVisualStyleBackColor = true;
			this.btnNeuralInputLoad.Click += new System.EventHandler(this.btnNeuralInputLoad_Click);
			// 
			// lblNeuralExpected
			// 
			this.lblNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralExpected.AutoSize = true;
			this.lblNeuralExpected.Location = new System.Drawing.Point(966, 6);
			this.lblNeuralExpected.Name = "lblNeuralExpected";
			this.lblNeuralExpected.Size = new System.Drawing.Size(66, 17);
			this.lblNeuralExpected.TabIndex = 42;
			this.lblNeuralExpected.Text = "Expected";
			// 
			// txtNeuralExpected
			// 
			this.txtNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralExpected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralExpected.Font = new System.Drawing.Font("Courier New", 9F);
			this.txtNeuralExpected.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralExpected.Location = new System.Drawing.Point(969, 26);
			this.txtNeuralExpected.Multiline = true;
			this.txtNeuralExpected.Name = "txtNeuralExpected";
			this.txtNeuralExpected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralExpected.Size = new System.Drawing.Size(130, 302);
			this.txtNeuralExpected.TabIndex = 41;
			this.txtNeuralExpected.Text = "1\r\n0\r\n1\r\n1";
			this.txtNeuralExpected.WordWrap = false;
			// 
			// btnNeuralRun
			// 
			this.btnNeuralRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralRun.Location = new System.Drawing.Point(695, 123);
			this.btnNeuralRun.Name = "btnNeuralRun";
			this.btnNeuralRun.Size = new System.Drawing.Size(142, 35);
			this.btnNeuralRun.TabIndex = 40;
			this.btnNeuralRun.Text = "Activate + Adapt";
			this.btnNeuralRun.UseVisualStyleBackColor = true;
			this.btnNeuralRun.Click += new System.EventHandler(this.btnNeuralRun_Click);
			// 
			// lblNeuralOutput
			// 
			this.lblNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralOutput.AutoSize = true;
			this.lblNeuralOutput.Location = new System.Drawing.Point(1102, 6);
			this.lblNeuralOutput.Name = "lblNeuralOutput";
			this.lblNeuralOutput.Size = new System.Drawing.Size(51, 17);
			this.lblNeuralOutput.TabIndex = 39;
			this.lblNeuralOutput.Text = "Output";
			// 
			// lblNeuralInput
			// 
			this.lblNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralInput.AutoSize = true;
			this.lblNeuralInput.Location = new System.Drawing.Point(840, 6);
			this.lblNeuralInput.Name = "lblNeuralInput";
			this.lblNeuralInput.Size = new System.Drawing.Size(39, 17);
			this.lblNeuralInput.TabIndex = 38;
			this.lblNeuralInput.Text = "Input";
			// 
			// txtNeuralOutput
			// 
			this.txtNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralOutput.Font = new System.Drawing.Font("Courier New", 9F);
			this.txtNeuralOutput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralOutput.Location = new System.Drawing.Point(1105, 26);
			this.txtNeuralOutput.Multiline = true;
			this.txtNeuralOutput.Name = "txtNeuralOutput";
			this.txtNeuralOutput.ReadOnly = true;
			this.txtNeuralOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralOutput.Size = new System.Drawing.Size(194, 318);
			this.txtNeuralOutput.TabIndex = 37;
			this.txtNeuralOutput.WordWrap = false;
			// 
			// txtNeuralInput
			// 
			this.txtNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralInput.Font = new System.Drawing.Font("Courier New", 9F);
			this.txtNeuralInput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralInput.Location = new System.Drawing.Point(843, 26);
			this.txtNeuralInput.Multiline = true;
			this.txtNeuralInput.Name = "txtNeuralInput";
			this.txtNeuralInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralInput.Size = new System.Drawing.Size(120, 302);
			this.txtNeuralInput.TabIndex = 36;
			this.txtNeuralInput.Text = "0;0\r\n0;1\r\n1;0\r\n1;1\r\n\r\n";
			this.txtNeuralInput.WordWrap = false;
			// 
			// gridNeuralNeurons
			// 
			this.gridNeuralNeurons.AllowDrop = true;
			this.gridNeuralNeurons.AllowUserToAddRows = false;
			this.gridNeuralNeurons.AllowUserToDeleteRows = false;
			this.gridNeuralNeurons.AllowUserToOrderColumns = true;
			this.gridNeuralNeurons.AllowUserToResizeRows = false;
			this.gridNeuralNeurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridNeuralNeurons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridNeuralNeurons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridNeuralNeurons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridNeuralNeurons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNeuron,
            this.columnSlope,
            this.columnAugment});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridNeuralNeurons.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridNeuralNeurons.Location = new System.Drawing.Point(275, 3);
			this.gridNeuralNeurons.Name = "gridNeuralNeurons";
			this.gridNeuralNeurons.RowTemplate.Height = 24;
			this.gridNeuralNeurons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNeuralNeurons.ShowEditingIcon = false;
			this.gridNeuralNeurons.Size = new System.Drawing.Size(207, 325);
			this.gridNeuralNeurons.TabIndex = 33;
			// 
			// columnNeuron
			// 
			this.columnNeuron.HeaderText = "Neuron";
			this.columnNeuron.MinimumWidth = 50;
			this.columnNeuron.Name = "columnNeuron";
			this.columnNeuron.ReadOnly = true;
			this.columnNeuron.Width = 50;
			// 
			// columnSlope
			// 
			this.columnSlope.HeaderText = "Slope";
			this.columnSlope.MinimumWidth = 40;
			this.columnSlope.Name = "columnSlope";
			this.columnSlope.Width = 40;
			// 
			// columnAugment
			// 
			this.columnAugment.HeaderText = "Augment";
			this.columnAugment.MinimumWidth = 55;
			this.columnAugment.Name = "columnAugment";
			this.columnAugment.Width = 55;
			// 
			// lblNeuralSynapses
			// 
			this.lblNeuralSynapses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralSynapses.AutoSize = true;
			this.lblNeuralSynapses.Location = new System.Drawing.Point(488, 6);
			this.lblNeuralSynapses.Name = "lblNeuralSynapses";
			this.lblNeuralSynapses.Size = new System.Drawing.Size(70, 17);
			this.lblNeuralSynapses.TabIndex = 22;
			this.lblNeuralSynapses.Text = "Synapses";
			// 
			// txtNeuralSynapses
			// 
			this.txtNeuralSynapses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralSynapses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralSynapses.Font = new System.Drawing.Font("Courier New", 9F);
			this.txtNeuralSynapses.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralSynapses.Location = new System.Drawing.Point(488, 26);
			this.txtNeuralSynapses.Multiline = true;
			this.txtNeuralSynapses.Name = "txtNeuralSynapses";
			this.txtNeuralSynapses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralSynapses.Size = new System.Drawing.Size(202, 302);
			this.txtNeuralSynapses.TabIndex = 21;
			this.txtNeuralSynapses.WordWrap = false;
			// 
			// btnNeuralDeleteLayer
			// 
			this.btnNeuralDeleteLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralDeleteLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralDeleteLayer.Location = new System.Drawing.Point(139, 334);
			this.btnNeuralDeleteLayer.Name = "btnNeuralDeleteLayer";
			this.btnNeuralDeleteLayer.Size = new System.Drawing.Size(130, 35);
			this.btnNeuralDeleteLayer.TabIndex = 16;
			this.btnNeuralDeleteLayer.Text = "Delete Layer";
			this.btnNeuralDeleteLayer.UseVisualStyleBackColor = true;
			this.btnNeuralDeleteLayer.Click += new System.EventHandler(this.btnNeuralDeleteLayer_Click);
			// 
			// btnNeuralAddLayer
			// 
			this.btnNeuralAddLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralAddLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralAddLayer.Location = new System.Drawing.Point(3, 334);
			this.btnNeuralAddLayer.Name = "btnNeuralAddLayer";
			this.btnNeuralAddLayer.Size = new System.Drawing.Size(130, 35);
			this.btnNeuralAddLayer.TabIndex = 11;
			this.btnNeuralAddLayer.Text = "Add Layer";
			this.btnNeuralAddLayer.UseVisualStyleBackColor = true;
			this.btnNeuralAddLayer.Click += new System.EventHandler(this.btnNeuralAddLayer_Click);
			// 
			// gridNeuralLayers
			// 
			this.gridNeuralLayers.AllowUserToAddRows = false;
			this.gridNeuralLayers.AllowUserToDeleteRows = false;
			this.gridNeuralLayers.AllowUserToOrderColumns = true;
			this.gridNeuralLayers.AllowUserToResizeRows = false;
			this.gridNeuralLayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gridNeuralLayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridNeuralLayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridNeuralLayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridNeuralLayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLayer,
            this.columnNeurons,
            this.columnFunction});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridNeuralLayers.DefaultCellStyle = dataGridViewCellStyle4;
			this.gridNeuralLayers.Location = new System.Drawing.Point(3, 47);
			this.gridNeuralLayers.Name = "gridNeuralLayers";
			this.gridNeuralLayers.RowTemplate.Height = 24;
			this.gridNeuralLayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNeuralLayers.ShowEditingIcon = false;
			this.gridNeuralLayers.Size = new System.Drawing.Size(266, 281);
			this.gridNeuralLayers.TabIndex = 10;
			this.gridNeuralLayers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridNeural_RowsAdded);
			// 
			// columnLayer
			// 
			this.columnLayer.HeaderText = "Layer";
			this.columnLayer.MinimumWidth = 45;
			this.columnLayer.Name = "columnLayer";
			this.columnLayer.ReadOnly = true;
			this.columnLayer.Width = 45;
			// 
			// columnNeurons
			// 
			this.columnNeurons.HeaderText = "Neurons";
			this.columnNeurons.MinimumWidth = 55;
			this.columnNeurons.Name = "columnNeurons";
			this.columnNeurons.Width = 55;
			// 
			// columnFunction
			// 
			this.columnFunction.HeaderText = "Transfer";
			this.columnFunction.MinimumWidth = 120;
			this.columnFunction.Name = "columnFunction";
			this.columnFunction.Width = 120;
			// 
			// tabHopfield
			// 
			this.tabHopfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.tabHopfield.Controls.Add(this.btnHopfieldNoise);
			this.tabHopfield.Controls.Add(this.cmbHopfieldSymbols);
			this.tabHopfield.Controls.Add(this.pciHopfieldClassify);
			this.tabHopfield.Controls.Add(this.picHopfieldLearn);
			this.tabHopfield.Controls.Add(this.btnHopfieldRandom);
			this.tabHopfield.Controls.Add(this.cmbHopfieldValue);
			this.tabHopfield.Controls.Add(this.btnHopfieldClear);
			this.tabHopfield.Controls.Add(this.picHopfieldInput);
			this.tabHopfield.Location = new System.Drawing.Point(4, 25);
			this.tabHopfield.Name = "tabHopfield";
			this.tabHopfield.Size = new System.Drawing.Size(1302, 372);
			this.tabHopfield.TabIndex = 1;
			this.tabHopfield.Text = "Hopfield";
			// 
			// btnHopfieldNoise
			// 
			this.btnHopfieldNoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHopfieldNoise.ForeColor = System.Drawing.Color.White;
			this.btnHopfieldNoise.Location = new System.Drawing.Point(117, 14);
			this.btnHopfieldNoise.Name = "btnHopfieldNoise";
			this.btnHopfieldNoise.Size = new System.Drawing.Size(49, 23);
			this.btnHopfieldNoise.TabIndex = 10;
			this.btnHopfieldNoise.Text = "Noise";
			this.btnHopfieldNoise.UseVisualStyleBackColor = true;
			this.btnHopfieldNoise.Click += new System.EventHandler(this.btnHopfieldNoise_Click);
			// 
			// cmbHopfieldSymbols
			// 
			this.cmbHopfieldSymbols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbHopfieldSymbols.ForeColor = System.Drawing.Color.White;
			this.cmbHopfieldSymbols.FormattingEnabled = true;
			this.cmbHopfieldSymbols.Location = new System.Drawing.Point(96, 43);
			this.cmbHopfieldSymbols.Name = "cmbHopfieldSymbols";
			this.cmbHopfieldSymbols.Size = new System.Drawing.Size(70, 24);
			this.cmbHopfieldSymbols.TabIndex = 9;
			this.cmbHopfieldSymbols.Text = "1";
			this.cmbHopfieldSymbols.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// pciHopfieldClassify
			// 
			this.pciHopfieldClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.pciHopfieldClassify.ForeColor = System.Drawing.Color.White;
			this.pciHopfieldClassify.Location = new System.Drawing.Point(15, 290);
			this.pciHopfieldClassify.Name = "pciHopfieldClassify";
			this.pciHopfieldClassify.Size = new System.Drawing.Size(151, 23);
			this.pciHopfieldClassify.TabIndex = 8;
			this.pciHopfieldClassify.Text = "Classify";
			this.pciHopfieldClassify.UseVisualStyleBackColor = true;
			this.pciHopfieldClassify.Click += new System.EventHandler(this.pciHopfieldClassify_Click);
			// 
			// picHopfieldLearn
			// 
			this.picHopfieldLearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.picHopfieldLearn.ForeColor = System.Drawing.Color.White;
			this.picHopfieldLearn.Location = new System.Drawing.Point(15, 319);
			this.picHopfieldLearn.Name = "picHopfieldLearn";
			this.picHopfieldLearn.Size = new System.Drawing.Size(151, 23);
			this.picHopfieldLearn.TabIndex = 7;
			this.picHopfieldLearn.Text = "Train";
			this.picHopfieldLearn.UseVisualStyleBackColor = true;
			this.picHopfieldLearn.Click += new System.EventHandler(this.picHopfieldLearn_Click);
			// 
			// btnHopfieldRandom
			// 
			this.btnHopfieldRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHopfieldRandom.ForeColor = System.Drawing.Color.White;
			this.btnHopfieldRandom.Location = new System.Drawing.Point(68, 14);
			this.btnHopfieldRandom.Name = "btnHopfieldRandom";
			this.btnHopfieldRandom.Size = new System.Drawing.Size(43, 23);
			this.btnHopfieldRandom.TabIndex = 6;
			this.btnHopfieldRandom.Text = "BW";
			this.btnHopfieldRandom.UseVisualStyleBackColor = true;
			this.btnHopfieldRandom.Click += new System.EventHandler(this.btnHopfieldRandom_Click);
			// 
			// cmbHopfieldValue
			// 
			this.cmbHopfieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbHopfieldValue.ForeColor = System.Drawing.Color.White;
			this.cmbHopfieldValue.FormattingEnabled = true;
			this.cmbHopfieldValue.Items.AddRange(new object[] {
            "0",
            "0.25",
            "0.5",
            "0.75",
            "1"});
			this.cmbHopfieldValue.Location = new System.Drawing.Point(15, 43);
			this.cmbHopfieldValue.Name = "cmbHopfieldValue";
			this.cmbHopfieldValue.Size = new System.Drawing.Size(70, 24);
			this.cmbHopfieldValue.TabIndex = 4;
			this.cmbHopfieldValue.Text = "1";
			// 
			// btnHopfieldClear
			// 
			this.btnHopfieldClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHopfieldClear.ForeColor = System.Drawing.Color.White;
			this.btnHopfieldClear.Location = new System.Drawing.Point(15, 14);
			this.btnHopfieldClear.Name = "btnHopfieldClear";
			this.btnHopfieldClear.Size = new System.Drawing.Size(47, 23);
			this.btnHopfieldClear.TabIndex = 1;
			this.btnHopfieldClear.Text = "Clear";
			this.btnHopfieldClear.UseVisualStyleBackColor = true;
			this.btnHopfieldClear.Click += new System.EventHandler(this.btnHopfieldClear_Click);
			// 
			// picHopfieldInput
			// 
			this.picHopfieldInput.Location = new System.Drawing.Point(15, 73);
			this.picHopfieldInput.Name = "picHopfieldInput";
			this.picHopfieldInput.Size = new System.Drawing.Size(151, 211);
			this.picHopfieldInput.TabIndex = 0;
			this.picHopfieldInput.TabStop = false;
			this.picHopfieldInput.Click += new System.EventHandler(this.picHopfieldInput_Click);
			// 
			// tabFractals
			// 
			this.tabFractals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.tabFractals.Controls.Add(this.tabControlFractals);
			this.tabFractals.Controls.Add(this.picFractalsPicture);
			this.tabFractals.ForeColor = System.Drawing.Color.White;
			this.tabFractals.Location = new System.Drawing.Point(4, 25);
			this.tabFractals.Name = "tabFractals";
			this.tabFractals.Size = new System.Drawing.Size(1302, 372);
			this.tabFractals.TabIndex = 2;
			this.tabFractals.Text = "Fractals";
			// 
			// tabControlFractals
			// 
			this.tabControlFractals.Controls.Add(this.tabPage1);
			this.tabControlFractals.Controls.Add(this.tabPage2);
			this.tabControlFractals.Controls.Add(this.tabPage3);
			this.tabControlFractals.Location = new System.Drawing.Point(375, 5);
			this.tabControlFractals.Name = "tabControlFractals";
			this.tabControlFractals.SelectedIndex = 0;
			this.tabControlFractals.Size = new System.Drawing.Size(468, 364);
			this.tabControlFractals.TabIndex = 43;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.tabPage1.Controls.Add(this.numFractalsYOffset);
			this.tabPage1.Controls.Add(this.numFractalsXOffset);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.numFractalsScale);
			this.tabPage1.Controls.Add(this.btnFractalsLoad);
			this.tabPage1.Controls.Add(this.btnFractalsReset);
			this.tabPage1.Controls.Add(this.numFractalsIterations);
			this.tabPage1.Controls.Add(this.btnFractalsDraw);
			this.tabPage1.Controls.Add(this.gridFractalsParameters);
			this.tabPage1.Controls.Add(this.btnFractalsSave);
			this.tabPage1.Controls.Add(this.btnFractalsRandomize);
			this.tabPage1.Controls.Add(this.btnFractalsAttractorDelete);
			this.tabPage1.Controls.Add(this.btnFractalsAttractorAdd);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(460, 335);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "IFS";
			// 
			// numFractalsYOffset
			// 
			this.numFractalsYOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsYOffset.ForeColor = System.Drawing.Color.White;
			this.numFractalsYOffset.Location = new System.Drawing.Point(381, 279);
			this.numFractalsYOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numFractalsYOffset.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numFractalsYOffset.Name = "numFractalsYOffset";
			this.numFractalsYOffset.Size = new System.Drawing.Size(75, 22);
			this.numFractalsYOffset.TabIndex = 57;
			this.numFractalsYOffset.Value = new decimal(new int[] {
            230,
            0,
            0,
            0});
			// 
			// numFractalsXOffset
			// 
			this.numFractalsXOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsXOffset.ForeColor = System.Drawing.Color.White;
			this.numFractalsXOffset.Location = new System.Drawing.Point(233, 279);
			this.numFractalsXOffset.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numFractalsXOffset.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
			this.numFractalsXOffset.Name = "numFractalsXOffset";
			this.numFractalsXOffset.Size = new System.Drawing.Size(75, 22);
			this.numFractalsXOffset.TabIndex = 56;
			this.numFractalsXOffset.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(314, 281);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 55;
			this.label4.Text = "Y-offset:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(167, 281);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 17);
			this.label3.TabIndex = 54;
			this.label3.Text = "X-offset:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 281);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 53;
			this.label2.Text = "Scale:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 17);
			this.label1.TabIndex = 52;
			this.label1.Text = "Iterations:";
			// 
			// numFractalsScale
			// 
			this.numFractalsScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsScale.DecimalPlaces = 2;
			this.numFractalsScale.ForeColor = System.Drawing.Color.White;
			this.numFractalsScale.Location = new System.Drawing.Point(59, 279);
			this.numFractalsScale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numFractalsScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numFractalsScale.Name = "numFractalsScale";
			this.numFractalsScale.Size = new System.Drawing.Size(75, 22);
			this.numFractalsScale.TabIndex = 51;
			this.numFractalsScale.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// btnFractalsLoad
			// 
			this.btnFractalsLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsLoad.Location = new System.Drawing.Point(6, 6);
			this.btnFractalsLoad.Name = "btnFractalsLoad";
			this.btnFractalsLoad.Size = new System.Drawing.Size(126, 22);
			this.btnFractalsLoad.TabIndex = 50;
			this.btnFractalsLoad.Text = "Load";
			this.btnFractalsLoad.UseVisualStyleBackColor = true;
			this.btnFractalsLoad.Click += new System.EventHandler(this.btnFractalsLoad_Click);
			// 
			// btnFractalsReset
			// 
			this.btnFractalsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsReset.Location = new System.Drawing.Point(380, 6);
			this.btnFractalsReset.Name = "btnFractalsReset";
			this.btnFractalsReset.Size = new System.Drawing.Size(74, 22);
			this.btnFractalsReset.TabIndex = 49;
			this.btnFractalsReset.Text = "Reset";
			this.btnFractalsReset.UseVisualStyleBackColor = true;
			this.btnFractalsReset.Click += new System.EventHandler(this.btnFractalsReset_Click);
			// 
			// numFractalsIterations
			// 
			this.numFractalsIterations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsIterations.ForeColor = System.Drawing.Color.White;
			this.numFractalsIterations.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numFractalsIterations.Location = new System.Drawing.Point(214, 6);
			this.numFractalsIterations.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
			this.numFractalsIterations.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numFractalsIterations.Name = "numFractalsIterations";
			this.numFractalsIterations.Size = new System.Drawing.Size(67, 22);
			this.numFractalsIterations.TabIndex = 48;
			this.numFractalsIterations.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
			// 
			// btnFractalsDraw
			// 
			this.btnFractalsDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsDraw.Location = new System.Drawing.Point(367, 307);
			this.btnFractalsDraw.Name = "btnFractalsDraw";
			this.btnFractalsDraw.Size = new System.Drawing.Size(87, 22);
			this.btnFractalsDraw.TabIndex = 47;
			this.btnFractalsDraw.Text = "Draw";
			this.btnFractalsDraw.UseVisualStyleBackColor = true;
			this.btnFractalsDraw.Click += new System.EventHandler(this.btnFractalsDraw_Click);
			// 
			// gridFractalsParameters
			// 
			this.gridFractalsParameters.AllowDrop = true;
			this.gridFractalsParameters.AllowUserToAddRows = false;
			this.gridFractalsParameters.AllowUserToDeleteRows = false;
			this.gridFractalsParameters.AllowUserToOrderColumns = true;
			this.gridFractalsParameters.AllowUserToResizeRows = false;
			this.gridFractalsParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridFractalsParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridFractalsParameters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridFractalsParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridFractalsParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridFractalsParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnA,
            this.columnB,
            this.columnC,
            this.columnD,
            this.columnE,
            this.columnF,
            this.columnProbability});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridFractalsParameters.DefaultCellStyle = dataGridViewCellStyle6;
			this.gridFractalsParameters.Location = new System.Drawing.Point(5, 33);
			this.gridFractalsParameters.Name = "gridFractalsParameters";
			this.gridFractalsParameters.RowTemplate.Height = 24;
			this.gridFractalsParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridFractalsParameters.ShowEditingIcon = false;
			this.gridFractalsParameters.Size = new System.Drawing.Size(449, 240);
			this.gridFractalsParameters.TabIndex = 46;
			// 
			// columnA
			// 
			this.columnA.HeaderText = "A";
			this.columnA.Name = "columnA";
			// 
			// columnB
			// 
			this.columnB.HeaderText = "B";
			this.columnB.Name = "columnB";
			// 
			// columnC
			// 
			this.columnC.HeaderText = "C";
			this.columnC.Name = "columnC";
			// 
			// columnD
			// 
			this.columnD.HeaderText = "D";
			this.columnD.Name = "columnD";
			// 
			// columnE
			// 
			this.columnE.HeaderText = "E";
			this.columnE.Name = "columnE";
			// 
			// columnF
			// 
			this.columnF.HeaderText = "F";
			this.columnF.Name = "columnF";
			// 
			// columnProbability
			// 
			this.columnProbability.HeaderText = "Probability";
			this.columnProbability.Name = "columnProbability";
			// 
			// btnFractalsSave
			// 
			this.btnFractalsSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsSave.Location = new System.Drawing.Point(286, 6);
			this.btnFractalsSave.Name = "btnFractalsSave";
			this.btnFractalsSave.Size = new System.Drawing.Size(88, 22);
			this.btnFractalsSave.TabIndex = 45;
			this.btnFractalsSave.Text = "Save";
			this.btnFractalsSave.UseVisualStyleBackColor = true;
			this.btnFractalsSave.Click += new System.EventHandler(this.btnFractalsSave_Click);
			// 
			// btnFractalsRandomize
			// 
			this.btnFractalsRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsRandomize.Location = new System.Drawing.Point(249, 307);
			this.btnFractalsRandomize.Name = "btnFractalsRandomize";
			this.btnFractalsRandomize.Size = new System.Drawing.Size(112, 22);
			this.btnFractalsRandomize.TabIndex = 44;
			this.btnFractalsRandomize.Text = "Randomize";
			this.btnFractalsRandomize.UseVisualStyleBackColor = true;
			this.btnFractalsRandomize.Click += new System.EventHandler(this.btnFractalsRandomize_Click);
			// 
			// btnFractalsAttractorDelete
			// 
			this.btnFractalsAttractorDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsAttractorDelete.Location = new System.Drawing.Point(122, 307);
			this.btnFractalsAttractorDelete.Name = "btnFractalsAttractorDelete";
			this.btnFractalsAttractorDelete.Size = new System.Drawing.Size(121, 22);
			this.btnFractalsAttractorDelete.TabIndex = 43;
			this.btnFractalsAttractorDelete.Text = "Delete Attractor";
			this.btnFractalsAttractorDelete.UseVisualStyleBackColor = true;
			this.btnFractalsAttractorDelete.Click += new System.EventHandler(this.btnFractalsAttractorDelete_Click);
			// 
			// btnFractalsAttractorAdd
			// 
			this.btnFractalsAttractorAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsAttractorAdd.Location = new System.Drawing.Point(6, 307);
			this.btnFractalsAttractorAdd.Name = "btnFractalsAttractorAdd";
			this.btnFractalsAttractorAdd.Size = new System.Drawing.Size(110, 22);
			this.btnFractalsAttractorAdd.TabIndex = 42;
			this.btnFractalsAttractorAdd.Text = "Add Attractor";
			this.btnFractalsAttractorAdd.UseVisualStyleBackColor = true;
			this.btnFractalsAttractorAdd.Click += new System.EventHandler(this.btnFractalsAttractorAdd_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.tabPage2.Controls.Add(this.numFractalsGOCKoef);
			this.tabPage2.Controls.Add(this.btnFractalsGOCDraw);
			this.tabPage2.Controls.Add(this.numFractalsGOCCount);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(460, 335);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "GOC";
			// 
			// numFractalsGOCKoef
			// 
			this.numFractalsGOCKoef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsGOCKoef.DecimalPlaces = 2;
			this.numFractalsGOCKoef.ForeColor = System.Drawing.Color.White;
			this.numFractalsGOCKoef.Location = new System.Drawing.Point(67, 6);
			this.numFractalsGOCKoef.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
			this.numFractalsGOCKoef.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numFractalsGOCKoef.Name = "numFractalsGOCKoef";
			this.numFractalsGOCKoef.Size = new System.Drawing.Size(55, 22);
			this.numFractalsGOCKoef.TabIndex = 53;
			this.numFractalsGOCKoef.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			// 
			// btnFractalsGOCDraw
			// 
			this.btnFractalsGOCDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsGOCDraw.Location = new System.Drawing.Point(6, 33);
			this.btnFractalsGOCDraw.Name = "btnFractalsGOCDraw";
			this.btnFractalsGOCDraw.Size = new System.Drawing.Size(116, 22);
			this.btnFractalsGOCDraw.TabIndex = 52;
			this.btnFractalsGOCDraw.Text = "Draw";
			this.btnFractalsGOCDraw.UseVisualStyleBackColor = true;
			this.btnFractalsGOCDraw.Click += new System.EventHandler(this.btnFractalsGOCDraw_Click);
			// 
			// numFractalsGOCCount
			// 
			this.numFractalsGOCCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.numFractalsGOCCount.ForeColor = System.Drawing.Color.White;
			this.numFractalsGOCCount.Location = new System.Drawing.Point(6, 6);
			this.numFractalsGOCCount.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
			this.numFractalsGOCCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numFractalsGOCCount.Name = "numFractalsGOCCount";
			this.numFractalsGOCCount.Size = new System.Drawing.Size(55, 22);
			this.numFractalsGOCCount.TabIndex = 51;
			this.numFractalsGOCCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.tabPage3.Controls.Add(this.btnFractalsTEAReset);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(460, 335);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "TEA";
			// 
			// btnFractalsTEAReset
			// 
			this.btnFractalsTEAReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFractalsTEAReset.Location = new System.Drawing.Point(6, 6);
			this.btnFractalsTEAReset.Name = "btnFractalsTEAReset";
			this.btnFractalsTEAReset.Size = new System.Drawing.Size(116, 22);
			this.btnFractalsTEAReset.TabIndex = 53;
			this.btnFractalsTEAReset.Text = "Draw";
			this.btnFractalsTEAReset.UseVisualStyleBackColor = true;
			this.btnFractalsTEAReset.Click += new System.EventHandler(this.btnFractalsTEAReset_Click);
			// 
			// picFractalsPicture
			// 
			this.picFractalsPicture.Location = new System.Drawing.Point(3, 3);
			this.picFractalsPicture.Name = "picFractalsPicture";
			this.picFractalsPicture.Size = new System.Drawing.Size(366, 366);
			this.picFractalsPicture.TabIndex = 0;
			this.picFractalsPicture.TabStop = false;
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtLog.ForeColor = System.Drawing.Color.Silver;
			this.txtLog.Location = new System.Drawing.Point(12, 419);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(362, 259);
			this.txtLog.TabIndex = 1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// chartLSP
			// 
			this.chartLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.chartLSP.BackColor = System.Drawing.Color.Black;
			chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			customLabel1.ForeColor = System.Drawing.Color.Lime;
			chartArea1.AxisY2.CustomLabels.Add(customLabel1);
			chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.Name = "ChartArea1";
			this.chartLSP.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Black;
			legend1.ForeColor = System.Drawing.Color.Silver;
			legend1.Name = "Legend1";
			this.chartLSP.Legends.Add(legend1);
			this.chartLSP.Location = new System.Drawing.Point(928, 419);
			this.chartLSP.Name = "chartLSP";
			series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			series1.ChartArea = "ChartArea1";
			series1.Color = System.Drawing.Color.Lime;
			series1.LabelBackColor = System.Drawing.Color.Green;
			series1.LabelForeColor = System.Drawing.Color.Maroon;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartLSP.Series.Add(series1);
			this.chartLSP.Size = new System.Drawing.Size(394, 259);
			this.chartLSP.TabIndex = 3;
			this.chartLSP.Text = "chart";
			// 
			// chartStatus
			// 
			this.chartStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chartStatus.BackColor = System.Drawing.Color.Black;
			chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			customLabel2.ForeColor = System.Drawing.Color.Lime;
			chartArea2.AxisY2.CustomLabels.Add(customLabel2);
			chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea2.Name = "ChartArea1";
			this.chartStatus.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Black;
			legend2.ForeColor = System.Drawing.Color.Silver;
			legend2.Name = "Legend1";
			this.chartStatus.Legends.Add(legend2);
			this.chartStatus.Location = new System.Drawing.Point(380, 419);
			this.chartStatus.Name = "chartStatus";
			series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			series2.ChartArea = "ChartArea1";
			series2.Color = System.Drawing.Color.Lime;
			series2.LabelBackColor = System.Drawing.Color.Green;
			series2.LabelForeColor = System.Drawing.Color.Maroon;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartStatus.Series.Add(series2);
			this.chartStatus.Size = new System.Drawing.Size(535, 259);
			this.chartStatus.TabIndex = 4;
			this.chartStatus.Text = "chart";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1334, 690);
			this.Controls.Add(this.chartStatus);
			this.Controls.Add(this.chartLSP);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NAVY";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabNeural.ResumeLayout(false);
			this.tabNeural.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralNeurons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralLayers)).EndInit();
			this.tabHopfield.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picHopfieldInput)).EndInit();
			this.tabFractals.ResumeLayout(false);
			this.tabControlFractals.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsYOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsXOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsScale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsIterations)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFractalsParameters)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numFractalsGOCKoef)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFractalsGOCCount)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picFractalsPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartLSP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
		


		#endregion

		private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNeural;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridView gridNeuralLayers;
		private System.Windows.Forms.Button btnNeuralAddLayer;
		private System.Windows.Forms.Button btnNeuralDeleteLayer;
		private System.Windows.Forms.Label lblNeuralSynapses;
		private System.Windows.Forms.TextBox txtNeuralSynapses;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridView gridNeuralNeurons;
		private System.Windows.Forms.ProgressBar barNeuralProgress;
		private System.Windows.Forms.ProgressBar barNeuralMatch;
		private System.Windows.Forms.ComboBox cmbNeuralAlgorithm;
		private System.Windows.Forms.Button btnNeuralSchema;
		private System.Windows.Forms.NumericUpDown numNeuralEpoch;
		private System.Windows.Forms.Label lblNeuralEpoch;
		private System.Windows.Forms.Button btnNeuralExpectedLoad;
		private System.Windows.Forms.Button btnNeuralInputLoad;
		private System.Windows.Forms.Label lblNeuralExpected;
		private System.Windows.Forms.TextBox txtNeuralExpected;
		private System.Windows.Forms.Button btnNeuralRun;
		private System.Windows.Forms.Label lblNeuralOutput;
		private System.Windows.Forms.Label lblNeuralInput;
		private System.Windows.Forms.TextBox txtNeuralOutput;
		private System.Windows.Forms.TextBox txtNeuralInput;
		private System.Windows.Forms.Button btnNeuralSaveConfiguration;
		private System.Windows.Forms.Button btnNeuralLoadConfiguration;
		private System.Windows.Forms.Button btnNeuralSynapseRandom;
		private System.Windows.Forms.Button btnNeuralSynapsesZero;
		private System.Windows.Forms.Button btnNeuralNeuronsRandom;
		private System.Windows.Forms.Button btnNeuralNeuronsDefault;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLayer;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNeurons;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnFunction;
		private System.Windows.Forms.Button btnNeuralNeuronsNoAugment;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartLSP;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
		private System.Windows.Forms.Button btnNeuralActivate;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNeuron;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSlope;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAugment;
		private System.Windows.Forms.TabPage tabHopfield;
		private System.Windows.Forms.ComboBox cmbHopfieldValue;
		private System.Windows.Forms.PictureBox picHopfieldInput;
		private System.Windows.Forms.Button btnHopfieldRandom;
		private System.Windows.Forms.Button picHopfieldLearn;
		private System.Windows.Forms.Button pciHopfieldClassify;
		private System.Windows.Forms.ComboBox cmbHopfieldSymbols;
		private System.Windows.Forms.Button btnHopfieldClear;
		private System.Windows.Forms.Button btnHopfieldNoise;
		private System.Windows.Forms.TabPage tabFractals;
		private System.Windows.Forms.PictureBox picFractalsPicture;
		private System.Windows.Forms.TabControl tabControlFractals;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.NumericUpDown numFractalsScale;
		private System.Windows.Forms.Button btnFractalsLoad;
		private System.Windows.Forms.Button btnFractalsReset;
		private System.Windows.Forms.NumericUpDown numFractalsIterations;
		private System.Windows.Forms.Button btnFractalsDraw;
		private System.Windows.Forms.DataGridView gridFractalsParameters;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnA;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnB;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnC;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnD;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnE;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnF;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnProbability;
		private System.Windows.Forms.Button btnFractalsSave;
		private System.Windows.Forms.Button btnFractalsRandomize;
		private System.Windows.Forms.Button btnFractalsAttractorDelete;
		private System.Windows.Forms.Button btnFractalsAttractorAdd;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnFractalsGOCDraw;
		private System.Windows.Forms.NumericUpDown numFractalsGOCCount;
		private System.Windows.Forms.NumericUpDown numFractalsGOCKoef;
		private System.Windows.Forms.Button btnFractalsTEAReset;
		private System.Windows.Forms.NumericUpDown numFractalsYOffset;
		private System.Windows.Forms.NumericUpDown numFractalsXOffset;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}

