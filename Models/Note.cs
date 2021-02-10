using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Models {
	public class Note {

		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime Date { get; set; }

		public Note() {
		}
		public Note(string Title) {
			this.Title = Title;
		}

		public Note(string title, string text, DateTime date) {
			this.Title = title;
			this.Text = text;
			this.Date = date;
		}

	}
}
