using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
		//Initializes the interface with variables
		public Form1()
        {
            InitializeComponent();
        }
		//Variables
		OpenFileDialog ofd = new OpenFileDialog();
		private NAudio.Wave.BlockAlignReductionStream wave = null;
		private NAudio.Wave.DirectSoundOut output = null;
		System.Timers.Timer timer = new System.Timers.Timer();
		//Minimizes the window
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
		//Sets the window's size
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
		//Closes the window
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
		//Adds a song and it's metadata
		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				TagLib.File f = TagLib.File.Create(ofd.FileName);
				var album = f.Tag.Album;
				var artist = f.Tag.FirstPerformer;
				var title = f.Tag.Title;
			}
		}
		//Plays and pauses the song
		private void bunifuImageButton4_Click(object sender, EventArgs e)
		{
			if (output == null)
			{
				NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(ofd.FileName));
				wave = new NAudio.Wave.BlockAlignReductionStream(pcm);
				output = new NAudio.Wave.DirectSoundOut();
				output.Init(wave);
				output.Play();
				bunifuSlider1.MaximumValue = (int)wave.Length;
			}
			else if (output != null)
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
		public void OnTime(object sender, System.Timers.ElapsedEventArgs e)
		{
			
		}
		//Changes to edit window
		private void bunifuImageButton7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form2 f2 = new Form2();
			f2.ShowDialog();
		}
		//Controls the audio streaming
		private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
		{
			if (output != null)
			{
				bunifuSlider1.Value = (int)wave.Position;
			}
			else
			{
				return;
			}
		}
		//Controls the audio streaming
		private void bunifuImageButton5_Click(object sender, EventArgs e)
		{
			if (output != null)
			{
				wave.Position -= wave.Seek(-5);
			}
			else
			{
				return;
			}
		}
		//Controls the audio streaming
		private void bunifuImageButton6_Click(object sender, EventArgs e)
		{
			if (output != null)
			{
				wave.Position += wave.SetPosition(5.0);
			}
			else
			{
				return;
			}
		}
		//Controls the audio volume
		private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
		{
			if (output != null)
			{
				output.Volume = bunifuSlider2.Value;
			}
			else
			{
				return;
			}
		}
	} 
}
