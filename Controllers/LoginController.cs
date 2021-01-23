using PrivateNotes.Forms;
using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PrivateNotes.Controllers {
	class LoginController {

		public static bool Login(LoginCredentials loginCredentials, Form form) {

			if (loginCredentials.isValid()) {
				// start notes page
				form.Hide();
				var nt = new NotesForm();
				nt.ShowDialog();
				form.Close();
				return true;
			}
			return false;
		}
	}
}
