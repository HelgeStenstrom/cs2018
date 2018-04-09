//Programming using .NET, advanced Course
//Event-delegate example
//Farid Naisan March 2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BidHouseWPFCS
{
    /// <summary>
    /// A simple product class used for containing bidinformation
    /// </summary>
    /// <remarks></remarks>
    /// 
    public class Product
    {
        private string m_name;
        private string m_description;
        private decimal m_price;

        private int m_count;

        public Product()
        {
        }
        public Product(string name, string descr, decimal price, int num)
        {
            m_name = name;
            m_description = descr;
            m_price = price;
            m_count = num;
        }

        public int Count
        {
            get { return m_count; }
            set { m_count = value; }
        }

        public decimal Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public override string ToString()
        {
            string newL = Environment.NewLine;

            return string.Format("{1}{0}{2}{0}Price: {3,-30:f2}{0}Quantity included: {4}", newL, m_name, m_description, m_price, m_count);
        }

    }

}
