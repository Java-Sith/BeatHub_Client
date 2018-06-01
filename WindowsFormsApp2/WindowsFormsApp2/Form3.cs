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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
		string user, pass;
		//Logs in the user
		private void button1_Click(object sender, EventArgs e)
		{
			user = textBox1.Text;
			pass = textBox2.Text;
			if (user == "Luis Daniel Prieto" && pass == "2016072504")
			{
				this.Hide();
				Form1 f1 = new Form1();
				f1.ShowDialog();
			}
		}
	}
}
