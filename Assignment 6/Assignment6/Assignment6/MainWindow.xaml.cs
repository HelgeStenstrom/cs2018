// Helge Stenström 
// ah7875
// C# del II 2018

using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// The invoice that the form works on. Initially an empty default invoice.
        /// </summary>
        private Invoice _currentInvoice = new Invoice();

        /// <summary>
        /// True when the current invoice is initialized from an invoice file.
        /// </summary>
        private bool _initialized = false;

        /// <summary>
        /// Default constructor. Create the GUI components an do some initialization.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _initialized = true;
            InitializeGui();
        }

        /// <summary>
        /// Do some GUI initialization. For now, the general UpdateGui method is called.
        /// </summary>
        private void InitializeGui()
        {
            UpdateGui();
        }

        /// <summary>
        /// Called when Open Invoice is selected in the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInvoice_Click(object sender, RoutedEventArgs e)
        {
            // https://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp 

            // Create OpenFileDialog
            var dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Invoice files (*.txt)|*.txt";

            // Display dialog
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
                try
                {
                    _currentInvoice = new InvoiceReader(filename).GetInvoice();
                    panelAll.IsEnabled = true;
                    UpdateGui();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid invoice file. Try a different file.", "Error: Invalid file");
                }

                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Invalid invoice file. Try a different file.", "Error: Invalid file");
                }

                catch (Exception)
                {
                    MessageBox.Show("Unexpected exception when reading invoice file. Try again.", "Error");
                }
            }
        }

        /// <summary>
        /// Update the GUI components, using information from the current invoice
        /// </summary>
        private void UpdateGui()
        {// _initialized &&
            if (_initialized && (null != _currentInvoice)) {
                var ci = _currentInvoice;
                lblInvoiceNumber.Content = _currentInvoice.InvoiceNumber;
                //txtInvoiceDate.Text = ci.InvoiceDate.ToShortDateString();
                dpInvoice.SelectedDate = ci.InvoiceDate;
                dpDue.SelectedDate = ci.DueDate;
                //txtDueDate.Text = ci.DueDate.ToShortDateString();
                txtReceiver.Text = ci.Receiver.ToString();
                lblTotalTax.Content = $"{ci.TotalTax:f2}";
                lblTotalAmount.Content = $"{ci.Total:f2}";
                lblToPay.Content = $"{ci.ToPay:f2}";

                lvInvoiceItems.ItemsSource = null;
                lvInvoiceItems.ItemsSource = ci.Items;
                lblCompany.Content = ci.Sender.CompanyName;


                var footerText = $"{ci.Sender.CompanyName}\n{ci.Sender.Street}\n{ci.Sender.Zip} {ci.Sender.City}\n";
                footerText += $"Phone: {ci.Phone}\n";
                footerText += $"Web: {ci.WebAddress}\n";
                txtFooter.Text = footerText;

            }
        }

        /// <summary>
        /// Called when the value in the discount box is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtDiscount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            try
            {
                _currentInvoice.Discount = Double.Parse(txtDiscount.Text);

                UpdateGui();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bad number. Only decimal values allowed.", "Error: Invalid value");
            }
        }

        /// <summary>
        /// Called when the Logo is clicked. The Logo is in a button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangeLogo();
        }

        /// <summary>
        /// Called when the menu item for changing logo is selected.
        /// </summary>
        private void mnuLogo_Click(object sender, RoutedEventArgs e)
        {
            ChangeLogo();
        }

        /// <summary>
        /// Changes the logo, by first bringing up a file picker dialog, and then update the source of the log.
        /// </summary>
        private void ChangeLogo()
        {
            // https://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp 

            // Create OpenFileDialog
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter = "PNG files (*.png)|*.png"
            };


            // Display dialog
            var result = dlg.ShowDialog();

            if (result != true) return;
            // Open document
            var filename = dlg.FileName;

            try
            {
                var uri = new Uri(filename); //, UriKind.Relative);
                imgLogo.Source = new BitmapImage(uri);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bad image file. Try a different file", "Error: Invalid file");
            }
        }

        /// <summary>
        /// Update the invoice date of the current invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInvoiceDate_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // https://www.dotnetperls.com/datepicker-wpf
            // ... Get nullable DateTime from SelectedDate.
            if (dpInvoice.SelectedDate != null)
                _currentInvoice.InvoiceDate = dpInvoice.SelectedDate.Value;
            UpdateGui();
        }

        /// <summary>
        /// Update the due date of the current invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDueDate_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dpDue.SelectedDate != null)
                _currentInvoice.DueDate = dpDue.SelectedDate.Value;
            UpdateGui();
        }
    }
}
