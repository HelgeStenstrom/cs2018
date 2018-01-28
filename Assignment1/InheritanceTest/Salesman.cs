using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	/// <summary>
	/// Summary description for Seller.
	/// </summary>
	public class Salesman : Person
	{
		private string category;

		public Salesman()
		{
		}

		//Property for Category
		public string Category
		{
			get { return category; }
			set
			{
				category = value;
			}
		}
        public override string GetSkill()
        {
            return base.GetSkill();
        }
	}
}
