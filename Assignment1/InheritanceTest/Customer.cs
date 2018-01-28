using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	/// <summary>
	/// Summary description for Customer.
	/// </summary>
	public class Customer : Person
	{
		private int id;
        //Add more fields


		public Customer()
		{
			//
			// TODO: Add constructor logic here
			//
		}


		//Property for id
		public int ID
		{
			get { return id; }
			set
			{
				id = value;
			}
		}
	}

}
