using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public class Person : Creature
	{
		private string firstName;
		private string lastName;
		private string personalNumber;  //yymmdd-1234
		private Address address;     //Address is a class (has-a relationship)

		public Person(): base(Kind.Human)
		{
			this.address = new Address();
		}

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

		public Person(Address mail) : base(Kind.Human)
		{
			this.address = new Address(mail);
		}

		//Property for m_firstName with read/write access
		public string FirstName
		{
			get { return firstName; }
			set
			{
				if (value != "")
					firstName = value;
			}
		}
		//Property for surname
		public string SurName
		{
			get { return lastName; }
			set
			{
				if (value != "")
					lastName = value;
			}
		}

		//property for personalNumber
		public string PersonalNumber
		{
			get { return personalNumber; }
			set
			{
				if (value != "")
					personalNumber = value;
			}
		}

		public Address Address   //the first Address = class name, the 2nd = Property name
		{
			get { return address; }
		}
		//Readonly property 
		//Age is calculated from the personalNumber
		public int Age
		{
			get
			{
				if (personalNumber != null)
				{
					//Take the first 4 digits from the peronalNumber "1930"
					int dob = Convert.ToInt32(personalNumber.Substring(0, 4));
					return DateTime.Now.Year - dob;
				}
				else
					return 0;
			}
		}

		public override string ToString()
		{
			return "I am a salesperson!";
		}

		//Implementation of the abstract method from the Creature class
		override public string GetSkill()
		{
			throw new Exception("The method or operation is not implemented.");
		}
	}
}
