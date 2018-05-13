using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Invoice currentInvoice = new Invoice();
        private bool initialized = false;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            initialized = true;
            UpdateGui();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
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
                    currentInvoice = new InvoiceReader(filename).GetInvoice();
                    panelAll.IsEnabled = true;
                    UpdateGui();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Invalid invoice file. Try a different file.", "Error: Invalid file");
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Invalid invoice file. Try a different file.", "Error: Invalid file");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected exception when reading invoice file. Try again.", "Error");
                }
            }
        }

        private void UpdateGui()
        {
            if (initialized && (null != currentInvoice)) {
                var ci = currentInvoice;
                lblInvoiceNumber.Content = currentInvoice.InvoiceNumber;
                txtInvoiceDate.Text = ci.InvoiceDate.ToShortDateString();
                txtDueDate.Text = ci.DueDate.ToShortDateString();
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

        private void TxtDiscount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            currentInvoice.Discount = Double.Parse(txtDiscount.Text);
            UpdateGui();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuLogo_Click(object sender, RoutedEventArgs e)
        {
            // https://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp 

            // Create OpenFileDialog
            var dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Image files (*.png)|*.png";

            // Display dialog
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;

                try
                {
                    var uri = new Uri(filename); //, UriKind.Relative);
                    imgLogo.Source = new BitmapImage(uri);
                }
                catch (NotImplementedException ex)
                {
                    MessageBox.Show("Bad image file. Try a different file", "Error: Invalid file");
                }
            }
        }
    }
}
