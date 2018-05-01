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
    class Invoice
    {
        /// <summary>
        /// Data for an item of an invoice
        /// </summary>
        internal class Item
        {
            private string description;
            private int quantity;
            private double unitPrice;
            private double taxPercent;
            
        }

        /// <summary>
        /// Contact data for a company; either a sender or a receiver of an invoice
        /// </summary>
        internal class Contact
        {
            private string companyName;
            private string personName;
            private string street;
            private string zip;
            private string city;
            private string country;
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
    }
}
