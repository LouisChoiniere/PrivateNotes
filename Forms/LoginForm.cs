﻿using PrivateNotes.Controllers;
using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateNotes {
	public partial class Login : Form {
		public Login() {
			InitializeComponent();
		}
		// yeet test
        private void Form1_Load(object sender, EventArgs e) {
			
			Button login = loginButton;
			Button createAccount = createAccoutButton;
		}

        private void loginButton_Click(object sender, EventArgs e) {
			String username = usernameInput.Text;
			String password = passwordInput.Text;
		}

		private void loginButton_Click(object sender, EventArgs e) {
			LoginCredentials loginCredentials = new LoginCredentials(usernameInput.Text, passwordInput.Text);

			LoginController.Login(loginCredentials);
		}
	}
}
