using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment6
{
    public class InvoiceReader
    {
        string fileName;
        List<string> lines = new List<string>();

        public InvoiceReader(string fileNameA)
        {
            var fileName = fileNameA ?? throw new ArgumentNullException(nameof(fileNameA));

            // TODO: Försök hitta filen och verifiera att den är läsbar.
            // TODO: Acceptera full path till filnament. Det kommer från en fildialog.
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, fileName);
            // string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            this.fileName = file;
            Read();
        }


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

        public int Size { get; set; }

        private void Read()
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    // TODO: Lägg raderna i en variabel.
                    lines.Add(line);
                }
            }
        }


    }
}
