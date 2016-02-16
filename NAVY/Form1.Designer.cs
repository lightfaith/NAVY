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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabNeural = new System.Windows.Forms.TabPage();
			this.btnNeuralRun = new System.Windows.Forms.Button();
			this.btnNeuralAddLayer = new System.Windows.Forms.Button();
			this.gridNeural = new System.Windows.Forms.DataGridView();
			this.columnLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNeurons = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFunction = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.lblNeuralOutput = new System.Windows.Forms.Label();
			this.lblNeuralInput = new System.Windows.Forms.Label();
			this.txtNeuralOutput = new System.Windows.Forms.TextBox();
			this.txtNeuralInput = new System.Windows.Forms.TextBox();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.txtNeuralExpected = new System.Windows.Forms.TextBox();
			this.lblNeuralExpected = new System.Windows.Forms.Label();
			this.btnNeuralDeleteLayer = new System.Windows.Forms.Button();
			this.btnNeuralInputLoad = new System.Windows.Forms.Button();
			this.btnNeuralExpectedLoad = new System.Windows.Forms.Button();
			this.btnNeuralOutputSave = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lblNeuralSynapses = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnNeuralSynapsesInit = new System.Windows.Forms.Button();
			this.grpNeuralInterval = new System.Windows.Forms.GroupBox();
			this.radioNeuralIntervalUnipolar = new System.Windows.Forms.RadioButton();
			this.radioNeuralIntervalBipolar = new System.Windows.Forms.RadioButton();
			this.lblNeuralEpoch = new System.Windows.Forms.Label();
			this.numNeuralEpoch = new System.Windows.Forms.NumericUpDown();
			this.btnNeuralSynapsesUpdate = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabNeural.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNeural)).BeginInit();
			this.grpNeuralInterval.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).BeginInit();
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
			this.tabControl.Size = new System.Drawing.Size(1200, 366);
			this.tabControl.TabIndex = 0;
			// 
			// tabNeural
			// 
			this.tabNeural.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.tabNeural.Controls.Add(this.btnNeuralSynapsesUpdate);
			this.tabNeural.Controls.Add(this.numNeuralEpoch);
			this.tabNeural.Controls.Add(this.lblNeuralEpoch);
			this.tabNeural.Controls.Add(this.grpNeuralInterval);
			this.tabNeural.Controls.Add(this.btnNeuralSynapsesInit);
			this.tabNeural.Controls.Add(this.comboBox1);
			this.tabNeural.Controls.Add(this.lblNeuralSynapses);
			this.tabNeural.Controls.Add(this.textBox1);
			this.tabNeural.Controls.Add(this.button1);
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
			this.tabNeural.Size = new System.Drawing.Size(1192, 337);
			this.tabNeural.TabIndex = 0;
			this.tabNeural.Text = "Neural";
			// 
			// btnNeuralRun
			// 
			this.btnNeuralRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralRun.Location = new System.Drawing.Point(382, 92);
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
			this.btnNeuralAddLayer.Location = new System.Drawing.Point(3, 297);
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
			this.gridNeural.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridNeural.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.gridNeural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridNeural.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnLayer,
            this.columnNeurons,
            this.columnFunction});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridNeural.DefaultCellStyle = dataGridViewCellStyle3;
			this.gridNeural.Location = new System.Drawing.Point(3, 3);
			this.gridNeural.Name = "gridNeural";
			this.gridNeural.RowTemplate.Height = 24;
			this.gridNeural.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridNeural.ShowEditingIcon = false;
			this.gridNeural.Size = new System.Drawing.Size(373, 288);
			this.gridNeural.TabIndex = 10;
			this.gridNeural.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridNeural_RowsAdded);
			// 
			// columnLayer
			// 
			this.columnLayer.HeaderText = "Layer";
			this.columnLayer.Name = "columnLayer";
			this.columnLayer.ReadOnly = true;
			this.columnLayer.Width = 73;
			// 
			// columnNeurons
			// 
			this.columnNeurons.HeaderText = "Neurons";
			this.columnNeurons.Name = "columnNeurons";
			this.columnNeurons.Width = 91;
			// 
			// columnFunction
			// 
			this.columnFunction.HeaderText = "Function";
			this.columnFunction.Name = "columnFunction";
			this.columnFunction.Width = 68;
			// 
			// lblNeuralOutput
			// 
			this.lblNeuralOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralOutput.AutoSize = true;
			this.lblNeuralOutput.Location = new System.Drawing.Point(749, 0);
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
			this.lblNeuralInput.Location = new System.Drawing.Point(633, 0);
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
			this.txtNeuralOutput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralOutput.Location = new System.Drawing.Point(752, 20);
			this.txtNeuralOutput.Multiline = true;
			this.txtNeuralOutput.Name = "txtNeuralOutput";
			this.txtNeuralOutput.ReadOnly = true;
			this.txtNeuralOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralOutput.Size = new System.Drawing.Size(110, 274);
			this.txtNeuralOutput.TabIndex = 7;
			// 
			// txtNeuralInput
			// 
			this.txtNeuralInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralInput.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralInput.Location = new System.Drawing.Point(636, 20);
			this.txtNeuralInput.Multiline = true;
			this.txtNeuralInput.Name = "txtNeuralInput";
			this.txtNeuralInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralInput.Size = new System.Drawing.Size(110, 274);
			this.txtNeuralInput.TabIndex = 6;
			this.txtNeuralInput.Text = "0;0\r\n0;1\r\n1;0\r\n1;1\r\n";
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
			this.txtLog.Size = new System.Drawing.Size(1200, 76);
			this.txtLog.TabIndex = 1;
			// 
			// txtNeuralExpected
			// 
			this.txtNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNeuralExpected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.txtNeuralExpected.ForeColor = System.Drawing.Color.Silver;
			this.txtNeuralExpected.Location = new System.Drawing.Point(871, 20);
			this.txtNeuralExpected.Multiline = true;
			this.txtNeuralExpected.Name = "txtNeuralExpected";
			this.txtNeuralExpected.ReadOnly = true;
			this.txtNeuralExpected.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtNeuralExpected.Size = new System.Drawing.Size(110, 274);
			this.txtNeuralExpected.TabIndex = 14;
			this.txtNeuralExpected.Text = "1\r\n1\r\n0\r\n1";
			// 
			// lblNeuralExpected
			// 
			this.lblNeuralExpected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralExpected.AutoSize = true;
			this.lblNeuralExpected.Location = new System.Drawing.Point(868, 0);
			this.lblNeuralExpected.Name = "lblNeuralExpected";
			this.lblNeuralExpected.Size = new System.Drawing.Size(66, 17);
			this.lblNeuralExpected.TabIndex = 15;
			this.lblNeuralExpected.Text = "Expected";
			// 
			// btnNeuralDeleteLayer
			// 
			this.btnNeuralDeleteLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNeuralDeleteLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralDeleteLayer.Location = new System.Drawing.Point(119, 297);
			this.btnNeuralDeleteLayer.Name = "btnNeuralDeleteLayer";
			this.btnNeuralDeleteLayer.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralDeleteLayer.TabIndex = 16;
			this.btnNeuralDeleteLayer.Text = "Delete Layer";
			this.btnNeuralDeleteLayer.UseVisualStyleBackColor = true;
			this.btnNeuralDeleteLayer.Click += new System.EventHandler(this.btnNeuralDeleteLayer_Click);
			// 
			// btnNeuralInputLoad
			// 
			this.btnNeuralInputLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralInputLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralInputLoad.Location = new System.Drawing.Point(636, 299);
			this.btnNeuralInputLoad.Name = "btnNeuralInputLoad";
			this.btnNeuralInputLoad.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralInputLoad.TabIndex = 17;
			this.btnNeuralInputLoad.Text = "Load";
			this.btnNeuralInputLoad.UseVisualStyleBackColor = true;
			// 
			// btnNeuralExpectedLoad
			// 
			this.btnNeuralExpectedLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralExpectedLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralExpectedLoad.Location = new System.Drawing.Point(871, 299);
			this.btnNeuralExpectedLoad.Name = "btnNeuralExpectedLoad";
			this.btnNeuralExpectedLoad.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralExpectedLoad.TabIndex = 18;
			this.btnNeuralExpectedLoad.Text = "Load";
			this.btnNeuralExpectedLoad.UseVisualStyleBackColor = true;
			// 
			// btnNeuralOutputSave
			// 
			this.btnNeuralOutputSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralOutputSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralOutputSave.Location = new System.Drawing.Point(752, 299);
			this.btnNeuralOutputSave.Name = "btnNeuralOutputSave";
			this.btnNeuralOutputSave.Size = new System.Drawing.Size(110, 35);
			this.btnNeuralOutputSave.TabIndex = 19;
			this.btnNeuralOutputSave.Text = "Save";
			this.btnNeuralOutputSave.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(382, 133);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 35);
			this.button1.TabIndex = 20;
			this.button1.Text = "Schema";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lblNeuralSynapses
			// 
			this.lblNeuralSynapses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNeuralSynapses.AutoSize = true;
			this.lblNeuralSynapses.Location = new System.Drawing.Point(986, 0);
			this.lblNeuralSynapses.Name = "lblNeuralSynapses";
			this.lblNeuralSynapses.Size = new System.Drawing.Size(70, 17);
			this.lblNeuralSynapses.TabIndex = 22;
			this.lblNeuralSynapses.Text = "Synapses";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.textBox1.ForeColor = System.Drawing.Color.Silver;
			this.textBox1.Location = new System.Drawing.Point(989, 20);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(198, 277);
			this.textBox1.TabIndex = 21;
			this.textBox1.Text = "i1-n0_0: 0.6\r\ni2-n0_0: 0.7";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.comboBox1.ForeColor = System.Drawing.Color.Silver;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Random",
            "0",
            "0.5",
            "1"});
			this.comboBox1.Location = new System.Drawing.Point(989, 303);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(80, 24);
			this.comboBox1.TabIndex = 23;
			this.comboBox1.Text = "Random";
			// 
			// btnNeuralSynapsesInit
			// 
			this.btnNeuralSynapsesInit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSynapsesInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesInit.Location = new System.Drawing.Point(1074, 299);
			this.btnNeuralSynapsesInit.Name = "btnNeuralSynapsesInit";
			this.btnNeuralSynapsesInit.Size = new System.Drawing.Size(40, 35);
			this.btnNeuralSynapsesInit.TabIndex = 24;
			this.btnNeuralSynapsesInit.Text = "Init";
			this.btnNeuralSynapsesInit.UseVisualStyleBackColor = true;
			// 
			// grpNeuralInterval
			// 
			this.grpNeuralInterval.Controls.Add(this.radioNeuralIntervalBipolar);
			this.grpNeuralInterval.Controls.Add(this.radioNeuralIntervalUnipolar);
			this.grpNeuralInterval.Location = new System.Drawing.Point(382, 3);
			this.grpNeuralInterval.Name = "grpNeuralInterval";
			this.grpNeuralInterval.Size = new System.Drawing.Size(170, 55);
			this.grpNeuralInterval.TabIndex = 25;
			this.grpNeuralInterval.TabStop = false;
			this.grpNeuralInterval.Text = "Interval";
			// 
			// radioNeuralIntervalUnipolar
			// 
			this.radioNeuralIntervalUnipolar.AutoSize = true;
			this.radioNeuralIntervalUnipolar.Checked = true;
			this.radioNeuralIntervalUnipolar.Location = new System.Drawing.Point(6, 21);
			this.radioNeuralIntervalUnipolar.Name = "radioNeuralIntervalUnipolar";
			this.radioNeuralIntervalUnipolar.Size = new System.Drawing.Size(69, 21);
			this.radioNeuralIntervalUnipolar.TabIndex = 0;
			this.radioNeuralIntervalUnipolar.TabStop = true;
			this.radioNeuralIntervalUnipolar.Text = "<0; 1>";
			this.radioNeuralIntervalUnipolar.UseVisualStyleBackColor = true;
			// 
			// radioNeuralIntervalBipolar
			// 
			this.radioNeuralIntervalBipolar.AutoSize = true;
			this.radioNeuralIntervalBipolar.Location = new System.Drawing.Point(90, 21);
			this.radioNeuralIntervalBipolar.Name = "radioNeuralIntervalBipolar";
			this.radioNeuralIntervalBipolar.Size = new System.Drawing.Size(74, 21);
			this.radioNeuralIntervalBipolar.TabIndex = 1;
			this.radioNeuralIntervalBipolar.Text = "<-1; 1>";
			this.radioNeuralIntervalBipolar.UseVisualStyleBackColor = true;
			// 
			// lblNeuralEpoch
			// 
			this.lblNeuralEpoch.AutoSize = true;
			this.lblNeuralEpoch.Location = new System.Drawing.Point(382, 66);
			this.lblNeuralEpoch.Name = "lblNeuralEpoch";
			this.lblNeuralEpoch.Size = new System.Drawing.Size(48, 17);
			this.lblNeuralEpoch.TabIndex = 26;
			this.lblNeuralEpoch.Text = "Epoch";
			// 
			// numNeuralEpoch
			// 
			this.numNeuralEpoch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.numNeuralEpoch.ForeColor = System.Drawing.Color.Silver;
			this.numNeuralEpoch.Location = new System.Drawing.Point(472, 64);
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
			// btnNeuralSynapsesUpdate
			// 
			this.btnNeuralSynapsesUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSynapsesUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSynapsesUpdate.Location = new System.Drawing.Point(1120, 299);
			this.btnNeuralSynapsesUpdate.Name = "btnNeuralSynapsesUpdate";
			this.btnNeuralSynapsesUpdate.Size = new System.Drawing.Size(67, 35);
			this.btnNeuralSynapsesUpdate.TabIndex = 28;
			this.btnNeuralSynapsesUpdate.Text = "Update";
			this.btnNeuralSynapsesUpdate.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1224, 472);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "NAVY";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabNeural.ResumeLayout(false);
			this.tabNeural.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNeural)).EndInit();
			this.grpNeuralInterval.ResumeLayout(false);
			this.grpNeuralInterval.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numNeuralEpoch)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNeurons;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnFunction;
		private System.Windows.Forms.Button btnNeuralAddLayer;
		private System.Windows.Forms.Button btnNeuralRun;
		private System.Windows.Forms.Label lblNeuralExpected;
		private System.Windows.Forms.TextBox txtNeuralExpected;
		private System.Windows.Forms.Button btnNeuralDeleteLayer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnNeuralOutputSave;
		private System.Windows.Forms.Button btnNeuralExpectedLoad;
		private System.Windows.Forms.Button btnNeuralInputLoad;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label lblNeuralSynapses;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnNeuralSynapsesInit;
		private System.Windows.Forms.GroupBox grpNeuralInterval;
		private System.Windows.Forms.RadioButton radioNeuralIntervalBipolar;
		private System.Windows.Forms.RadioButton radioNeuralIntervalUnipolar;
		private System.Windows.Forms.NumericUpDown numNeuralEpoch;
		private System.Windows.Forms.Label lblNeuralEpoch;
		private System.Windows.Forms.Button btnNeuralSynapsesUpdate;
	}
}

