//Programming using .NET, advanced Course
//Event-delegate example
//Farid Naisan March 2011

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BidHouseWPFCS
{
    /// <summary>
    /// This class  only serves as the main program. 
    /// It does the following:
    /// 1.  announces a bid product
    /// 2.  creates a bid manager for the product
    ///      
    /// It does the same steps 1 and 2 for each new products.    
    /// </summary>
    /// <remarks></remarks>
    public partial class MainWindow : Window
    {
        //bidding object currently being announced
        private Product m_CurrObject;


        public MainWindow()
        {
            InitializeComponent();
            
            m_CurrObject = GetTestObject();
            InitializeGUI(); 
        }

        private void InitializeGUI()
        {
            txtDescription.Text = String.Empty;

            string helpText = "This is the Main Window.  Its principal ";
            helpText += "duty is to create a control window for the management of ";
            helpText += "bidding for the selected product.\n\n" ;
            helpText += "Each control window, adds bidders, starts and stops bidding ";
            helpText += "of the product. Several control windows can run ";
            helpText += "simultaneously. Each control window and its bidders will not ";
            helpText += "interfere with other control windows or their bidders. \n\n";
            helpText += "A bidder that selects to withdraw from a bidding can rejoin only ";
            helpText += "as a new bidder.";

            lblMessage.TextWrapping = TextWrapping.Wrap;
            lblMessage.Foreground = Brushes.SlateGray;
            lblMessage.Text = helpText;

            UpdateGUI();
        }

        private void btnStartBid_Click(object sender, RoutedEventArgs e)
        {
  
            Product prod = SetupCurrentObject();
            BidManagerIsSubscriber newBidMngr = new BidManagerIsSubscriber(prod);
            newBidMngr.Show();

            //DisplayImage();

            lstStatus.Items.Add("Bid Manager for the object " + m_CurrObject.Name + " started." + DateTime.Now.ToLongTimeString());
          }
         
        #region "helper methods"

        private Product SetupCurrentObject()
        {
            m_CurrObject.Name = txtProductName.Text;
            m_CurrObject.Price = ToDecimal.GetDecimal(txtListPrice.Text, 0.0m);
            m_CurrObject.Count = ToLong.GetInteger32(txtCount.Text, 0);
            return m_CurrObject;
        }
        private void UpdateGUI()
        {
            txtCount.Text = m_CurrObject.Count.ToString();
            txtProductName.Text = m_CurrObject.Name;
            txtDescription.TextWrapping = TextWrapping.Wrap;
            txtDescription.ForceCursor = true;
            txtDescription.Foreground = Brushes.SteelBlue;
            txtDescription.ToolTip = "Editable text!";

            txtDescription.Text = m_CurrObject.Description;
            txtListPrice.Text = m_CurrObject.Price.ToString();
        }
  
        //Start with a test object 
        private Product GetTestObject()
        {
            string name = "VOLVO P1800S 1963";
            string descr = "Lovely and solid but with some signs of rust." + Environment.NewLine;
            descr += "The chassis, inner wings and floors are in great condition with no previous welding apparent.";
            return new Product(name, descr, 800.0m, 1);
        }

#endregion
    }
}


