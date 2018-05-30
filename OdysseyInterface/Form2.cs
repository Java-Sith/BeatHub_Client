//Libraries
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
using NAudio.Wave;

namespace OdysseyInterface
{
	public partial class Form2 : Form
	{
		//Initializes the interface with variables
		public Form2()
		{
			InitializeComponent();
		}
		OpenFileDialog ofd = new OpenFileDialog();
		private NAudio.Wave.BlockAlignReductionStream wave = null;
		private NAudio.Wave.DirectSoundOut output = null;
		//Add Song function
		private void AddSong_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				TagLib.File f = TagLib.File.Create(ofd.FileName);
				txtAlbum.Text = f.Tag.Album;
				txtAuthor.Text = f.Tag.FirstPerformer;
				txtTitle.Text = f.Tag.Title;
			}
		}
		//Play Song function
		private void plSong_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(ofd.FileName));
			wave = new NAudio.Wave.BlockAlignReductionStream(pcm);
			output = new NAudio.Wave.DirectSoundOut();
			output.Init(wave);
			output.Play();
			starQ.Enabled = true;
		}
		//Pause Song function
		private void psSong_Click(object sender, EventArgs e)
		{
			{
				if (output != null)
				{
					if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
					{
						output.Pause();
					}
					else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
					{
						output.Play();
					}
				}
			}
		}
		//Qualifies a song with "stars"
		private void starQ_Click(object sender, EventArgs e)
		{
			string star = txtStar.Text;
			if (star == "5")
			{
				MessageBox.Show("Award winning song");
			}
			if (star == "4")
			{
				MessageBox.Show("Good song");
			}
			if (star == "3")
			{
				MessageBox.Show("Nice song");
			}
			if (star == "2")
			{
				MessageBox.Show("Bad song");
			}
			if (star == "1")
			{
				MessageBox.Show("What is this even doing here?");
			}
		}
		//End Song function
		private void enSong_Click(object sender, EventArgs e)
		{
			if (output != null)
			{
				if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
				{
					output.Stop();
					output.Dispose();
					output = null;
				}
			}
			if (wave != null)
			{
				wave.Dispose();
				wave = null;
			}
		}
	}
}

