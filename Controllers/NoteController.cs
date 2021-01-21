using PrivateNotes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateNotes.Controllers {
	class NoteController {

		public static List<Note> GetNotes() {
			List<Note> list = new List<Note>();

			list.Add(new Note("Note1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."));
			list.Add(new Note("Note2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Justo eget magna fermentum iaculis eu non diam phasellus. Viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas. Maecenas accumsan lacus vel facilisis volutpat. Vestibulum lectus mauris ultrices eros in cursus turpis massa tincidunt. Montes nascetur ridiculus mus mauris vitae ultricies leo integer."));
			list.Add(new Note("Note3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elit ut aliquam purus sit amet luctus venenatis. Sit amet consectetur adipiscing elit ut aliquam purus sit amet. Arcu dui vivamus arcu felis bibendum. Massa id neque aliquam vestibulum. Suspendisse in est ante in nibh. Lectus quam id leo in vitae. Cras pulvinar mattis nunc sed blandit libero. Eget sit amet tellus cras adipiscing."));

			return list;
		}
	}
}
