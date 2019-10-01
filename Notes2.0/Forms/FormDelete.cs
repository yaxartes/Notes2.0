using System;

namespace Notes2._0
{
    public class FormDelete : Form
    {
        public FormDelete()
        {
            Console.WriteLine(Header);
            Console.Write("Enter note ID: ");
            string printId = Console.ReadLine();
            int noteId = Convert.ToInt32(printId);

            NoteRepository noteRepository = new NoteRepository();
            noteRepository.DeleteNote(noteId);

            GoStart("delete");
        }
    }
}
