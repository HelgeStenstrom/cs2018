using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class InvoiceReader
    {
        string fileName;

        public InvoiceReader(string fileNameA)
        {
            var fileName = fileNameA ?? throw new ArgumentNullException(nameof(fileNameA));

            // TODO: Försök hitta filen och verifiera att den är läsbar.
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var file = Path.Combine(projectFolder, fileName);
            // string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
            this.fileName = file;
        }

        public int Size { get; set; }

        public void Read()
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // TODO: Lägg raderna i en variabel.
                }
            }
        }
    }
}
