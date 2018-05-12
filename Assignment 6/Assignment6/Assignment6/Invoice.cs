using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

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
            private string description;
            private int quantity;
            private double unitPrice;
            private double taxPercent;

            public Item(string description, int quantity, double unitPrice, double taxPercent)
            {
                this.description = description;
                this.quantity = quantity;
                this.unitPrice = unitPrice;
                this.taxPercent = taxPercent;
            }

            public double TaxPercent => taxPercent;

            public double UnitPrice => unitPrice;

            public int Quantity => quantity;

            public string Description => description;
        }

        /// <summary>
        /// Contact data for a company; either a sender or a receiver of an invoice
        /// </summary>
        public class Contact
        {
            private string companyName;
            private string personName;
            private string street;
            private string zip;
            private string city;
            private string country;

            public Contact(string companyName, string personName, string street, string zip, string city, string country)
            {
                this.companyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
                this.personName = personName ?? throw new ArgumentNullException(nameof(personName));
                this.street = street ?? throw new ArgumentNullException(nameof(street));
                this.zip = zip ?? throw new ArgumentNullException(nameof(zip));
                this.city = city ?? throw new ArgumentNullException(nameof(city));
                this.country = country ?? throw new ArgumentNullException(nameof(country));
            }

            public string CompanyName => companyName;

            public string PersonName => personName;

            public string Street => street;

            public string Zip => zip;

            public string City => city;

            public string Country => country;
            public override string ToString()
            {
                return $"{companyName}\n{personName}\n{street}\n{zip} {city}\n{country}";
            }
        }

        private int invoiceNumber;
        private DateTime invoiceDate;
        private DateTime dueDate;
        private Contact receiver;
        private Contact sender;
        private string phone;
        private string webAddress;
        private List<Item> items;

        public Invoice(int invoiceNumber, 
            DateTime invoiceDate, DateTime dueDate, 
            Contact receiver, Contact sender, 
            string phone, string webAddress, 
            List<Item> items)
        {
            this.invoiceNumber = invoiceNumber;
            this.invoiceDate = invoiceDate;
            this.dueDate = dueDate;
            this.receiver = receiver;
            this.sender = sender;
            this.phone = phone;
            this.webAddress = webAddress;
            this.items = items;
        }

        public int InvoiceNumber => invoiceNumber;

        public DateTime InvoiceDate => invoiceDate;

        public DateTime DueDate => dueDate;

        public Contact Receiver => receiver;

        public Contact Sender => sender;

        public string Phone => phone;

        public string WebAddress => webAddress;

        public List<Item> Items => items;

        public Invoice()
        {
        }
    }
}
