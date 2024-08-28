using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace EuroExplorer
{
    public partial class Menu1 : Form
    {
        private Models.User loggedInUser;

        public Menu1(Models.User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;

            // Inicjalizuj WebView2
            InitializeWebView2Async();
        }

        private async void InitializeWebView2Async()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                // Możesz ustawić początkowy adres URL dla WebView2 tutaj, jeśli chcesz
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing WebView2: {ex.Message}");
            }
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
            Form1 f31 = new Form1(loggedInUser);
            f31.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Map_Click(object sender, EventArgs e)
        {
 
        }

        private void Czat_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na przycisk Czat
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            // Obsługa kliknięcia na webView21, jeśli to potrzebne
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {
            // Obsługa zmiany tekstu w Message, jeśli to potrzebne
        }

        private void webView21_Click_1(object sender, EventArgs e)
        {
            // Możesz użyć tej metody, jeśli potrzebujesz dodatkowej obsługi kliknięcia
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                // Navigate to Booking.com in the WebView2 control
                webView21.CoreWebView2.Navigate("https://www.booking.com/");
            }
            else
            {
                MessageBox.Show("WebView2 is not initialized yet.");
            }
        }

        private void BNB_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                // Navigate to Airbnb in the WebView2 control
                webView21.CoreWebView2.Navigate("https://www.airbnb.pl/");
            }
            else
            {
                MessageBox.Show("WebView2 is not initialized yet.");
            }
        }


    }
}
