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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNeural = new System.Windows.Forms.TabPage();
			this.checkNeuralAugmented = new System.Windows.Forms.CheckBox();
			this.cmbNeuralAlgorithm = new System.Windows.Forms.ComboBox();
			this.btnNeuralSchema = new System.Windows.Forms.Button();
			this.btnNeuralSynapsesSave = new System.Windows.Forms.Button();
			this.numNeuralEpoch = new System.Windows.Forms.NumericUpDown();
			this.lblNeuralEpoch = new System.Windows.Forms.Label();
			this.btnNeuralSynapsesInit = new System.Windows.Forms.Button();
			this.cmbNeuralInitValue = new System.Windows.Forms.ComboBox();
			this.lblNeuralSynapses = new System.Windows.Forms.Label();
			this.txtNeuralSynapses = new System.Windows.Forms.TextBox();
			this.btnNeuralOutputSave = new System.Windows.Forms.Button();
			this.btnNeuralExpectedLoad = new System.Windows.Forms.Button();
			this.btnNeuralInputLoad = new System.Windows.Forms.Button();
			this.btnNeuralDeleteLayer = new System.Windows.Forms.Button();
			this.lblNeuralExpected = new System.Windows.Forms.Label();
			this.txtNeuralExpected = new System.Windows.Forms.TextBox();
			this.btnNeuralRun = new System.Windows.Forms.Button();
			this.btnNeuralAddLayer = new System.Windows.Forms.Button();
			this.gridNeural = new System.Windows.Forms.DataGridView();
			this.lblNeuralOutput = new System.Windows.Forms.Label();
			this.lblNeuralInput = new System.Windows.Forms.Label();
			this.txtNeuralOutput = new System.Windows.Forms.TextBox();
			this.txtNeuralInput = new System.Windows.Forms.TextBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.columnLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNeurons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.tabControl.SuspendLayout();
			this.tabNeural.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeural)).BeginInit();
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
			this.tabControl.Size = new System.Drawing.Size(1318, 366);
			this.tabControl.TabIndex = 0;
			// 
			// tabNeural
			// 
			this.tabNeural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.tabNeural.Controls.Add(this.checkNeuralAugmented);
			this.tabNeural.Controls.Add(this.cmbNeuralAlgorithm);
			this.tabNeural.Controls.Add(this.btnNeuralSchema);
			this.tabNeural.Controls.Add(this.btnNeuralSynapsesSave);
			this.tabNeural.Controls.Add(this.numNeuralEpoch);
			this.tabNeural.Controls.Add(this.lblNeuralEpoch);
			this.tabNeural.Controls.Add(this.btnNeuralSynapsesInit);
			this.tabNeural.Controls.Add(this.cmbNeuralInitValue);
			this.tabNeural.Controls.Add(this.lblNeuralSynapses);
			this.tabNeural.Controls.Add(this.txtNeuralSynapses);
			this.tabNeural.Controls.Add(this.btnNeuralOutputSave);
			this.tabNeural.Controls.Add(this.btnNeuralExpectedLoad);
			this.tabNeural.Controls.Add(this.btnNeuralInputLoad);
			this.tabNeural.Controls.Add(this.btnNeuralDeleteLayer);
			this.tabNeural.Controls.Add(this.lblNeuralExpected);
			this.tabNeural.Controls.Add(this.txtNeuralExpected);
			this.tabNeural.Controls.Add(this.btnNeuralRun);
			this.tabNeural.Controls.Add(this.btnNeuralAddLayer);
			this.tabNeural.Controls.Add(this.gridNeural);
			this.tabNeural.Controls.Add(this.lblNeuralOutput);
			this.tabNeural.Controls.Add(this.lblNeuralInput);
			this.tabNeural.Controls.Add(this.txtNeuralOutput);
			this.tabNeural.Controls.Add(this.txtNeuralInput);
			this.tabNeural.ForeColor = System.Drawing.Color.Silver;
			this.tabNeural.Location = new System.Drawing.Point(4, 25);
			this.tabNeural.Name = "tabNeural";
			this.tabNeural.Size = new System.Drawing.Size(1310, 337);
			this.tabNeural.TabIndex = 0;
			this.tabNeural.Text = "Neural";
			// 
			// checkNeuralAugmented
			// 
			this.checkNeuralAugmented.AutoSize = true;
			this.checkNeuralAugmented.Location = new System.Drawing.Point(500, 52);
			this.checkNeuralAugmented.Name = "checkNeuralAugmented";
			this.checkNeuralAugmented.Size = new System.Drawing.Size(176, 21);
			this.checkNeuralAugmented.TabIndex = 32;
			this.checkNeuralAugmented.Text = "Add Augmented Vector";
			this.checkNeuralAugmented.UseVisualStyleBackColor = true;
			// 
			// cmbNeuralAlgorithm
			// 
			this.cmbNeuralAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNeuralAlgorithm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbNeuralAlgorithm.ForeColor = System.Drawing.Color.Silver;
			this.cmbNeuralAlgorithm.FormattingEnabled = true;
			this.cmbNeuralAlgorithm.Items.AddRange(new object[] {
            "SOMA",
            "Iterative",
            "Back Propagation"});
			this.cmbNeuralAlgorithm.Location = new System.Drawing.Point(500, 79);
			this.cmbNeuralAlgorithm.Name = "cmbNeuralAlgorithm";
			this.cmbNeuralAlgorithm.Size = new System.Drawing.Size(170, 24);
			this.cmbNeuralAlgorithm.TabIndex = 31;
			this.cmbNeuralAlgorithm.Text = "SOMA";
			// 
			// btnNeuralSchema
			// 
			this.btnNeuralSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSchema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSchema.Location = new System.Drawing.Point(500, 150);
			this.btnNeuralSchema.Name = "btnNeuralSchema";
			this.btnNeuralSchema.Size = new System.Drawing.Size(170, 35);
			this.btnNeuralSchema.TabIndex = 30;
			this.btnNeuralSchema.Text = "Schema";
			this.btnNeuralSchema.UseVisualStyleBackColor = true;
			this.btnNeuralSchema.Click += new System.EventHandler(this.btnNeuralSchema_Click);
			// 
			// btnNeuralSynapsesSave
			// 
			this.btnNeuralSynapsesSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSynapsesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesSave.Location = new System.Drawing.Point(1245, 299);
			this.btnNeuralSynapsesSave.Name = "btnNeuralSynapsesSave";
			this.btnNeuralSynapsesSave.Size = new System.Drawing.Size(60, 35);
			this.btnNeuralSynapsesSave.TabIndex = 29;
			this.btnNeuralSynapsesSave.Text = "Save";
			this.btnNeuralSynapsesSave.UseVisualStyleBackColor = true;
			this.btnNeuralSynapsesSave.Click += new System.EventHandler(this.btnNeuralSynapsesSave_Click);
			// 
			// numNeuralEpoch
			// 
			this.numNeuralEpoch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numNeuralEpoch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.numNeuralEpoch.ForeColor = System.Drawing.Color.Silver;
			this.numNeuralEpoch.Location = new System.Drawing.Point(590, 20);
			this.numNeuralEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numNeuralEpoch.Name = "numNeuralEpoch";
			this.numNeuralEpoch.Size = new System.Drawing.Size(80, 22);
			this.numNeuralEpoch.TabIndex = 27;
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
			this.lblNeuralEpoch.Location = new System.Drawing.Point(497, 22);
			this.lblNeuralEpoch.Name = "lblNeuralEpoch";
			this.lblNeuralEpoch.Size = new System.Drawing.Size(55, 17);
			this.lblNeuralEpoch.TabIndex = 26;
			this.lblNeuralEpoch.Text = "Epochs";
			// 
			// btnNeuralSynapsesInit
			// 
			this.btnNeuralSynapsesInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSynapsesInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesInit.Location = new System.Drawing.Point(1178, 299);
			this.btnNeuralSynapsesInit.Name = "btnNeuralSynapsesInit";
			this.btnNeuralSynapsesInit.Size = new System.Drawing.Size(61, 35);
			this.btnNeuralSynapsesInit.TabIndex = 24;
			this.btnNeuralSynapsesInit.Text = "Init";
			this.btnNeuralSynapsesInit.UseVisualStyleBackColor = true;
			this.btnNeuralSynapsesInit.Click += new System.EventHandler(this.btnNeuralSynapsesInit_Click);
			// 
			// cmbNeuralInitValue
			// 
			this.cmbNeuralInitValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbNeuralInitValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.cmbNeuralInitValue.ForeColor = System.Drawing.Color.Silver;
			this.cmbNeuralInitValue.FormattingEnabled = true;
			this.cmbNeuralInitValue.Items.AddRange(new object[] {
            "Random",
            "-1",
            "-0.5",
            "0",
            "0.5",
            "1"});
			this.cmbNeuralInitValue.Location = new System.Drawing.Point(1085, 303);
			this.cmbNeuralInitValue.Name = "cmbNeuralInitValue";
			this.cmbNeuralInitValue.Size = new System.Drawing.Size(87, 24);
			this.cmbNeuralInitValue.TabIndex = 23;
			this.cmbNeuralInitValue.Text = "Random";
			// 
			// lblNeuralSynapses
			// 
			this.lblNeuralSynapses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralSynapses.AutoSize = true;
			this.lblNeuralSynapses.Location = new System.Drawing.Point(1082, 3);
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
			this.txtNeuralSynapses.Location = new System.Drawing.Point(1085, 20);
			this.txtNeuralSynapses.Multiline = true;
			this.txtNeuralSynapses.Name = "txtNeuralSynapses";
			this.txtNeuralSynapses.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralSynapses.Size = new System.Drawing.Size(220, 273);
			this.txtNeuralSynapses.TabIndex = 21;
			// 
			// btnNeuralOutputSave
			// 
			this.btnNeuralOutputSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralOutputSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralOutputSave.Location = new System.Drawing.Point(792, 298);
			this.btnNeuralOutputSave.Name = "btnNeuralOutputSave";
			this.btnNeuralOutputSave.Size = new System.Drawing.Size(168, 35);
			this.btnNeuralOutputSave.TabIndex = 19;
			this.btnNeuralOutputSave.Text = "Save";
			this.btnNeuralOutputSave.UseVisualStyleBackColor = true;
			this.btnNeuralOutputSave.Click += new System.EventHandler(this.btnNeuralOutputSave_Click);
			// 
			// btnNeuralExpectedLoad
			// 
			this.btnNeuralExpectedLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralExpectedLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralExpectedLoad.Location = new System.Drawing.Point(969, 298);
			this.btnNeuralExpectedLoad.Name = "btnNeuralExpectedLoad";
			this.btnNeuralExpectedLoad.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralExpectedLoad.TabIndex = 18;
			this.btnNeuralExpectedLoad.Text = "Load";
			this.btnNeuralExpectedLoad.UseVisualStyleBackColor = true;
			this.btnNeuralExpectedLoad.Click += new System.EventHandler(this.btnNeuralExpectedLoad_Click);
			// 
			// btnNeuralInputLoad
			// 
			this.btnNeuralInputLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralInputLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralInputLoad.Location = new System.Drawing.Point(676, 298);
			this.btnNeuralInputLoad.Name = "btnNeuralInputLoad";
			this.btnNeuralInputLoad.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralInputLoad.TabIndex = 17;
			this.btnNeuralInputLoad.Text = "Load";
			this.btnNeuralInputLoad.UseVisualStyleBackColor = true;
			this.btnNeuralInputLoad.Click += new System.EventHandler(this.btnNeuralInputLoad_Click);
			// 
			// btnNeuralDeleteLayer
			// 
			this.btnNeuralDeleteLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralDeleteLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralDeleteLayer.Location = new System.Drawing.Point(119, 299);
			this.btnNeuralDeleteLayer.Name = "btnNeuralDeleteLayer";
			this.btnNeuralDeleteLayer.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralDeleteLayer.TabIndex = 16;
			this.btnNeuralDeleteLayer.Text = "Delete Layer";
			this.btnNeuralDeleteLayer.UseVisualStyleBackColor = true;
			this.btnNeuralDeleteLayer.Click += new System.EventHandler(this.btnNeuralDeleteLayer_Click);
			// 
			// lblNeuralExpected
			// 
			this.lblNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralExpected.AutoSize = true;
			this.lblNeuralExpected.Location = new System.Drawing.Point(966, 3);
			this.lblNeuralExpected.Name = "lblNeuralExpected";
			this.lblNeuralExpected.Size = new System.Drawing.Size(66, 17);
			this.lblNeuralExpected.TabIndex = 15;
			this.lblNeuralExpected.Text = "Expected";
			// 
			// txtNeuralExpected
			// 
			this.txtNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralExpected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralExpected.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralExpected.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralExpected.Location = new System.Drawing.Point(969, 19);
			this.txtNeuralExpected.Multiline = true;
			this.txtNeuralExpected.Name = "txtNeuralExpected";
			this.txtNeuralExpected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralExpected.Size = new System.Drawing.Size(110, 274);
			this.txtNeuralExpected.TabIndex = 14;
			this.txtNeuralExpected.Text = "1";
			// 
			// btnNeuralRun
			// 
			this.btnNeuralRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralRun.Location = new System.Drawing.Point(500, 109);
			this.btnNeuralRun.Name = "btnNeuralRun";
			this.btnNeuralRun.Size = new System.Drawing.Size(170, 35);
			this.btnNeuralRun.TabIndex = 13;
			this.btnNeuralRun.Text = "Run";
			this.btnNeuralRun.UseVisualStyleBackColor = true;
			this.btnNeuralRun.Click += new System.EventHandler(this.btnNeuralRun_Click);
			// 
			// btnNeuralAddLayer
			// 
			this.btnNeuralAddLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralAddLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralAddLayer.Location = new System.Drawing.Point(3, 299);
			this.btnNeuralAddLayer.Name = "btnNeuralAddLayer";
			this.btnNeuralAddLayer.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralAddLayer.TabIndex = 11;
			this.btnNeuralAddLayer.Text = "Add Layer";
			this.btnNeuralAddLayer.UseVisualStyleBackColor = true;
			this.btnNeuralAddLayer.Click += new System.EventHandler(this.btnNeuralAddLayer_Click);
			// 
			// gridNeural
			// 
			this.gridNeural.AllowUserToAddRows = false;
			this.gridNeural.AllowUserToDeleteRows = false;
			this.gridNeural.AllowUserToOrderColumns = true;
			this.gridNeural.AllowUserToResizeRows = false;
			this.gridNeural.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridNeural.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridNeural.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridNeural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridNeural.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLayer,
            this.columnNeurons,
            this.columnFunction});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridNeural.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridNeural.Location = new System.Drawing.Point(3, 3);
			this.gridNeural.Name = "gridNeural";
			this.gridNeural.RowTemplate.Height = 24;
			this.gridNeural.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNeural.ShowEditingIcon = false;
			this.gridNeural.Size = new System.Drawing.Size(491, 290);
			this.gridNeural.TabIndex = 10;
			this.gridNeural.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridNeural_RowsAdded);
			// 
			// lblNeuralOutput
			// 
			this.lblNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralOutput.AutoSize = true;
			this.lblNeuralOutput.Location = new System.Drawing.Point(789, 3);
			this.lblNeuralOutput.Name = "lblNeuralOutput";
			this.lblNeuralOutput.Size = new System.Drawing.Size(51, 17);
			this.lblNeuralOutput.TabIndex = 9;
			this.lblNeuralOutput.Text = "Output";
			// 
			// lblNeuralInput
			// 
			this.lblNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralInput.AutoSize = true;
			this.lblNeuralInput.Location = new System.Drawing.Point(673, 3);
			this.lblNeuralInput.Name = "lblNeuralInput";
			this.lblNeuralInput.Size = new System.Drawing.Size(39, 17);
			this.lblNeuralInput.TabIndex = 8;
			this.lblNeuralInput.Text = "Input";
			// 
			// txtNeuralOutput
			// 
			this.txtNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralOutput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralOutput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralOutput.Location = new System.Drawing.Point(792, 19);
			this.txtNeuralOutput.Multiline = true;
			this.txtNeuralOutput.Name = "txtNeuralOutput";
			this.txtNeuralOutput.ReadOnly = true;
			this.txtNeuralOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralOutput.Size = new System.Drawing.Size(168, 274);
			this.txtNeuralOutput.TabIndex = 7;
			// 
			// txtNeuralInput
			// 
			this.txtNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralInput.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.txtNeuralInput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralInput.Location = new System.Drawing.Point(676, 19);
			this.txtNeuralInput.Multiline = true;
			this.txtNeuralInput.Name = "txtNeuralInput";
			this.txtNeuralInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralInput.Size = new System.Drawing.Size(110, 274);
			this.txtNeuralInput.TabIndex = 6;
			this.txtNeuralInput.Text = "0;0\r\n";
			// 
			// txtLog
			// 
			this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtLog.ForeColor = System.Drawing.Color.Silver;
			this.txtLog.Location = new System.Drawing.Point(12, 384);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(1318, 76);
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
			this.columnFunction.HeaderText = "Function";
			this.columnFunction.MinimumWidth = 120;
			this.columnFunction.Name = "columnFunction";
			this.columnFunction.Width = 120;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1342, 472);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "NAVY";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabNeural.ResumeLayout(false);
			this.tabNeural.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridNeural)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabNeural;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtNeuralOutput;
        private System.Windows.Forms.TextBox txtNeuralInput;
        private System.Windows.Forms.Label lblNeuralOutput;
        private System.Windows.Forms.Label lblNeuralInput;
        private System.Windows.Forms.DataGridView gridNeural;
		private System.Windows.Forms.Button btnNeuralAddLayer;
		private System.Windows.Forms.Button btnNeuralRun;
		private System.Windows.Forms.Label lblNeuralExpected;
		private System.Windows.Forms.TextBox txtNeuralExpected;
		private System.Windows.Forms.Button btnNeuralDeleteLayer;
		private System.Windows.Forms.Button btnNeuralOutputSave;
		private System.Windows.Forms.Button btnNeuralExpectedLoad;
		private System.Windows.Forms.Button btnNeuralInputLoad;
		private System.Windows.Forms.Label lblNeuralSynapses;
		private System.Windows.Forms.TextBox txtNeuralSynapses;
		private System.Windows.Forms.Button btnNeuralSynapsesInit;
		private System.Windows.Forms.NumericUpDown numNeuralEpoch;
		private System.Windows.Forms.Label lblNeuralEpoch;
		private System.Windows.Forms.ComboBox cmbNeuralInitValue;
		private System.Windows.Forms.Button btnNeuralSynapsesSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnNeuralSchema;
		private System.Windows.Forms.CheckBox checkNeuralAugmented;
		private System.Windows.Forms.ComboBox cmbNeuralAlgorithm;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnLayer;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNeurons;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnFunction;
	}
}

