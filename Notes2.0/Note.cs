using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Notes2._0

{
    public class Note
    {
        private int id;
        private string title;
        private string text;
        public static List<Note> allNotes = new List<Note>() { };

        public static int notesCount;
        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public string Text { get => text; set => text = value; }

        public Note(string title, string text)
        {
            this.Title = title;
            this.Text = text;
            this.id = Interlocked.Increment(ref notesCount);
        }
    }
}

