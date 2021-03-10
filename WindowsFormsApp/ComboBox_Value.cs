using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    class ComboBox_Value
    {
        public int id { get; private set; }
        public string name { get; private set; }
        
        public ComboBox_Value (int _id, string _name)
            {
                id = _id;
                name = _name;
            }
        public override string ToString()
        {
            return name;
        }
    }
}
