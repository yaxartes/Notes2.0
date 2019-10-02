using System;

namespace Notes2
{
    public class FormEdit : Form
    {
        public FormEdit()
        {
            Console.WriteLine(Header);
            Console.Write("Enter note ID: ");
            string printId = Console.ReadLine();
            int noteId = Convert.ToInt32(printId);
            Console.Write($"Enter note title: ");
            string title = Console.ReadLine();

            Console.Write("Enter note text: ");
            string text = Console.ReadLine();

            NoteRepository noteRepository = new NoteRepository();
            noteRepository.EditNote(noteId, title, text);

            GoStart("edit");
        }
    }
}
