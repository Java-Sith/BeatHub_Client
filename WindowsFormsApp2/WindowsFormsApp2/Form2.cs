using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form2 : Form
	{
		OpenFileDialog ofd = new OpenFileDialog();
		public Form2()
		{
			InitializeComponent();
		}
		//Changes a song's metadata
		private void button1_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				TagLib.File f = TagLib.File.Create(ofd.FileName);
				f.Tag.Album = textBox1.Text;
				f.Tag.Performers = null;
				f.Tag.Performers = new[] { textBox2.Text };
				f.Tag.Title = textBox3.Text;
				f.Save();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.ShowDialog();
		}
	}
}
