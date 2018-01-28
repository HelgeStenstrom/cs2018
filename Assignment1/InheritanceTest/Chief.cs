using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public class Chief : Employee
	{
		private decimal bonus;

		public Chief()
		{
			bonus = 100000; //begin with a bonus
		}
		public Chief(decimal startPay) : base(startPay)
		{
			//other initiations
		}

		//Property for bonus
		public decimal Bonus
		{
			get { return bonus; }
			set
			{
				bonus = value;
			}
		}

		public decimal TotalIncome
		{
			get { return bonus + Salary; }
		}
	}
}
