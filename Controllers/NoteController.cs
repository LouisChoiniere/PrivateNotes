using PrivateNotes.Models;
using PrivateNotes.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrivateNotes.Controllers {
	class NoteController {

        FlowLayoutPanel navBar;
        Button addNoteButton;
        Panel mainPanel;
        Panel lastPanel;
        Note selectedNote;
        TextBox titleBox;
        TextBox descriptionBox;

        public void ini(FlowLayoutPanel navBar, Button addNoteButton, Panel mainPanel) {
            this.navBar = navBar;
            this.addNoteButton = addNoteButton;
            this.mainPanel = mainPanel;
            TextBox titleBox = new TextBox {
                Font = new Font("Arial", 14),
                Text = "",
                Size = new Size(358, 30),
                Location = new Point(86, 70),
                Name = "titleBox"
            };

            TextBox descriptionBox = new TextBox {
                Font = new Font("Arial", 10),
                Size = new Size(798, 439),
                Location = new Point(86, 127),
                Name = "descriptionBox",
                Multiline = true,
                AcceptsReturn = true
            };

            RadioButton aesBox = new RadioButton {
                Font = new Font("Segoe UI", 9),
                Name = "aesBox",
                Text = "AES - Rijndael",
                Location = new Point(792, 45)
            };

            RadioButton rijndaleBox = new RadioButton {
                Font = new Font("Segoe UI", 9),
                Name = "",
                Text = "",
                Location = new Point(792, 76)
            };

            Button saveButton = new Button {
                Font = new Font("Arial", 12),
                Text = "Save Button",
                Name = "saveButton",
                Location = new Point(632, 598),
                Size = new Size(252, 35)
            };
            saveButton.Click += saveButtonClick;

            this.titleBox = titleBox;
            this.descriptionBox = descriptionBox;

            mainPanel.Controls.Add(titleBox);
            mainPanel.Controls.Add(descriptionBox);
            mainPanel.Controls.Add(aesBox);
            mainPanel.Controls.Add(rijndaleBox);
            mainPanel.Controls.Add(saveButton);
        }

		public void AddNewNote() {
			// create the brand new note here
			Note note = new Note("New Note", "", DateTime.Today);
            selectedNote = note;

            // this label is the title of the ntoe
            Label titleLabel = new Label {
                Font = new Font("Arial", 12),
                Text = note.Title,
                Location = new Point(8, 15)
            };

            // this label is the date of the note (when it was created)
            Label dateLabel = new Label {
                Font = new Font("Arial", 9),
                Text = note.Date.ToString(),
                Location = new Point(8, 45)
            };

            // the notePanel that holds all the items
            Panel notePanel = new Panel {
                Size = new Size(255, 70)
            };
            notePanel.Name = "notePanel";
            notePanel.Controls.Add(titleLabel);
			notePanel.Controls.Add(dateLabel);
            
            notePanel.Click += panelClick;

			// add the panel to the nav bar 
			navBar.Controls.Add(notePanel);
			addNoteButton.Enabled = true;

            lastPanel = notePanel;
		}

        public void panelClick(object sender, EventArgs e) {
            Panel thisPanel = (Panel)sender;
            
        }

        public void saveButtonClick(object sender, EventArgs e) {
            LoginCredentials loginCredentials = LoginController.GetLoginCredentials();
            string path = Directory.GetCurrentDirectory() + "\\" + loginCredentials.Username + "\\" + lastPanel.Name + ".txt";

            selectedNote.Title = titleBox.Text;
            selectedNote.Text = descriptionBox.Text;

            lastPanel.Controls[0].Text = selectedNote.Title;

            byte[] title = new UTF8Encoding(true).GetBytes(titleBox.Text.ToString() + "\n");
            byte[] description = new UTF8Encoding(true).GetBytes(descriptionBox.Text.ToString());

            using(FileStream fs = File.Create(path)) {
                fs.Write(title);
                fs.Write(description);
            }
            
            Encryption.FileEncrypt(
                path,
                loginCredentials.password
            );
        }

        public void GetNotes() {
            LoginCredentials loggedUser = LoginController.GetLoginCredentials();
            List<Note> list = new List<Note>();
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + loggedUser.Username);
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files) {
                string yeet = File.ReadAllText(file.FullName);
                string title = "";
                string description = "";
                int count = 0;
                foreach (string line in yeet.Split("\n")) {
                    if (count == 0)
                        title = Regex.Replace(line, @"\t|\n|\r", "");
                    description += line;
                    count++;
                }
                // this label is the title of the ntoe
                Label titleLabel = new Label {
                    Font = new Font("Arial", 12),
                    Text = title,
                    Location = new Point(8, 15)
                };

                // this label is the date of the note (when it was created)
                Label dateLabel = new Label {
                    Font = new Font("Arial", 9),
                    Text = DateTime.Now.ToString(),
                    Location = new Point(8, 45)
                };

                // the notePanel that holds all the items
                Panel notePanel = new Panel {
                    Size = new Size(255, 70)
                };
                notePanel.Name = "notePanel";
                notePanel.Controls.Add(titleLabel);
                notePanel.Controls.Add(dateLabel);

                notePanel.Click += panelClick;

                // add the panel to the nav bar 
                navBar.Controls.Add(notePanel);
            }

            
        }
    }
}
