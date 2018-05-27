 namespace OdysseyInterface
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.Username = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.Label();
			this.BtnLog = new System.Windows.Forms.Button();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Username
			// 
			this.Username.AutoSize = true;
			this.Username.Location = new System.Drawing.Point(182, 61);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(55, 13);
			this.Username.TabIndex = 0;
			this.Username.Text = "Username";
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Location = new System.Drawing.Point(185, 180);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(53, 13);
			this.Password.TabIndex = 1;
			this.Password.Text = "Password";
			// 
			// BtnLog
			// 
			this.BtnLog.Location = new System.Drawing.Point(319, 327);
			this.BtnLog.Name = "BtnLog";
			this.BtnLog.Size = new System.Drawing.Size(155, 77);
			this.BtnLog.TabIndex = 2;
			this.BtnLog.Text = "Login";
			this.BtnLog.UseVisualStyleBackColor = true;
			this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(418, 61);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(145, 20);
			this.txtUser.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(418, 172);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(145, 20);
			this.txtPassword.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.BtnLog);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.Username);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.Button BtnLog;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPassword;
	}
}

