using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2._0
{
    public class Form
    {
        private string header = "################################################################\n" + "Notes App v1.0\r" + "################################################################\n";
        public string Header
        {
            get => header;
        }

        public void GoStart(string action)
        {
            Console.WriteLine($"Type r to {action} another note. Type s to go to start page.");
            int command = Convert.ToInt32(Console.ReadLine());
            var formFactory = new FormFactory();
            formFactory.GetForm(command);
            //Dictionary<string, Func<Form>> commandsList = new Dictionary<string, Func<Form>>();
            //commandsList.Add("r", () => { return this; });
            //commandsList.Add("s", () => { return new FormStart(); });
            //return commandsList[command]();
        }
        
    }
}
