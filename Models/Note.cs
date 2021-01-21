using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Models {
	class Note {

		string title { get; set; }
		string text { get; set; }

		public Note(string title, string text) {
			this.title = title;
			this.text = text;
		}
	}
}
