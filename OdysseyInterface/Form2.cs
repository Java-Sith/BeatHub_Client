using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OdysseyInterface
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void AddSong_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				string fullpath = ofd.FileName;
				TagLib.File f = TagLib.File.Create(fullpath);
				txtAlbum.Text = f.Tag.Album;
				txtAuthor.Text = f.Tag.FirstPerformer;
				txtTitle.Text = f.Tag.Title;
				byte[] bytes = File.ReadAllBytes(fullpath);
				txtLyrics.Text = String.Join("separator", bytes);
			}
		}
	}
}
