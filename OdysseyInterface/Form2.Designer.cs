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
			this.plSong = new System.Windows.Forms.Button();
			this.BubbleSort = new System.Windows.Forms.Button();
			this.QuickSort = new System.Windows.Forms.Button();
			this.RadixSort = new System.Windows.Forms.Button();
			this.srcAlbum = new System.Windows.Forms.TextBox();
			this.srcAuthor = new System.Windows.Forms.TextBox();
			this.srcName = new System.Windows.Forms.TextBox();
			this.SplayTree = new System.Windows.Forms.Button();
			this.AVLTree = new System.Windows.Forms.Button();
			this.BTree = new System.Windows.Forms.Button();
			this.Friend = new System.Windows.Forms.Label();
			this.Song = new System.Windows.Forms.Label();
			this.txtFriend = new System.Windows.Forms.TextBox();
			this.txtrSong = new System.Windows.Forms.TextBox();
			this.btnRec = new System.Windows.Forms.Button();
			this.starQ = new System.Windows.Forms.Button();
			this.txtStar = new System.Windows.Forms.TextBox();
			this.star = new System.Windows.Forms.Label();
			this.psSong = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddSong
			// 
			this.AddSong.Location = new System.Drawing.Point(12, 27);
			this.AddSong.Name = "AddSong";
			this.AddSong.Size = new System.Drawing.Size(77, 43);
			this.AddSong.TabIndex = 0;
			this.AddSong.Text = "Add Song";
			this.AddSong.UseVisualStyleBackColor = true;
			this.AddSong.Click += new System.EventHandler(this.AddSong_Click);
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(156, 112);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(27, 13);
			this.Title.TabIndex = 2;
			this.Title.Text = "Title";
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Location = new System.Drawing.Point(156, 157);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(38, 13);
			this.Author.TabIndex = 3;
			this.Author.Text = "Author";
			// 
			// Album
			// 
			this.Album.AutoSize = true;
			this.Album.Location = new System.Drawing.Point(156, 211);
			this.Album.Name = "Album";
			this.Album.Size = new System.Drawing.Size(36, 13);
			this.Album.TabIndex = 4;
			this.Album.Text = "Album";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(12, 105);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(118, 20);
			this.txtTitle.TabIndex = 5;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(12, 150);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(118, 20);
			this.txtAuthor.TabIndex = 6;
			// 
			// txtAlbum
			// 
			this.txtAlbum.Location = new System.Drawing.Point(12, 204);
			this.txtAlbum.Name = "txtAlbum";
			this.txtAlbum.Size = new System.Drawing.Size(118, 20);
			this.txtAlbum.TabIndex = 7;
			// 
			// plSong
			// 
			this.plSong.Location = new System.Drawing.Point(38, 282);
			this.plSong.Name = "plSong";
			this.plSong.Size = new System.Drawing.Size(92, 40);
			this.plSong.TabIndex = 8;
			this.plSong.Text = "Play Song";
			this.plSong.UseVisualStyleBackColor = true;
			this.plSong.Click += new System.EventHandler(this.plSong_Click);
			// 
			// BubbleSort
			// 
			this.BubbleSort.Location = new System.Drawing.Point(627, 28);
			this.BubbleSort.Name = "BubbleSort";
			this.BubbleSort.Size = new System.Drawing.Size(95, 42);
			this.BubbleSort.TabIndex = 9;
			this.BubbleSort.Text = "Sort by Album";
			this.BubbleSort.UseVisualStyleBackColor = true;
			// 
			// QuickSort
			// 
			this.QuickSort.Location = new System.Drawing.Point(627, 95);
			this.QuickSort.Name = "QuickSort";
			this.QuickSort.Size = new System.Drawing.Size(96, 39);
			this.QuickSort.TabIndex = 10;
			this.QuickSort.Text = "Sort by Name";
			this.QuickSort.UseVisualStyleBackColor = true;
			// 
			// RadixSort
			// 
			this.RadixSort.Location = new System.Drawing.Point(628, 157);
			this.RadixSort.Name = "RadixSort";
			this.RadixSort.Size = new System.Drawing.Size(95, 40);
			this.RadixSort.TabIndex = 11;
			this.RadixSort.Text = "Sort by Author";
			this.RadixSort.UseVisualStyleBackColor = true;
			// 
			// srcAlbum
			// 
			this.srcAlbum.Location = new System.Drawing.Point(476, 232);
			this.srcAlbum.Name = "srcAlbum";
			this.srcAlbum.Size = new System.Drawing.Size(125, 20);
			this.srcAlbum.TabIndex = 12;
			// 
			// srcAuthor
			// 
			this.srcAuthor.Location = new System.Drawing.Point(476, 290);
			this.srcAuthor.Name = "srcAuthor";
			this.srcAuthor.Size = new System.Drawing.Size(125, 20);
			this.srcAuthor.TabIndex = 13;
			// 
			// srcName
			// 
			this.srcName.Location = new System.Drawing.Point(476, 361);
			this.srcName.Name = "srcName";
			this.srcName.Size = new System.Drawing.Size(125, 20);
			this.srcName.TabIndex = 14;
			// 
			// SplayTree
			// 
			this.SplayTree.Location = new System.Drawing.Point(629, 220);
			this.SplayTree.Name = "SplayTree";
			this.SplayTree.Size = new System.Drawing.Size(94, 42);
			this.SplayTree.TabIndex = 15;
			this.SplayTree.Text = "Search Album";
			this.SplayTree.UseVisualStyleBackColor = true;
			// 
			// AVLTree
			// 
			this.AVLTree.Location = new System.Drawing.Point(629, 276);
			this.AVLTree.Name = "AVLTree";
			this.AVLTree.Size = new System.Drawing.Size(93, 46);
			this.AVLTree.TabIndex = 16;
			this.AVLTree.Text = "Search Author";
			this.AVLTree.UseVisualStyleBackColor = true;
			// 
			// BTree
			// 
			this.BTree.Location = new System.Drawing.Point(629, 348);
			this.BTree.Name = "BTree";
			this.BTree.Size = new System.Drawing.Size(93, 44);
			this.BTree.TabIndex = 17;
			this.BTree.Text = "Search Name";
			this.BTree.UseVisualStyleBackColor = true;
			// 
			// Friend
			// 
			this.Friend.AutoSize = true;
			this.Friend.Location = new System.Drawing.Point(260, 95);
			this.Friend.Name = "Friend";
			this.Friend.Size = new System.Drawing.Size(36, 13);
			this.Friend.TabIndex = 18;
			this.Friend.Text = "Friend";
			// 
			// Song
			// 
			this.Song.AutoSize = true;
			this.Song.Location = new System.Drawing.Point(260, 137);
			this.Song.Name = "Song";
			this.Song.Size = new System.Drawing.Size(32, 13);
			this.Song.TabIndex = 19;
			this.Song.Text = "Song";
			// 
			// txtFriend
			// 
			this.txtFriend.Location = new System.Drawing.Point(314, 92);
			this.txtFriend.Name = "txtFriend";
			this.txtFriend.Size = new System.Drawing.Size(140, 20);
			this.txtFriend.TabIndex = 20;
			// 
			// txtrSong
			// 
			this.txtrSong.Location = new System.Drawing.Point(314, 134);
			this.txtrSong.Name = "txtrSong";
			this.txtrSong.Size = new System.Drawing.Size(140, 20);
			this.txtrSong.TabIndex = 21;
			// 
			// btnRec
			// 
			this.btnRec.Location = new System.Drawing.Point(476, 92);
			this.btnRec.Name = "btnRec";
			this.btnRec.Size = new System.Drawing.Size(87, 62);
			this.btnRec.TabIndex = 22;
			this.btnRec.Text = "Recommend";
			this.btnRec.UseVisualStyleBackColor = true;
			// 
			// starQ
			// 
			this.starQ.Location = new System.Drawing.Point(330, 276);
			this.starQ.Name = "starQ";
			this.starQ.Size = new System.Drawing.Size(75, 46);
			this.starQ.TabIndex = 23;
			this.starQ.Text = "Qualify";
			this.starQ.UseVisualStyleBackColor = true;
			this.starQ.Click += new System.EventHandler(this.starQ_Click);
			// 
			// txtStar
			// 
			this.txtStar.Location = new System.Drawing.Point(263, 290);
			this.txtStar.Name = "txtStar";
			this.txtStar.Size = new System.Drawing.Size(51, 20);
			this.txtStar.TabIndex = 24;
			// 
			// star
			// 
			this.star.AutoSize = true;
			this.star.Location = new System.Drawing.Point(210, 293);
			this.star.Name = "star";
			this.star.Size = new System.Drawing.Size(31, 13);
			this.star.TabIndex = 25;
			this.star.Text = "Stars";
			// 
			// psSong
			// 
			this.psSong.Location = new System.Drawing.Point(38, 348);
			this.psSong.Name = "psSong";
			this.psSong.Size = new System.Drawing.Size(92, 44);
			this.psSong.TabIndex = 26;
			this.psSong.Text = "Pause Song";
			this.psSong.UseVisualStyleBackColor = true;
			this.psSong.Click += new System.EventHandler(this.psSong_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.psSong);
			this.Controls.Add(this.star);
			this.Controls.Add(this.txtStar);
			this.Controls.Add(this.starQ);
			this.Controls.Add(this.btnRec);
			this.Controls.Add(this.txtrSong);
			this.Controls.Add(this.txtFriend);
			this.Controls.Add(this.Song);
			this.Controls.Add(this.Friend);
			this.Controls.Add(this.BTree);
			this.Controls.Add(this.AVLTree);
			this.Controls.Add(this.SplayTree);
			this.Controls.Add(this.srcName);
			this.Controls.Add(this.srcAuthor);
			this.Controls.Add(this.srcAlbum);
			this.Controls.Add(this.RadixSort);
			this.Controls.Add(this.QuickSort);
			this.Controls.Add(this.BubbleSort);
			this.Controls.Add(this.plSong);
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
		private System.Windows.Forms.Button plSong;
		private System.Windows.Forms.Button BubbleSort;
		private System.Windows.Forms.Button QuickSort;
		private System.Windows.Forms.Button RadixSort;
		private System.Windows.Forms.TextBox srcAlbum;
		private System.Windows.Forms.TextBox srcAuthor;
		private System.Windows.Forms.TextBox srcName;
		private System.Windows.Forms.Button SplayTree;
		private System.Windows.Forms.Button AVLTree;
		private System.Windows.Forms.Button BTree;
		private System.Windows.Forms.Label Friend;
		private System.Windows.Forms.Label Song;
		private System.Windows.Forms.TextBox txtFriend;
		private System.Windows.Forms.TextBox txtrSong;
		private System.Windows.Forms.Button btnRec;
		private System.Windows.Forms.Button starQ;
		private System.Windows.Forms.TextBox txtStar;
		private System.Windows.Forms.Label star;
		private System.Windows.Forms.Button psSong;
	}
}