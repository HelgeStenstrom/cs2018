using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	/// <summary>
	/// Summary description for Contact.
	/// </summary>
	public class Contact : Person
	{
		private Address postAddress;

		public Contact(Address adr)
		{
			this.postAddress.Copy(adr);
		}
		public bool CheckAddress(Address adr)
		{
			return postAddress.Equals(adr);
		}
		public Address PostMail()
		{
			return postAddress;
		}
	}
}
