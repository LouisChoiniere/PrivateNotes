
namespace PrivateNotes.Forms {
    partial class RegisterForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.incorrect = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.MaskedTextBox();
            this.usernameInputRegister = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordInput = new System.Windows.Forms.MaskedTextBox();
            this.incorrect2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.incorrectUsername2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incorrect
            // 
            this.incorrect.AutoSize = true;
            this.incorrect.ForeColor = System.Drawing.Color.Red;
            this.incorrect.Location = new System.Drawing.Point(199, 263);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(137, 15);
            this.incorrect.TabIndex = 108;
            this.incorrect.Text = "Passwords do not match";
            this.incorrect.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(111, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(298, 36);
            this.title.TabIndex = 101;
            this.title.Text = "Register an Account";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(119, 168);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 23);
            this.passwordLabel.TabIndex = 106;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(118, 118);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 23);
            this.usernameLabel.TabIndex = 107;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(258, 168);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(195, 23);
            this.passwordInput.TabIndex = 2;
            // 
            // usernameInputRegister
            // 
            this.usernameInputRegister.Location = new System.Drawing.Point(258, 118);
            this.usernameInputRegister.Name = "usernameInputRegister";
            this.usernameInputRegister.Size = new System.Drawing.Size(195, 23);
            this.usernameInputRegister.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerButton.Location = new System.Drawing.Point(165, 329);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 31);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register!";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 110;
            this.label1.Text = "Confirm Password:";
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(258, 215);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.PasswordChar = '*';
            this.confirmPasswordInput.Size = new System.Drawing.Size(195, 23);
            this.confirmPasswordInput.TabIndex = 3;
            // 
            // incorrect2
            // 
            this.incorrect2.AutoSize = true;
            this.incorrect2.ForeColor = System.Drawing.Color.Red;
            this.incorrect2.Location = new System.Drawing.Point(199, 291);
            this.incorrect2.Name = "incorrect2";
            this.incorrect2.Size = new System.Drawing.Size(133, 15);
            this.incorrect2.TabIndex = 111;
            this.incorrect2.Text = "Username already exists";
            this.incorrect2.Visible = false;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(327, 374);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 15);
            this.output.TabIndex = 112;
            // 
            // incorrectUsername2
            // 
            this.incorrectUsername2.AutoSize = true;
            this.incorrectUsername2.ForeColor = System.Drawing.Color.Red;
            this.incorrectUsername2.Location = new System.Drawing.Point(206, 291);
            this.incorrectUsername2.Name = "incorrectUsername2";
            this.incorrectUsername2.Size = new System.Drawing.Size(121, 15);
            this.incorrectUsername2.TabIndex = 113;
            this.incorrectUsername2.Text = "Username is incorrect";
            this.incorrectUsername2.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 417);
            this.Controls.Add(this.incorrectUsername2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.incorrect2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.incorrect);
            this.Controls.Add(this.title);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInputRegister);
            this.Controls.Add(this.registerButton);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incorrect;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.MaskedTextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInputRegister;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox confirmPasswordInput;
        private System.Windows.Forms.Label incorrect2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label incorrectUsername2;
    }
}