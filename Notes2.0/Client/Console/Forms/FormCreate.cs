using System;

namespace Notes2
{
    public class FormCreate : Form
    {
        public FormCreate()
        {
            Console.Write($"Enter note title: ");
            string title = Console.ReadLine();

            Console.Write("Enter note text: ");
            string text = Console.ReadLine();

            noteRepository.AddNote(title, text);

            GoStart("add");
        }
    }
}
