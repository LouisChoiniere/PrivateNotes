using PrivateNotes.Controllers;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
			byte[] storedBytes = LoginController.GetHash(Convert.ToBase64String(Sha256_hash(username)));

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

		public byte[] GetBytes() {
			byte[] user = Sha256_hash(username);
			byte[] salt = GenerateSalt(128);
			byte[] pass = Hash(password, salt);

			byte[] bytes = new byte[288];


			return user.Concat(salt).Concat(pass).ToArray();
		}

		private static byte[] Hash(string password, byte[] salt) {
			using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA512)) {
				return pbkdf2.GetBytes(128);
			}
		}

		private static byte[] Sha256_hash(string value) {
			using (SHA256 hash = SHA256Managed.Create()) {
				Encoding enc = Encoding.UTF8;
				return hash.ComputeHash(enc.GetBytes(value));
			}
		}

		private static byte[] GenerateSalt(int length) {
			byte[] salt = new byte[length];
			using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
				rngCsp.GetBytes(salt);

			return salt;
		}
	}
}
