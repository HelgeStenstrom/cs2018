// Helge Stenström 
// ah7875
// C# del II 2018

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
            /// <summary>
            /// An item of an invoice.
            /// </summary>
            /// <param name="itemNo">Item number, maintained by the caller (not from the invoice file)</param>
            /// <param name="description"> description of the item</param>
            /// <param name="quantity">quantity</param>
            /// <param name="unitPrice">price per unit purchased</param>
            /// <param name="taxPercent">tax rate in percent, on this item</param>
            public Item(int itemNo,  string description, int quantity, double unitPrice, double taxPercent)
            {
                ItemNo = itemNo;
                Description = description;
                Quantity = quantity;
                UnitPrice = unitPrice;
                TaxPercent = taxPercent;
            }

            /// <summary>
            /// >Item number, maintained by the caller (not from the invoice file)
            /// </summary>
            public int ItemNo { get; set; }

            /// <summary>
            /// tax rate in percent, on this item
            /// </summary>
            public double TaxPercent { get; }

            /// <summary>
            /// price per unit purchased
            /// </summary>
            public double UnitPrice { get; }

            /// <summary>
            /// Number of items of this kind purchased.
            /// </summary>
            public int Quantity { get; }

            /// <summary>
            /// Description of the item
            /// </summary>
            public string Description { get; }

            /// <summary>
            /// Total tax to pay for the whole quantity of this item
            /// </summary>
            public double TotalTax => Quantity * UnitPrice* TaxPercent * 0.01;

            /// <summary>
            /// Total amount to pay for this item (the whole quantity, and including tax)
            /// </summary>
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

            /// <summary>
            /// A contact, typically used for receiver or sender of an invoice
            /// </summary>
            /// <param name="companyName"></param>
            /// <param name="personName">Contact person at the company</param>
            /// <param name="street"></param>
            /// <param name="zip">Postal number</param>
            /// <param name="city"></param>
            /// <param name="country"></param>
            public Contact(string companyName, string personName, string street, string zip, string city, string country)
            {
                _companyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
                _personName = personName ?? throw new ArgumentNullException(nameof(personName));
                _street = street ?? throw new ArgumentNullException(nameof(street));
                _zip = zip ?? throw new ArgumentNullException(nameof(zip));
                _city = city ?? throw new ArgumentNullException(nameof(city));
                _country = country ?? throw new ArgumentNullException(nameof(country));
            }

            /// <summary>
            /// Default constructor, used to have a valid contact before an invoice is read in.
            /// </summary>
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

            /// <summary>
            /// Multi-row text describing the contact.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"{_companyName}\n{_personName}\n{_street}\n{_zip} {_city}\n{_country}";
            }
        }

        /// <summary>
        /// Discount amount on this invoice, in the standard currency.
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// Constructor for an invoice. Most parts usually come from an invoice file.
        /// </summary>
        /// <param name="invoiceNumber"></param>
        /// <param name="invoiceDate"></param>
        /// <param name="dueDate"></param>
        /// <param name="receiver"></param>
        /// <param name="sender"></param>
        /// <param name="phone"></param>
        /// <param name="webAddress"></param>
        /// <param name="items"></param>
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

        /// <summary>
        /// Enumeration/identification of the invoice
        /// </summary>
        public int InvoiceNumber { get; }

        /// <summary>
        /// Date of the invoice
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Due date of the invoice
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The reciver shall pay the invoice.
        /// </summary>
        public Contact Receiver { get; }

        /// <summary>
        /// The sender is usually paid by the receiver.
        /// </summary>
        public Contact Sender { get; }

        /// <summary>
        /// Telephone number of the sender
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// URL of the sender
        /// </summary>
        public string WebAddress { get; }

        /// <summary>
        /// Total tax to pay on this invoice
        /// </summary>
        public double TotalTax => Items.Sum(item => item.TotalTax);
        
        /// <summary>
        /// Total amount on this invoice, before discounts.
        /// </summary>
        public double Total => Items.Sum(item => item.Total);

        /// <summary>
        /// Items on this invoice.
        /// </summary>
        public List<Item> Items { get; }

        /// <summary>
        /// Amount to pay, after discounts.
        /// </summary>
        public double ToPay => Total - Discount;

        /// <summary>
        /// Default constructor, used when no real invoice is available.
        /// </summary>
        public Invoice()
        {
            Items = new List<Item>();
            Receiver = new Contact();
            Sender = new Contact();
        }
    }
}
