namespace WinFormsApp1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			userName = new TextBox();
			panel1 = new Panel();
			panel2 = new Panel();
			password = new TextBox();
			pictureBox3 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(110, 41);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(190, 162);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(72, 230);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(32, 30);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			pictureBox2.Click += pictureBox2_Click;
			// 
			// userName
			// 
			userName.BackColor = Color.FromArgb(31, 37, 47);
			userName.BorderStyle = BorderStyle.None;
			userName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			userName.ForeColor = Color.FromArgb(252, 255, 251);
			userName.Location = new Point(110, 230);
			userName.Name = "userName";
			userName.Size = new Size(233, 27);
			userName.TabIndex = 2;
			userName.TextChanged += textBox1_TextChanged;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(252, 255, 251);
			panel1.Location = new Point(72, 266);
			panel1.Name = "panel1";
			panel1.Size = new Size(271, 2);
			panel1.TabIndex = 3;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(252, 255, 251);
			panel2.Location = new Point(72, 333);
			panel2.Name = "panel2";
			panel2.Size = new Size(271, 2);
			panel2.TabIndex = 6;
			// 
			// password
			// 
			password.BackColor = Color.FromArgb(31, 37, 47);
			password.BorderStyle = BorderStyle.None;
			password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			password.ForeColor = Color.FromArgb(252, 255, 251);
			password.Location = new Point(110, 297);
			password.Name = "password";
			password.Size = new Size(233, 27);
			password.TabIndex = 5;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(72, 297);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(32, 30);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 4;
			pictureBox3.TabStop = false;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(66, 174, 206);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.FromArgb(0, 55, 85);
			button1.Location = new Point(72, 370);
			button1.Name = "button1";
			button1.Size = new Size(120, 43);
			button1.TabIndex = 7;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.Transparent;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.FromArgb(208, 211, 220);
			button2.Location = new Point(223, 370);
			button2.Name = "button2";
			button2.Size = new Size(120, 43);
			button2.TabIndex = 8;
			button2.Text = "Register";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(31, 37, 47);
			ClientSize = new Size(418, 459);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(panel2);
			Controls.Add(password);
			Controls.Add(pictureBox3);
			Controls.Add(panel1);
			Controls.Add(userName);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private TextBox userName;
		private Panel panel1;
		private Panel panel2;
		private TextBox password;
		private PictureBox pictureBox3;
		private Button button1;
		private Button button2;
	}
}
