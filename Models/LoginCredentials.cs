using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Models {
	class LoginCredentials {

		private string username { get; }
		private string password { get; }

		public LoginCredentials(string username, string password) {
			this.username = username;
			this.password = password;
		}

		public Boolean isValid() {

			// check credentials
			return true;
		}
	}
}
