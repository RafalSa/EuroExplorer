using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class Menu1 : Form
    {
        public Menu1(Models.User loggedInUser)
        {
            InitializeComponent();
        }

        private void ListaPanel_Click(object sender, EventArgs e)
        {
            // Przełącz widoczność panelu
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListaPanstw_Click(object sender, EventArgs e)
        {

        }

        private void Map_Click(object sender, EventArgs e)
        {

        }

        private void Czat_Click(object sender, EventArgs e)
        {

        }
    }
}
