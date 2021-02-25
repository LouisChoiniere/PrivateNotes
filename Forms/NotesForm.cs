using PrivateNotes.Controllers;
using PrivateNotes.Models;
using PrivateNotes.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PrivateNotes.Forms {
    public partial class NotesForm : Form {

        NoteController nc = new NoteController();
        public NotesForm() {
            InitializeComponent();

            nc.ini(notesPanel, addNoteButton, mainPanel);
            nc.GetNotes();
            FormClosing += NotesForm_FormClosing;
        }

        private void NotesForm_Load(object sender, EventArgs e) {
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void addNoteButton_Click(object sender, EventArgs e) {
            nc.AddNewNote();
            
        }
        private void NotesForm_FormClosing(object sender, FormClosingEventArgs e) {
            LoginCredentials loginCredentials = LoginController.GetLoginCredentials();
            
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + loginCredentials.Username);
            FileInfo[] Files = d.GetFiles("*.txt");
            //Getting Text files
            foreach (FileInfo file in Files) {
                Encryption.FileEncrypt(
                file.FullName,
                loginCredentials.password
                );
            }
        }
    }
}
