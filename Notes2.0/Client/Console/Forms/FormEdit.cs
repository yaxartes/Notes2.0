using System;

namespace Notes2
{
    public class FormEdit : Form
    {
        public FormEdit()
        {
            Console.Write("Enter note ID: ");
            string printId = Console.ReadLine();
            Guid noteId = Guid.Parse(printId);
            Console.Write($"Enter note title: ");
            string title = Console.ReadLine();

            Console.Write("Enter note text: ");
            string text = Console.ReadLine();

            noteRepository.EditNote(noteId, title, text);

            GoStart("edit");
        }
    }
}
