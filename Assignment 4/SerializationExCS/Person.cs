//Farid Naisan 
//Code example
//Mark the class by the Serializable Attributusing System;
//This class is used for testing serialization.
using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationExProjCS
{
    [Serializable]
    public class Person
    {
        private string m_firstName;
        private string m_lastName;
        
        /// <remarks>m_errMessage is not to be serialzed.</remarks>
        [NonSerialized]
        private string m_errMessage = null;

        public Person()
        {
        }
        /// <summary>
        /// Consttructor with initial values for first and last names
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <remarks></remarks>
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Property
        /// </summary>
        /// <value>Property related to m_firstName</value>
        /// <returns>The value saved in m_firstName</returns>
        /// <remarks>The value is a string with a new value for m_firstName</remarks>
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }

        /// <summary>
        /// Property
        /// </summary>
        /// <value>Property related to m_lastName</value>
        /// <returns>The value saved in m_lastName</returns>
        /// <remarks>The value is a string with a new value for m_lastName</remarks>
        public string LastName
        {
            get { return m_lastName; }
            set { m_lastName = value; }
        }

        /// <summary>
        /// Returns the full name, putting together first and last name separated
        /// by a space.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string FullName
        {
            get
            {
                if ((string.IsNullOrEmpty(m_firstName) & string.IsNullOrEmpty(m_lastName)))
                {
                    return "The Invisible Person";
                }

                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
