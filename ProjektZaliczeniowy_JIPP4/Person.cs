using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaliczeniowy_JIPP4
{
    public delegate void ChangeDataHandler(string oldData, string newData);
    public class Person
    {
        public event ChangeDataHandler ChangedData;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    var oldName = name;
                    name = value;

                    ChangedData?.Invoke(oldName, value);
                }
            }
        }

        public string Surname { get; set; }
        public bool Sex { get; set; }
        public int Id { get; set; }

    }
}
