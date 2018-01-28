using System;
using System.Windows.Forms;

// TODO: Man ska kunna lägga till nya djur
// TODO: Man ska kunna ange data för ett djur
// TODO: Man ska kunna ange en kategori för ett djur man vill lägga till

namespace Assignment1
{
    public partial class MainForm : Form
    {
        AnimalManager _animalManager = new AnimalManager();

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
