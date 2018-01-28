using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager = new AnimalManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            throw new NotImplementedException();
        }
    }
}
