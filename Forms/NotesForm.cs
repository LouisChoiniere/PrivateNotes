using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrivateNotes.Forms {
    public partial class NotesForm : Form {
        public NotesForm() {
            InitializeComponent();

            TextBox n = note;
            Console.WriteLine(n.Text.ToString());
            Console.WriteLine("yeet");
        }

        private void NotesForm_Load(object sender, EventArgs e) {
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
