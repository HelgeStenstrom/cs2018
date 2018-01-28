using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	/// <summary>
	/// Summary description for Address.
	/// </summary>
	public class Address
	{
		private string street;
        private string zipCode;  //postnummer
        private string city;
        private string country;

		//Default Constructor - needed when another class has this class as its field
		public Address() { }

		public Address(string street, string zip, string city)
		{
			this.street = street;
			this.zipCode = zip;
			this.city = city;
			this.country = "Sverige";
		}
		public Address(Address theOther)
		{
			this.Copy(theOther);
		}

		public void Copy(Address mail)
		{
			this.street = mail.Street;
			this.zipCode = mail.ZipCode;
			this.city = mail.City;
			this.country = mail.Country;
		}

		//Properties
		public string Street
		{
			get { return street; }
			set
			{
				if (value != "")
					street = value;
			}
		}
		public string ZipCode
		{
			get { return zipCode; }
			set
			{
				if (value != "")
					zipCode = value;
			}
		}
		public string City
		{
			get { return city; }
			set
			{
				if (value != "")
					city = value;
			}
		}

		public string Country
		{
			get { return country; }
			set
			{
				country = value;
			}
		}

		//Format the address in several lines
		public override string ToString()
		{

			return string.Format("{0}\n{1} {2}\n{3}", street, zipCode, city, country);
		}

	}
}
