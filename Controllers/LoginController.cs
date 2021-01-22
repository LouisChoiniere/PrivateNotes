using PrivateNotes.Forms;
using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Controllers {
	class LoginController {

		public static bool Login(LoginCredentials loginCredentials) {

			if (loginCredentials.isValid()) {
				// start notes page
				var nt = new NotesForm();
				nt.Show();
				return true;
			}
			return false;
		}
	}
}
