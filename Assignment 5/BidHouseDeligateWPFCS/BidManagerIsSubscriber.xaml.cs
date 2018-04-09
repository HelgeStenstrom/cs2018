//Programming using .NET, advanced Course
//Event-delegate example
//Farid Naisan March 2011


//A Subscriber class  (a listerner)

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
using System.Windows.Shapes;
using System.Diagnostics;

namespace BidHouseWPFCS
{
    /// <summary>
    /// This class creates a bidder for a bidding auction
    /// but does not save the info on the bidder or keep track of the
    /// bidders.
    /// Receives new bids from bidders when a bidder sends a new offer, or
    /// when the bidder withdraws from bidding.
    /// This class is mainly a subscriber of the events fired by 
    /// the Bidder class.
    /// </summary>
    /// <remarks></remarks>

    public partial class BidManagerIsSubscriber : Window
    {
        private bool bidStarted = false;
        private bool bidEnded = false;
  	    private Product m_newBidObject = null;
	    private decimal m_currentAmount = 0.0m;

        public BidManagerIsSubscriber(Product prod)
        {
            InitializeComponent();
            m_newBidObject = prod;
            InitializeGUI();
        }

        public void InitializeGUI() 
        {
            btnStart.IsEnabled = false;
            btnEnd.IsEnabled = false;
            UpdateGUI();  //m_newBidObject must be valid
        }

        //Create a new bidder object and subscribe to its events
        private void CreateNewBidder()
        {
            string bidderName = ReadBidderName();

            //Create the new bidder
            if (!string.IsNullOrEmpty(bidderName))
            {
                BidderIsPublisher frm = new BidderIsPublisher(txtName.Text, m_newBidObject.Name);
                frm.Show();

                //Subscribe to the publisher's new bid and quit bid events
                frm.NewBid += OnNewBidSent;
                frm.QuitBid += OnBidderDrawBack;
            }
        }

        //###############################################################################
        /// <summary>
        ///  From this line on no information available on the bidder that is just created.
        ///  Here is the power of delegates - who is the bidder - don't know,
        ///  the sender tells us at run time
        /// 
        ///  Eventhandler for the SendNewBid event - what to do when the event is 
        ///  fired by the publisher object (a bidder class, see above)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNewBidSent(object sender, BidEventInfo e)
        {
            if (!AcceptBid())
                return;

            string strError = "<= current amount - not valid! ";
            string strOut = string.Format("{0} places a new bid {1,0:f2}", e.Bidder, e.Amount);

            if (!CheckIfbidisValid(e.Amount))
                strOut += strError;
            else
                m_currentAmount = e.Amount;

            lstBidHistory.Items.Add(strOut);
        }


        /// <summary>
        ///  Here is the power of delegates - who is the bidder - don't know,
        ///  the sender tells us at run time
        ///  Eventhandler for the sender's (bidder's) SendQuitBid event - what to do when the event is 
        ///  fired by the publisher object (a bidder class, see above)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void OnBidderDrawBack(object sender, BidEventInfo e)
        {
            lstBidHistory.Items.Add(string.Format("{0} draws back at {1}. Please come back!", 
                                  e.Bidder, DateTime.Now.ToShortTimeString()));

            if (sender != null)
            {
                BidderIsPublisher frm = (BidderIsPublisher)sender;

                //Unubscribe to the publisher's new bid and quit bid events
                //Compare with above (subscription)
                frm.NewBid -= OnNewBidSent;
                frm.QuitBid -= OnBidderDrawBack;
                frm.Title = "You are out! " + DateTime.Now.ToShortTimeString();              
            }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CreateNewBidder();
            UpdateStatus();
            btnStart.IsEnabled = true;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnEnd.IsEnabled = true;
            btnStart.IsEnabled = false;
            bidStarted = true;
            lstBidHistory.Items.Add(string.Format("Bidding started at {0}.", DateTime.Now.ToShortTimeString()));
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = false;
            btnEnd.IsEnabled = false;
            bidEnded = true;
            lstBidHistory.Items.Add(string.Format("Bidding started at {0}.", DateTime.Now.ToShortTimeString()));
        }

        #region "helper functions"

        /// <summary>
        /// Read the name of the new bidde
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        private string ReadBidderName()
        {
            //take away the starting and trailing spaces
            txtName.Text.Trim();
            
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Must provide a name!");
                return string.Empty;
            }
            return txtName.Text;
        }

        private void UpdateStatus()
        {
            string textOut = txtName.Text + " joined this bidding at ";

            textOut += DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString() + ".";
            lstBidHistory.Items.Add(textOut + " Welcome!");
        }

        //New bidamount must be greater the current amount
        private bool CheckIfbidisValid(decimal amount)
        {
            return (amount > m_currentAmount);        
        }

        public void UpdateGUI()
        {
            lblDescription.TextAlignment = TextAlignment.Justify;
            lblDescription.TextWrapping = TextWrapping.Wrap;
            lblDescription.Foreground = Brushes.Thistle;
            lblDescription.Text = m_newBidObject.Description;
        }


        private bool AcceptBid()
        {
            if (!bidStarted)
            {
                MessageBox.Show("Sorry.  Bidding has not yet started!");
                return false;
            }
            
            if (bidEnded)
            {
                MessageBox.Show("Sorry.  Bidding has ended!");
                return false;
            }
            return true;
        }
        #endregion

 


    }

}
