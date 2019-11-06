using Notes2;
using System;
using Xunit;


namespace NotesTests
{
    public class NoteRepositoryTest
    {
        [Theory]
        [InlineData("Complain1", "Bloody Hell!")]
        [InlineData("", "Nothing to say")]
        [InlineData("Complain2", "")]
        public void AddNoteValidTest(string title, string text)
        {
            INoteService notes = new NoteService();
            notes.AddNote(title, text);
            notes.N
           
        }

        [Theory]
        [InlineData(1, "Complain1", "Bloody Hell!")]
        public void EditNoteValidTest(int id, string title, string text)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData(1000, "Complain1", "Bloody Hell!")]
        public void EditNoteWrongId(int id, string title, string text)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData("jglkdfjg", "Complain1", "Bloody Hell!")]
        public void EditNoteStringId(string id, string title, string text)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData(1)]
        public void DeleteNoteValidTest(int id)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData(1000)]
        public void DeleteNoteWrongId(int id)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData("jglkdfjg")]
        public void DeleteNoteStringId(string id)
        {
            INoteService notes = new NoteService();
        }

        [Fact]
        public void GetAllNotesTest()
        {

        }

        [Theory]
        [InlineData(1)]
        public void GetNoteByIdValidTest(int id)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData(1000)]
        public void GetNoteByIdWrongId(int id)
        {
            INoteService notes = new NoteService();
        }

        [Theory]
        [InlineData("jglkdfjg")]
        public void GetNoteByIdStringId(string id)
        {
            INoteService notes = new NoteService();
        }
    }
}
