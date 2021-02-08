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

		public static Boolean Register(LoginCredentials loginCredentials) {
			byte[] bytes = loginCredentials.GetBytes();

			using (var stream = new FileStream("credentials.dat", FileMode.Append)) {
				stream.Write(bytes, 0, bytes.Length);
			}

			return true;
		}

		public static byte[] GetHash(string username) {

			// all bytes stored in file
			byte[] rawBytes;

			// dictionary of users and hash
			Dictionary<string, byte[]> credentials = new Dictionary<string, byte[]>();

			// read the file
			try {
				rawBytes = File.ReadAllBytes("credentials.dat");
			} catch (Exception e) {
				Console.WriteLine(e.ToString());
				return null;
			}

			// for each user add it to the dictionary
			for (int i = 0; i < rawBytes.Length / 288; i++) {
				int lowerIndex = 288 * i;
				byte[] user = rawBytes[lowerIndex..(lowerIndex + 288)];
				credentials.Add(Convert.ToBase64String(user[0..32]), user[32..288]);
			}

			// return specific user
			return credentials[username];
		}
	}
}
