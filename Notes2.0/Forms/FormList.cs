using System;
using System.Collections.Generic;

namespace Notes2
{
    public class FormList : Form
    {
        public FormList()
        {
            Console.WriteLine(Header);
            NoteRepository noteRepository = new NoteRepository();
            
            Dictionary<int, Note> allNotes = noteRepository.GetAllNotes();
            if (allNotes.Count == 0)
            {
                Console.WriteLine("No notes yet...");
                Console.WriteLine("Press Enter to go back.");
                Console.ReadLine();
                var formFactory = new FormFactory();
                formFactory.GetForm(0);
            }
            else
            {
                foreach (KeyValuePair<int, Note> note in allNotes)
                {
                    Console.WriteLine("[{0}] - {1}", note.Key, note.Value.Title);
                }
            }
            
        }
    }
}
