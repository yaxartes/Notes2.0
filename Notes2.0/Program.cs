using System;
using System.Collections.Generic;

namespace Notes2
{
    class Program
    {
        public static List<Note> allNotes = new List<Note>();
        public static FormFactory formFactory = new FormFactory();
        public static INoteRepository notes = new NoteRepository();

        static void Main(string[] args)
        {
            //bool endApp = false;
            try
            {
                formFactory.GetForm(0);
            }
            catch
            {
                Console.WriteLine("Wrong command!");
            }

            /*
            while (!endApp)
            {
                FormStart start = new FormStart();
            }
            return;
            */
        }
    }
}
