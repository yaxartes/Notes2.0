using System;
using System.Collections.Generic;
using System.Text;

namespace Notes2._0
{
    class FormFactory
    {
        private Dictionary<int, Func<Form>> formsList;

        public FormFactory()
        {
            FormsList = new Dictionary<int, Func<Form>>();
            FormsList.Add(0, () => { return new FormStart(); });
            FormsList.Add(1, () => { return new FormCreate(); });
            FormsList.Add(2, () => { return new FormList(); });
            FormsList.Add(3, () => { return new FormDelete(); });
            FormsList.Add(4, () => { return new FormEdit(); });
            FormsList.Add(5, () => { return new FormHelp(); });
        }

        public Dictionary<int, Func<Form>> FormsList { get => formsList; set => formsList = value; }

        public Form GetForm(int formType)
        {
            return FormsList[formType]();
        }
    }
}
