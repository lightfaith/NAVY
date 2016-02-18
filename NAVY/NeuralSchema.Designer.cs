namespace NAVY
{
	partial class NeuralSchema
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
			this.btnNeuralSchemaSave = new System.Windows.Forms.Button();
			this.picNeuralSchema = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.picNeuralSchema)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNeuralSchemaSave
			// 
			this.btnNeuralSchemaSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNeuralSchemaSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNeuralSchemaSave.Location = new System.Drawing.Point(1040, 12);
			this.btnNeuralSchemaSave.Name = "btnNeuralSchemaSave";
			this.btnNeuralSchemaSave.Size = new System.Drawing.Size(135, 30);
			this.btnNeuralSchemaSave.TabIndex = 0;
			this.btnNeuralSchemaSave.Text = "Save";
			this.btnNeuralSchemaSave.UseVisualStyleBackColor = true;
			this.btnNeuralSchemaSave.Click += new System.EventHandler(this.btnNeuralSchemaSave_Click);
			// 
			// picNeuralSchema
			// 
			this.picNeuralSchema.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picNeuralSchema.BackColor = System.Drawing.Color.Black;
			this.picNeuralSchema.Location = new System.Drawing.Point(12, 12);
			this.picNeuralSchema.MaximumSize = new System.Drawing.Size(1024, 768);
			this.picNeuralSchema.MinimumSize = new System.Drawing.Size(1024, 768);
			this.picNeuralSchema.Name = "picNeuralSchema";
			this.picNeuralSchema.Size = new System.Drawing.Size(1024, 768);
			this.picNeuralSchema.TabIndex = 1;
			this.picNeuralSchema.TabStop = false;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "neural.png";
			// 
			// NeuralSchema
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(1187, 792);
			this.Controls.Add(this.picNeuralSchema);
			this.Controls.Add(this.btnNeuralSchemaSave);
			this.ForeColor = System.Drawing.Color.Silver;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "NeuralSchema";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Schema";
			this.Load += new System.EventHandler(this.NeuralSchema_Load);
			((System.ComponentModel.ISupportInitialize)(this.picNeuralSchema)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNeuralSchemaSave;
		private System.Windows.Forms.PictureBox picNeuralSchema;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}