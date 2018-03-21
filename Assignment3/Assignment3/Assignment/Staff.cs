using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{ 
    public class Staff //: IListManager<string>
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

        public void Add(string s)
        {
            qualifications.Add(s);
        }

        public bool DeleteAt(int index)
        {
            return qualifications.DeleteAt(index);
        }

        public string[] ToStringArray()
        {
            return  qualifications.ToStringArray();
        }

        public override string ToString()
        {
            return Name + ": " + string.Join(", ", (ListManager<string>) qualifications) + ".";
        }
    }   
}
