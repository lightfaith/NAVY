using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAVY
{
	public partial class NeuralSchema : Form
	{
		Bitmap b;
		public NeuralSchema(Bitmap b)
		{
			InitializeComponent();
			this.b = b;
		}

		private void NeuralSchema_Load(object sender, EventArgs e)
		{
			picNeuralSchema.Image = b;
		}

		private void btnNeuralSchemaSave_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				picNeuralSchema.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
		}
	}
}
