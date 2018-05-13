using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    /// <summary>
    /// All data of an invoice.
    /// </summary>
    public class Invoice
    {

        /// <summary>
        /// Data for an item of an invoice
        /// </summary>
        public class Item
        {
            public Item(int itemNo,  string description, int quantity, double unitPrice, double taxPercent)
            {
                ItemNo = itemNo;
                Description = description;
                Quantity = quantity;
                UnitPrice = unitPrice;
                TaxPercent = taxPercent;
            }

            public int ItemNo { get; set; }


            public double TaxPercent { get; }

            public double UnitPrice { get; }

            public int Quantity { get; }

            public string Description { get; }

            public double TotalTax => Quantity * UnitPrice* TaxPercent * 0.01;
            public double Total => Quantity * UnitPrice + TotalTax;
        }

        /// <summary>
        /// Contact data for a company; either a sender or a receiver of an invoice
        /// </summary>
        public class Contact
        {
            private string _companyName;
            private string _personName;
            private string _street;
            private string _zip;
            private string _city;
            private string _country;

            public Contact(string companyName, string personName, string street, string zip, string city, string country)
            {
                _companyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
                _personName = personName ?? throw new ArgumentNullException(nameof(personName));
                _street = street ?? throw new ArgumentNullException(nameof(street));
                _zip = zip ?? throw new ArgumentNullException(nameof(zip));
                _city = city ?? throw new ArgumentNullException(nameof(city));
                _country = country ?? throw new ArgumentNullException(nameof(country));
            }

            public Contact()
            {
                string u = "unknown";
                _companyName = u;
                _personName = u;
                _street = u;
                _zip = u;
                _city = u;
                _country = u;
            }

            public string CompanyName => _companyName;

            public string PersonName => _personName;

            public string Street => _street;

            public string Zip => _zip;

            public string City => _city;

            public string Country => _country;
            public override string ToString()
            {
                return $"{_companyName}\n{_personName}\n{_street}\n{_zip} {_city}\n{_country}";
            }
        }

        public double Discount { get; set; }

        public Invoice(int invoiceNumber, 
            DateTime invoiceDate, DateTime dueDate, 
            Contact receiver, Contact sender, 
            string phone, string webAddress, 
            List<Item> items)
        {
            InvoiceNumber = invoiceNumber;
            InvoiceDate = invoiceDate;
            DueDate = dueDate;
            Receiver = receiver;
            Sender = sender;
            Phone = phone;
            WebAddress = webAddress;
            Items = items;
        }

        public int InvoiceNumber { get; }

        public DateTime InvoiceDate { get; set; }

        public DateTime DueDate { get; set; }

        public Contact Receiver { get; }

        public Contact Sender { get; }

        public string Phone { get; }

        public string WebAddress { get; }

        public double TotalTax => Items.Sum(item => item.TotalTax);

        public double Total => Items.Sum(item => item.Total);

        public List<Item> Items { get; }
        public double ToPay => Total - Discount;

        public Invoice()
        {
            Items = new List<Item>();
            Receiver = new Contact();
            Sender = new Contact();
        }
    }
}
