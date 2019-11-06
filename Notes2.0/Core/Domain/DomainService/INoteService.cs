using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2
{
    public interface INoteService
    {
        void AddNote(string title, string text);
        Note GetNoteById(Guid id);
        Dictionary<Guid, Note> GetAllNotes();
        void DeleteNote(Guid id);
        void EditNote(Guid id, string title, string text);
    }
}
