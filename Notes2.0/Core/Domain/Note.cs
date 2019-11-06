using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Notes2

{
    public class Note
    {
        private Guid id;
        private string title;
        private string text;
        public static List<Note> allNotes = new List<Note>() { };

        public static int notesCount;
        public Guid Id { get => id; }
        public string Title { get; set; }
        public string Text { get; set; }

        public Note(string title, string text)
        {
            Title = title;
            Text = text;
            id = Guid.NewGuid();
        }
    }
}

