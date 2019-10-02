using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2
{
    interface INoteRepository
    {
        //List<Card> CardList { get; }
        //int GlobaNotelId { get; set; }
        void AddNote(string title, string text);
        Note GetNoteById(int id);
        Dictionary<int, Note> GetAllNotes();
        void DeleteNote(int id);
        void EditNote(int id, string title, string text);
    }
}
