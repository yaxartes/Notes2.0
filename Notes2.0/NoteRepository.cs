using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2._0
{
    class NoteRepository : INoteRepository
    {
        private Dictionary<int, Note> notesList = new Dictionary<int, Note>();
        public int GlobaNotelId { get; set; }

        public Dictionary<int, Note> NotesList
        {
            get
            {
                return notesList;
            }

        }
        public void AddNote(string title, string text)
        {
            Note note = new Note(title, text);
            GlobaNotelId++;
            NotesList.Add(GlobaNotelId, note);
        }

        public void DeleteNote(int id)
        {
            NotesList.Remove(id);
        }

        public void EditNote(int id, string title, string text)
        {
            Note note = GetNoteById(id);
            note.Title = title;
            note.Text = text;
        }

        public Dictionary<int, Note> GetAllNotes()
        {
            return NotesList;
        }

        public Note GetNoteById(int id)
        {
            return NotesList[id];
        }
    }
}
