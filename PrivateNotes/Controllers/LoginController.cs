using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Controllers {
	class LoginController {

		public static void Login(LoginCredentials loginCredentials) {

			if (loginCredentials.isValid()) {
				// close login page
				// start notes page
			} else {
				// show invalid password message
			}
		}
	}
}
