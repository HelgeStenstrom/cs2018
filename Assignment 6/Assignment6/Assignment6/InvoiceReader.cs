// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment6
{
    /// <summary>
    /// Read a formatted textfile containing an invoice, and produce a instance of the Invoice class.
    /// Inner classes are used for contacts and items on the invoice.
    /// </summary>
    public class InvoiceReader
    {
        /// <summary>
        /// The name of the file containing the invoice.
        /// </summary>
        string fileName;

        /// <summary>
        /// Holds one line of the file per item in the list.
        /// </summary>
        List<string> lines = new List<string>();

        /// <summary>
        /// Reads the given file and puts it in lines.
        /// </summary>
        /// <param name="filename">file to read, containing an invoice</param>
        public InvoiceReader(string filename)
        {
            var fileName = filename ?? throw new ArgumentNullException(nameof(filename));

            // TODO: Försök hitta filen och verifiera att den är läsbar.
            // TODO: Acceptera full path till filnament. Det kommer från en fildialog.
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, fileName);
            // string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            this.fileName = file;

            using (TextReader reader = new StreamReader(this.fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
            }
        }

        /// <summary>
        /// Returns an instance of Invoice, based on the file that has already been read in.
        /// </summary>
        /// <returns> an instance of Invoice</returns>
        public Invoice GetInvoice()
        {
            int invoiceNumber;
            DateTime d1;
            DateTime d2;
            
            try
            {
                invoiceNumber = int.Parse(lines[0]);
                d1 = DateTime.Parse(lines[1]);
                d2 = DateTime.Parse(lines[2]);
                var linesPerContact = 6;
                var reciver = getContact(lines.GetRange(3, linesPerContact));
                int itemCount = int.Parse(lines[9]);
                int linesPerItem = 4;
                var itemLines = lines.GetRange(10, itemCount * linesPerItem);

                List<Invoice.Item> items = new List<Invoice.Item>();
                for (int i = 0; i < itemCount; i++)
                {
                    var baseIdx = linesPerItem * i;
                    string desc = itemLines[0 + baseIdx];
                    int quantity = int.Parse(itemLines[1 + baseIdx]);
                    double price = double.Parse(itemLines[2 + baseIdx]);
                    double tax = double.Parse(itemLines[3 + baseIdx]);

                    items.Add(new Invoice.Item(i+1, desc, quantity, price, tax));
                }

                int nextLine = 10 + itemCount * linesPerItem ;
                var sender = getContact(lines.GetRange(nextLine, linesPerContact));
                nextLine += linesPerContact;
                string phone = lines[nextLine++];
                string url = lines[nextLine++];

                return new Invoice(invoiceNumber,
                    d1, d2, reciver, sender,
                    phone, url, items);
            }
            catch (NotImplementedException e)
            {
                throw e;
                // TODO: Byt ut mot bättre åtgärd.
            }
        }

        /// <summary>
        /// Returns an instance of Contact, based on a number of strings from an invoice file.
        /// </summary>
        /// <param name="list">Strings that make up the contact.</param>
        /// <returns>an instance of Contact</returns>
        private Invoice.Contact getContact(List<string> list)
        {
            try
            {
                string company = list[0];
                string person = list[1];
                string street = list[2];
                string zip = list[3];
                string city = list[4];
                string country = list[5];
                return new Invoice.Contact(company, person, street, zip, city, country);
            }
            catch (Exception e)
            {
                throw e;
                // TODO: Byt ut mot bättre åtgärd.
            }
        }
    }
}
