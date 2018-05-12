using System;
using System.Windows;

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Invoice currentInvoice;

        public MainWindow()
        {
            InitializeComponent();
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
            if (null != currentInvoice) {
                var ci = currentInvoice;
                lblInvoiceNumber.Content = currentInvoice.InvoiceNumber;
                txtInvoiceDate.Text = ci.InvoiceDate.ToShortDateString();
                txtDueDate.Text = ci.DueDate.ToShortDateString();
                txtReceiver.Text = ci.Receiver.ToString();
            }
        }
    }
}
