using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inheritance
{
	public partial class MainFrame : Form
	{
		public MainFrame()
		{
			InitializeComponent();
		}
		private void TestDynamicBinding(int val)
		{
			Person pers;
			//static bindning to Person (early binding)

			//Depending on the value of "choice", the variable pers will dynamically refer to
			//different type of object wihin the inheritance hierarchy (dynamic binding or late binding)
			switch ((val))
			{
				case 1:
					pers = new Chief();
					break;
				case 2:
					pers = new Salesman();
					break;
				case 3:
					pers = new Employee();
					break;
				default:
					pers = new Person();
					break;
			}
		}

		private void btnIsA_Click(object sender, EventArgs e)
		{
			Chief boss = new Chief();
			boss.FirstName = "Nanna";
			string strText = string.Format("Chief is a Person who has the first name: {0}. ", boss.FirstName);
			MessageBox.Show(strText, "Is - a relationship");
		}


		private void btnChief_Click(object sender, EventArgs e)
		{
			Chief departmentChief = new Chief();
			departmentChief.FirstName = "Nisse";
			//klassen Person
			departmentChief.SurName = "Lundström";
			//klassen Person
			departmentChief.Salary = 55000;
			//klassen Anställd
			departmentChief.Bonus = 120000;
			//klassen Chief
			MessageBox.Show("The boss earns: " + departmentChief.TotalIncome.ToString() +" a month!", "Test Program");

		}

		private void btnHasA_Click(object sender, EventArgs e)
		{
			Address adr = new Address("Vapenkroken 89", "12356", "Lund");
			Person Nisse = new Person(adr);

			//ändra gatunr för Nisse
			Nisse.Address.Street = "Nyckelkroken 98";
			Person NissesMaka = new Person(Nisse.Address);

			//Formatera en meddelandetext
			string strText;
			strText = "Nisse has an address, i.e. an instance of the class Address, i.e. an object of Address.";
			strText += Environment.NewLine;  //en tomrad i strängen
			strText += "Retrieved from the object:  " + Environment.NewLine;
			strText += String.Format("Nisses gata: {0}, Makans gata: {1}, adr-Gata{2}: ", 
                  Nisse.Address.Street, NissesMaka.Address.Street, adr.Street);
       
			MessageBox.Show(strText, "C# test of \"has-a\"");  //what is a \" ?
		}

		private void btnDynamicBin_Click(object sender, EventArgs e)
		{
			Person per1 = new Person();	//1
			Person per2 = new Employee();//2
			per2 = new Chief();	//3
			Salesman per3 = new Salesman();	//4
            
            TestaDnyanmiskBinding(2);
            TestaDnyanmiskBinding(3);
            TestaDnyanmiskBinding(4);
        }

        private void TestaDnyanmiskBinding(int choice)
        {
            Person pers;  //static binding to Person

            //Depending on the value of choice, pers will refer to 
            //different types of object (within the hierarchy)
            switch (choice)
            {
                case 1:
                    pers = new Chief();
                    break;

                case 2:
                    pers = new Salesman();
                    break;

                case 3:
                default:
                    pers = new Person();
                    break;
            }
            MessageBox.Show(pers.ToString());
        }

        public virtual int VirtualTest()
        {
            //code
            return 0;
        }

    }
}