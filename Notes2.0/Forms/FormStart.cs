﻿using System;

namespace Notes2._0
{
    public class FormStart : Form
    {
        public FormStart()
        {
            Console.WriteLine(Header);
            Console.WriteLine("Commands Help - 5");
            Console.WriteLine("Type a command, and then press Enter: ");
            int command = Convert.ToInt32(Console.ReadLine());

            var formFactory = new FormFactory();
            formFactory.GetForm(command);
        }
    }
}
