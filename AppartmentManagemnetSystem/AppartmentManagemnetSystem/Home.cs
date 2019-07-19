using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentManagemnetSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void apartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apartment obj = new AppartmentManagemnetSystem.Apartment();
            obj.ShowDialog();
        }

        private void entryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entry obj1 = new Entry();
            obj1.ShowDialog();
        }

        private void parkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parking obj2 = new AppartmentManagemnetSystem.Parking();
            obj2.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
