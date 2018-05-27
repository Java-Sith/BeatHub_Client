using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdysseyInterface
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnLog_Click(object sender, EventArgs e)
		{
			string user, pass;
			user = txtUser.Text;
			pass = txtPassword.Text;
			if (user == "Luis Daniel Prieto" && pass == "2016072504")
			{
				this.Hide();
				Form2 f2 = new Form2();
				f2.ShowDialog();
			}
			else
			{
				MessageBox.Show("Retry");
			}
		}
	}
}
