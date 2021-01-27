using PrivateNotes.Controllers;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace PrivateNotes.Models {
	class LoginCredentials {

		private string username;
		private string password;

		public LoginCredentials(string username, string password) {
			this.username = username;
			this.password = password;
		}

		public Boolean IsValid() {

			// Get the hash of the username
			byte[] storedBytes = LoginController.getHash(username);

			// Return if there is no hash for the specified user
			if (storedBytes is null)
				return false;

			// get the salt and hash
			byte[] storedSalt = storedBytes[0..128];
			byte[] storedHash = storedBytes[128..256];

			// hash the password with the salt
			byte[] hash = Hash(this.password, storedSalt);

			// return if the password is valid or not
			return storedHash.SequenceEqual(hash);
		}

		private static byte[] Hash(string password, byte[] salt) {
			using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA512)) {
				return pbkdf2.GetBytes(128);
			}
		}
	}
}
