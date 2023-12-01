namespace WinFormsApp1.control
{
	partial class UserSetting
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			userName = new Label();
			phone = new Label();
			address = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(93, 65);
			label1.Name = "label1";
			label1.Size = new Size(117, 38);
			label1.TabIndex = 0;
			label1.Text = "Name : ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label2.Location = new Point(93, 120);
			label2.Name = "label2";
			label2.Size = new Size(119, 38);
			label2.TabIndex = 1;
			label2.Text = "Phone : ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(93, 179);
			label3.Name = "label3";
			label3.Size = new Size(140, 38);
			label3.TabIndex = 2;
			label3.Text = "Address : ";
			// 
			// userName
			// 
			userName.AutoSize = true;
			userName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			userName.Location = new Point(240, 65);
			userName.Name = "userName";
			userName.Size = new Size(95, 38);
			userName.TabIndex = 3;
			userName.Text = "label4";
			// 
			// phone
			// 
			phone.AutoSize = true;
			phone.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			phone.Location = new Point(242, 120);
			phone.Name = "phone";
			phone.Size = new Size(93, 38);
			phone.TabIndex = 4;
			phone.Text = "label5";
			// 
			// address
			// 
			address.AutoSize = true;
			address.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			address.Location = new Point(242, 179);
			address.Name = "address";
			address.Size = new Size(94, 38);
			address.TabIndex = 5;
			address.Text = "label6";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(235, 81, 45);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.FromArgb(241, 219, 212);
			button1.Location = new Point(93, 275);
			button1.Name = "button1";
			button1.Size = new Size(119, 37);
			button1.TabIndex = 6;
			button1.Text = "Log out";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// UserSetting
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			Controls.Add(button1);
			Controls.Add(address);
			Controls.Add(phone);
			Controls.Add(userName);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "UserSetting";
			Size = new Size(629, 375);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label userName;
		private Label phone;
		private Label address;
		private Button button1;
	}
}
