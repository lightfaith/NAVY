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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNeural = new System.Windows.Forms.TabPage();
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
			this.columnIntercept = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnAugment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNeuralSynapses = new System.Windows.Forms.Label();
			this.txtNeuralSynapses = new System.Windows.Forms.TextBox();
			this.btnNeuralDeleteLayer = new System.Windows.Forms.Button();
			this.btnNeuralAddLayer = new System.Windows.Forms.Button();
			this.gridNeuralLayers = new System.Windows.Forms.DataGridView();
			this.columnLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNeurons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabControl.SuspendLayout();
			this.tabNeural.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralNeurons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeuralLayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabNeural);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1355, 401);
			this.tabControl.TabIndex = 0;
			// 
			// tabNeural
			// 
			this.tabNeural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
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
			this.tabNeural.Size = new System.Drawing.Size(1347, 372);
			this.tabNeural.TabIndex = 0;
			this.tabNeural.Text = "Neural";
			// 
			// btnNeuralNeuronsNoAugment
			// 
			this.btnNeuralNeuronsNoAugment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralNeuronsNoAugment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralNeuronsNoAugment.Location = new System.Drawing.Point(460, 334);
			this.btnNeuralNeuronsNoAugment.Name = "btnNeuralNeuronsNoAugment";
			this.btnNeuralNeuronsNoAugment.Size = new System.Drawing.Size(103, 35);
			this.btnNeuralNeuronsNoAugment.TabIndex = 58;
			this.btnNeuralNeuronsNoAugment.Text = "No Augment";
			this.btnNeuralNeuronsNoAugment.UseVisualStyleBackColor = true;
			this.btnNeuralNeuronsNoAugment.Click += new System.EventHandler(this.btnNeuralNeuronsNoAugment_Click);
			// 
			// btnNeuralNeuronsDefault
			// 
			this.btnNeuralNeuronsDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralNeuronsDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralNeuronsDefault.Location = new System.Drawing.Point(375, 334);
			this.btnNeuralNeuronsDefault.Name = "btnNeuralNeuronsDefault";
			this.btnNeuralNeuronsDefault.Size = new System.Drawing.Size(79, 35);
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
			this.btnNeuralNeuronsRandom.Size = new System.Drawing.Size(94, 35);
			this.btnNeuralNeuronsRandom.TabIndex = 56;
			this.btnNeuralNeuronsRandom.Text = "Random";
			this.btnNeuralNeuronsRandom.UseVisualStyleBackColor = true;
			this.btnNeuralNeuronsRandom.Click += new System.EventHandler(this.btnNeuralNeuronsRandom_Click);
			// 
			// btnNeuralSynapsesZero
			// 
			this.btnNeuralSynapsesZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralSynapsesZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesZero.Location = new System.Drawing.Point(665, 334);
			this.btnNeuralSynapsesZero.Name = "btnNeuralSynapsesZero";
			this.btnNeuralSynapsesZero.Size = new System.Drawing.Size(89, 35);
			this.btnNeuralSynapsesZero.TabIndex = 55;
			this.btnNeuralSynapsesZero.Text = "Zero";
			this.btnNeuralSynapsesZero.UseVisualStyleBackColor = true;
			this.btnNeuralSynapsesZero.Click += new System.EventHandler(this.btnNeuralSynapsesZero_Click);
			// 
			// btnNeuralSynapseRandom
			// 
			this.btnNeuralSynapseRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralSynapseRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapseRandom.Location = new System.Drawing.Point(569, 334);
			this.btnNeuralSynapseRandom.Name = "btnNeuralSynapseRandom";
			this.btnNeuralSynapseRandom.Size = new System.Drawing.Size(89, 35);
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
			this.barNeuralProgress.Location = new System.Drawing.Point(765, 125);
			this.barNeuralProgress.Name = "barNeuralProgress";
			this.barNeuralProgress.Size = new System.Drawing.Size(170, 23);
			this.barNeuralProgress.TabIndex = 51;
			this.barNeuralProgress.Value = 100;
			// 
			// barNeuralMatch
			// 
			this.barNeuralMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.barNeuralMatch.Location = new System.Drawing.Point(1173, 350);
			this.barNeuralMatch.Name = "barNeuralMatch";
			this.barNeuralMatch.Size = new System.Drawing.Size(168, 19);
			this.barNeuralMatch.TabIndex = 50;
			// 
			// cmbNeuralAlgorithm
			// 
			this.cmbNeuralAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNeuralAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbNeuralAlgorithm.ForeColor = System.Drawing.Color.Silver;
			this.cmbNeuralAlgorithm.FormattingEnabled = true;
			this.cmbNeuralAlgorithm.Items.AddRange(new object[] {
            "Compute",
            "SOMA",
            "Fixed Increments",
            "Back Propagation"});
			this.cmbNeuralAlgorithm.Location = new System.Drawing.Point(765, 54);
			this.cmbNeuralAlgorithm.Name = "cmbNeuralAlgorithm";
			this.cmbNeuralAlgorithm.Size = new System.Drawing.Size(170, 24);
			this.cmbNeuralAlgorithm.TabIndex = 49;
			this.cmbNeuralAlgorithm.Text = "Compute";
			// 
			// btnNeuralSchema
			// 
			this.btnNeuralSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSchema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSchema.Location = new System.Drawing.Point(765, 154);
			this.btnNeuralSchema.Name = "btnNeuralSchema";
			this.btnNeuralSchema.Size = new System.Drawing.Size(170, 35);
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
			this.numNeuralEpoch.Location = new System.Drawing.Point(855, 26);
			this.numNeuralEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numNeuralEpoch.Name = "numNeuralEpoch";
			this.numNeuralEpoch.Size = new System.Drawing.Size(80, 22);
			this.numNeuralEpoch.TabIndex = 47;
			this.numNeuralEpoch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblNeuralEpoch
			// 
			this.lblNeuralEpoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralEpoch.AutoSize = true;
			this.lblNeuralEpoch.Location = new System.Drawing.Point(762, 28);
			this.lblNeuralEpoch.Name = "lblNeuralEpoch";
			this.lblNeuralEpoch.Size = new System.Drawing.Size(55, 17);
			this.lblNeuralEpoch.TabIndex = 46;
			this.lblNeuralEpoch.Text = "Epochs";
			// 
			// btnNeuralExpectedLoad
			// 
			this.btnNeuralExpectedLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralExpectedLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralExpectedLoad.Location = new System.Drawing.Point(1057, 334);
			this.btnNeuralExpectedLoad.Name = "btnNeuralExpectedLoad";
			this.btnNeuralExpectedLoad.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralExpectedLoad.TabIndex = 44;
			this.btnNeuralExpectedLoad.Text = "Load";
			this.btnNeuralExpectedLoad.UseVisualStyleBackColor = true;
			this.btnNeuralExpectedLoad.Click += new System.EventHandler(this.btnNeuralExpectedLoad_Click);
			// 
			// btnNeuralInputLoad
			// 
			this.btnNeuralInputLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralInputLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralInputLoad.Location = new System.Drawing.Point(941, 334);
			this.btnNeuralInputLoad.Name = "btnNeuralInputLoad";
			this.btnNeuralInputLoad.Size = new System.Drawing.Size(110, 35);
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
			this.lblNeuralExpected.Location = new System.Drawing.Point(1054, 6);
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
			this.txtNeuralExpected.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralExpected.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralExpected.Location = new System.Drawing.Point(1057, 26);
			this.txtNeuralExpected.Multiline = true;
			this.txtNeuralExpected.Name = "txtNeuralExpected";
			this.txtNeuralExpected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralExpected.Size = new System.Drawing.Size(110, 302);
			this.txtNeuralExpected.TabIndex = 41;
			this.txtNeuralExpected.Text = "1\r\n0\r\n1\r\n1";
			this.txtNeuralExpected.WordWrap = false;
			// 
			// btnNeuralRun
			// 
			this.btnNeuralRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralRun.Location = new System.Drawing.Point(765, 84);
			this.btnNeuralRun.Name = "btnNeuralRun";
			this.btnNeuralRun.Size = new System.Drawing.Size(170, 35);
			this.btnNeuralRun.TabIndex = 40;
			this.btnNeuralRun.Text = "Run";
			this.btnNeuralRun.UseVisualStyleBackColor = true;
			this.btnNeuralRun.Click += new System.EventHandler(this.btnNeuralRun_Click);
			// 
			// lblNeuralOutput
			// 
			this.lblNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralOutput.AutoSize = true;
			this.lblNeuralOutput.Location = new System.Drawing.Point(1170, 6);
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
			this.lblNeuralInput.Location = new System.Drawing.Point(938, 6);
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
			this.txtNeuralOutput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralOutput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralOutput.Location = new System.Drawing.Point(1173, 26);
			this.txtNeuralOutput.Multiline = true;
			this.txtNeuralOutput.Name = "txtNeuralOutput";
			this.txtNeuralOutput.ReadOnly = true;
			this.txtNeuralOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralOutput.Size = new System.Drawing.Size(168, 318);
			this.txtNeuralOutput.TabIndex = 37;
			this.txtNeuralOutput.WordWrap = false;
			// 
			// txtNeuralInput
			// 
			this.txtNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralInput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralInput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralInput.Location = new System.Drawing.Point(941, 26);
			this.txtNeuralInput.Multiline = true;
			this.txtNeuralInput.Name = "txtNeuralInput";
			this.txtNeuralInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralInput.Size = new System.Drawing.Size(110, 302);
			this.txtNeuralInput.TabIndex = 36;
			this.txtNeuralInput.Text = "0;0\r\n0;1\r\n1;0\r\n1;1";
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
            this.columnIntercept,
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
			this.gridNeuralNeurons.Size = new System.Drawing.Size(288, 325);
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
			// columnIntercept
			// 
			this.columnIntercept.HeaderText = "Intercept";
			this.columnIntercept.MinimumWidth = 60;
			this.columnIntercept.Name = "columnIntercept";
			this.columnIntercept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnIntercept.Width = 60;
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
			this.lblNeuralSynapses.Location = new System.Drawing.Point(566, 6);
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
			this.txtNeuralSynapses.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralSynapses.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralSynapses.Location = new System.Drawing.Point(569, 26);
			this.txtNeuralSynapses.Multiline = true;
			this.txtNeuralSynapses.Name = "txtNeuralSynapses";
			this.txtNeuralSynapses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralSynapses.Size = new System.Drawing.Size(185, 302);
			this.txtNeuralSynapses.TabIndex = 21;
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
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtLog.ForeColor = System.Drawing.Color.Silver;
			this.txtLog.Location = new System.Drawing.Point(12, 419);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(955, 259);
			this.txtLog.TabIndex = 1;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			// 
			// chart
			// 
			this.chart.BackColor = System.Drawing.Color.Black;
			chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			customLabel1.ForeColor = System.Drawing.Color.Lime;
			chartArea1.AxisY2.CustomLabels.Add(customLabel1);
			chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Silver;
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Black;
			legend1.ForeColor = System.Drawing.Color.Silver;
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(973, 419);
			this.chart.Name = "chart";
			series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			series1.ChartArea = "ChartArea1";
			series1.Color = System.Drawing.Color.Lime;
			series1.LabelBackColor = System.Drawing.Color.Green;
			series1.LabelForeColor = System.Drawing.Color.Maroon;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(394, 259);
			this.chart.TabIndex = 3;
			this.chart.Text = "chart";
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1379, 690);
			this.Controls.Add(this.chart);
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
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNeuron;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSlope;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnIntercept;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnAugment;
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
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
	}
}

