using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2
{
    public class NoteService : INoteService
    {
        private Dictionary<Guid, Note> notesList = new Dictionary<Guid, Note>();

        public Dictionary<Guid, Note> NotesList
        {
            get
            {
                return notesList;
            }

        }
        public void AddNote(string title, string text)
        {
            Note note = new Note(title, text);
            NotesList.Add(note.Id, note);
        }

        public void DeleteNote(Guid id)
        {
            NotesList.Remove(id);
        }

        public void EditNote(Guid id, string title, string text)
        {
            Note note = GetNoteById(id);
            note.Title = title;
            note.Text = text;
        }

        public Dictionary<Guid, Note> GetAllNotes()
        {
            return NotesList;
        }

        public Note GetNoteById(Guid id)
        {
            return NotesList[id];
        }
    }
}
