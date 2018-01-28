using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
public class Employee : Person
{
	private decimal salary;

	public Employee() { }

	public Employee(decimal startPay) : this ("Nisse", "Hultz")
	{
		salary = startPay;
	}

    public Employee(string firstName, string lastName) : base(firstName, lastName)
    { }

  
		public decimal Salary
		{
			get { return salary; }
			set
			{
				if (value > 0.0m)
					salary = value;
			}
		}
        public override string ToString()
        {
            return "Information about " + base.ToString();
        }
	}
}
