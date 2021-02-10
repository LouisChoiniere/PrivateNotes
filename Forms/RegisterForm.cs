using PrivateNotes.Controllers;
using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrivateNotes.Forms {
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e) {
            if (passwordInput.Text.Equals(confirmPasswordInput.Text)){
                LoginCredentials credentials = new LoginCredentials(usernameInput.Text, passwordInput.Text);
                if (LoginController.Register(credentials)){

                    registerButton.Enabled = false;
                    this.Hide();
                    var login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else {
                    // show user that someone already has an account named that way
                }
            }
            else
                incorrect.Show();
        }

    }
}
