using PrivateNotes.Forms;
using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PrivateNotes.Controllers {
	class LoginController {

		public static bool Login(LoginCredentials loginCredentials, Form form) {

			if (loginCredentials.IsValid()) {
				// start notes page
				form.Hide();
				var nt = new NotesForm();
				nt.ShowDialog();
				form.Close();
				return true;
			}
			return false;
		}

		public static byte[] getHash(string username) {
			// TODO: return different hash depending on the username
			try {
				return File.ReadAllBytes("credentials.dat");
			} catch (Exception e) {
				Console.WriteLine(e.ToString());
				return null;
			}
		}
	}
}
