namespace OdysseyInterface
{
	partial class Form2
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
			this.AddSong = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.Author = new System.Windows.Forms.Label();
			this.Album = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtAlbum = new System.Windows.Forms.TextBox();
			this.SendSong = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLyrics = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// AddSong
			// 
			this.AddSong.Location = new System.Drawing.Point(83, 34);
			this.AddSong.Name = "AddSong";
			this.AddSong.Size = new System.Drawing.Size(134, 83);
			this.AddSong.TabIndex = 0;
			this.AddSong.Text = "Add Song";
			this.AddSong.UseVisualStyleBackColor = true;
			this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(632, 88);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(27, 13);
			this.Title.TabIndex = 2;
			this.Title.Text = "Title";
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Location = new System.Drawing.Point(635, 157);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(38, 13);
			this.Author.TabIndex = 3;
			this.Author.Text = "Author";
			// 
			// Album
			// 
			this.Album.AutoSize = true;
			this.Album.Location = new System.Drawing.Point(635, 227);
			this.Album.Name = "Album";
			this.Album.Size = new System.Drawing.Size(36, 13);
			this.Album.TabIndex = 4;
			this.Album.Text = "Album";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(401, 88);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(154, 20);
			this.txtTitle.TabIndex = 5;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(401, 154);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(154, 20);
			this.txtAuthor.TabIndex = 6;
			// 
			// txtAlbum
			// 
			this.txtAlbum.Location = new System.Drawing.Point(401, 224);
			this.txtAlbum.Name = "txtAlbum";
			this.txtAlbum.Size = new System.Drawing.Size(154, 20);
			this.txtAlbum.TabIndex = 7;
			// 
			// SendSong
			// 
			this.SendSong.Location = new System.Drawing.Point(83, 169);
			this.SendSong.Name = "SendSong";
			this.SendSong.Size = new System.Drawing.Size(134, 95);
			this.SendSong.TabIndex = 8;
			this.SendSong.Text = "Send Song";
			this.SendSong.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(635, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Lyrics";
			// 
			// txtLyrics
			// 
			this.txtLyrics.Location = new System.Drawing.Point(401, 294);
			this.txtLyrics.Name = "txtLyrics";
			this.txtLyrics.Size = new System.Drawing.Size(154, 20);
			this.txtLyrics.TabIndex = 10;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtLyrics);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SendSong);
			this.Controls.Add(this.txtAlbum);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.Album);
			this.Controls.Add(this.Author);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.AddSong);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddSong;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label Author;
		private System.Windows.Forms.Label Album;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtAlbum;
		private System.Windows.Forms.Button SendSong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLyrics;
	}
}