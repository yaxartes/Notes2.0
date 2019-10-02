using System;

namespace Notes2
{
    public class FormHelp : Form
    {
        public FormHelp()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Commands Help");
            Console.WriteLine("1 - Add note");
            Console.WriteLine("2 - List of notes");
            Console.WriteLine("3 - Delete note");
            Console.WriteLine("4 - Edit Note");
            Console.WriteLine("5 - Help");
            Console.WriteLine("6 - Exit");
            Console.WriteLine("Press Enter to go back.");
            Console.ReadLine();
            var formFactory = new FormFactory();
            formFactory.GetForm(0);
        }
    }
}
