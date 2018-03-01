using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Staff
    {
        private string name;
        private IListManager<string> qualifications;

        public Staff()
        {
            qualifications = new ListManager<string>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
