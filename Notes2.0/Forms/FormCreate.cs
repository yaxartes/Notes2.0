using System;

namespace Notes2._0
{
    public class FormCreate : Form
    {
        public FormCreate()
        {
            Console.WriteLine(Header);
            Console.Write($"Enter note title: ");
            string title = Console.ReadLine();

            Console.Write("Enter note text: ");
            string text = Console.ReadLine();

            NoteRepository noteRepository = new NoteRepository();
            noteRepository.AddNote(title, text);

            GoStart("add");
        }
    }
}
