using System;

namespace Notes2
{
    public class FormDelete : Form
    {
        public FormDelete()
        {
            Console.Write("Enter note ID: ");
            string printId = Console.ReadLine();
            Guid noteId = Guid.Parse(printId);

            noteRepository.DeleteNote(noteId);

            GoStart("delete");
        }
    }
}
