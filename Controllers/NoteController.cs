using PrivateNotes.Models;
using PrivateNotes.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        List<Note> list = new List<Note>();
        bool newNote = false;

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
            newNote = true;
			// create the brand new note here
			Note note = new Note("New Note", "", DateTime.Today);
            selectedNote = note;

            // this label is the title of the ntoe
            Label titleLabel = new Label {
                Font = new Font("Arial", 12),
                Text = note.Title,
                Location = new Point(8, 15),
                AutoSize = true

            };

            // this label is the date of the note (when it was created)
            Label dateLabel = new Label {
                Font = new Font("Arial", 9),
                Text = note.Date.ToString(),
                Location = new Point(8, 45)
            };

            // the notePanel that holds all the items
            Panel notePanel = new Panel {
                Size = new Size(255, 70),
                BackColor = Color.LightGray
            };
            notePanel.Name = "notePanel" + list.Count;
            notePanel.Controls.Add(titleLabel);
			notePanel.Controls.Add(dateLabel);
            
            notePanel.Click += panelClick;

			// add the panel to the nav bar 
			navBar.Controls.Add(notePanel);
			addNoteButton.Enabled = true;

            lastPanel = notePanel;
            list.Add(note);
            titleBox.Text = note.Title;
            descriptionBox.Text = "";
		}

        public void panelClick(object sender, EventArgs e) {
            newNote = false;
            lastPanel = (Panel)sender;
            selectedNote = list[lastPanel.Parent.Controls.GetChildIndex(lastPanel)];
            titleBox.Text = selectedNote.Title;
            descriptionBox.Text = selectedNote.Text;
        }

        public void labelClick(object sender, EventArgs e) {
            newNote = false;
            Label label = (Label)sender;
            lastPanel = (Panel)label.Parent;
            selectedNote = list[lastPanel.Parent.Controls.GetChildIndex(lastPanel)];
            titleBox.Text = selectedNote.Title;
            descriptionBox.Text = selectedNote.Text;
        }

        public void saveButtonClick(object sender, EventArgs e) {
            LoginCredentials loginCredentials = LoginController.GetLoginCredentials();
            string path = "";
            if (newNote)
                path = Directory.GetCurrentDirectory() + "\\" + loginCredentials.Username + "\\notePanel"  + list.Count+ ".txt";
            else
                path = Directory.GetCurrentDirectory() + "\\" + loginCredentials.Username + "\\notePanel" + lastPanel.Parent.Controls.GetChildIndex(lastPanel) + ".txt";


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
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\" + loggedUser.Username);
            FileInfo[] Files = d.GetFiles("*.txt");
            int count1 = 0;
            //Getting Text files
            foreach (FileInfo file in Files) {
                string title = File.ReadLines(file.FullName).First();
                string description = File.ReadAllText(file.FullName);
                description = description.Replace(title, "");
                int count = 0;

                // this label is the title of the ntoe
                Label titleLabel = new Label {
                    Font = new Font("Arial", 12),
                    Text = title,
                    Location = new Point(8, 15),
                    AutoSize = true
                };

                // this label is the date of the note (when it was created)
                Label dateLabel = new Label {
                    Font = new Font("Arial", 9),
                    Text = DateTime.Now.ToString(),
                    Location = new Point(8, 45)
                };

                // the notePanel that holds all the items
                Panel notePanel = new Panel {
                    Size = new Size(255, 70),
                    BackColor = Color.LightGray
                };
                notePanel.Name = "notePanel" + count;
                notePanel.Controls.Add(titleLabel);
                notePanel.Controls.Add(dateLabel);

                notePanel.Click += panelClick;
                titleLabel.Click += labelClick;
                dateLabel.Click += labelClick;

                // add the panel to the nav bar 
                navBar.Controls.Add(notePanel);

                list.Add(new Note(title, description, DateTime.Now));
                count1++;
            }

            
        }
    }
}
