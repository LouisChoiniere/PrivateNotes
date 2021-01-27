
namespace PrivateNotes {
	partial class Login {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.loginButton = new System.Windows.Forms.Button();
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.createAccoutButton = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.passwordInput = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginButton.Location = new System.Drawing.Point(164, 290);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(200, 31);
			this.loginButton.TabIndex = 3;
			this.loginButton.Text = "Log In!";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// usernameInput
			// 
			this.usernameInput.Location = new System.Drawing.Point(240, 141);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(195, 23);
			this.usernameInput.TabIndex = 1;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.passwordLabel.Location = new System.Drawing.Point(101, 191);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(104, 23);
			this.passwordLabel.TabIndex = 3;
			this.passwordLabel.Text = "Password:";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.usernameLabel.Location = new System.Drawing.Point(100, 141);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(105, 23);
			this.usernameLabel.TabIndex = 2;
			this.usernameLabel.Text = "Username:";
			// 
			// createAccoutButton
			// 
			this.createAccoutButton.Location = new System.Drawing.Point(196, 366);
			this.createAccoutButton.Name = "createAccoutButton";
			this.createAccoutButton.Size = new System.Drawing.Size(128, 24);
			this.createAccoutButton.TabIndex = 69;
			this.createAccoutButton.Text = "Create Account";
			this.createAccoutButton.UseVisualStyleBackColor = true;
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.title.Location = new System.Drawing.Point(65, 25);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(406, 36);
			this.title.TabIndex = 0;
			this.title.Text = "Welcome To Private Notes!!";
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(240, 191);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '*';
			this.passwordInput.Size = new System.Drawing.Size(195, 23);
			this.passwordInput.TabIndex = 70;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 498);
			this.Controls.Add(this.title);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.usernameInput);
			this.Controls.Add(this.createAccoutButton);
			this.Controls.Add(this.loginButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button createAccoutButton;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MaskedTextBox passwordInput;
    }
}

