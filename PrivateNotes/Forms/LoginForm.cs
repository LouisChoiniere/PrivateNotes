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
			String username = usernameInput.Text;
			String password = passwordInput.Text;
			Button login = loginButton;
			Button createAccount = createAccoutButton;
		}
    }
}
