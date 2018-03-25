// Helge Stenström 
// ah7875
// C# del II 2018

namespace Assignment
{ 
    /// <summary>
    /// Works more or less like an IListManager<string>, but a few methods are missing.
    /// Each Staff object is a person. The person has qualifications, which are stored in a list.
    /// </summary>
    public class Staff // could have been an  IListManager<string>
    {
        /// <summary>
        /// name of the person
        /// </summary>
        private string name;
        
        /// <summary>
        /// The list of qualifications
        /// </summary>
        private IListManager<string> qualifications;

        /// <summary>
        /// Constructor. Initializes an empty qualification list.
        /// </summary>
        public Staff()
        {
            qualifications = new ListManager<string>();
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public Staff(Staff other)
        {
            this.name = other.name;
            this.qualifications = other.qualifications;
        }

        /// <summary>
        /// Property for the name of the staff person
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Add a qualification
        /// </summary>
        /// <param name="qualification">qualification to be added</param>
        public void Add(string qualification)
        {
            qualifications.Add(qualification);
        }

        /// <summary>
        /// Replaces a qualification
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeAt(string item, int index)
        {
            return qualifications.ChangeAt(item, index);
        }

        /// <summary>
        /// Deletes the qualification at the indexed position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            return qualifications.DeleteAt(index);
        }

        /// <summary>
        /// Returns the list of qualifications as an array of strings.
        /// </summary>
        /// <returns>the list of qualifications as an array of strings</returns>
        public string[] ToStringArray()
        {
            return  qualifications.ToStringArray();
        }

        /// <summary>
        /// Returns a string representation of this Staff person.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ": " + string.Join(", ", (ListManager<string>) qualifications) + ".";
        }
    }   
}
