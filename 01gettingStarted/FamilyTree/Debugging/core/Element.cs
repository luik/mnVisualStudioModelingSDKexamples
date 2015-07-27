using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Element
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public Element(string name)
        {
            this.name = name;
        }
    }
}
