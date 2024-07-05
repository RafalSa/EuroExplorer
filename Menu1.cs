using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;

namespace EuroExplorer
{
    public partial class Menu1 : Form
    {
        private Models.User loggedInUser;
        private static readonly HttpClient client = new HttpClient();

        public Menu1(Models.User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate("file:///C:/Users/rafal/source/repos/projektObiektowe13/templates/index.html");

        }

        private void ListaPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Możesz dodać rysowanie na panelu, jeśli jest potrzebne
        }

        private void ListaPanstw_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Lista Państw
        }

        private void Map_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Mapa
        }

        private void Czat_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Czat
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na kontrolkę WebView2, jeśli jest potrzebna
        }


    }
}
