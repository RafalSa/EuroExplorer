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


            InitializeWebView2Async();
        }

        private async void InitializeWebView2Async()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);

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

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
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
                webView21.CoreWebView2.Navigate("https://www.airbnb.pl/");
            }
            else
            {
                MessageBox.Show("WebView2 is not initialized yet.");
            }
        }
        public async void NavigateToBookingAustria()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.html?ss=Austria&ssne=Austria&ssne_untouched=Austria&dest_id=14&dest_type=country");


        }

        public async void NavigateToBookingWiedeń()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/at/vienna.pl.html");


        }

        public async void NavigateToBookingSalzburg()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/at/salzburg.pl.html");


        }

        public async void NavigateToBookingInnsbruck()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/at/innsbruck.pl.html");


        }

        public async void NavigateToBookingHallstatt_i_region_Salzkammergut()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/at/hallstatt.pl.html");


        }

        public async void NavigateToBookingTyrol()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/at/tirol.pl.html");


        }

        public async void NavigateToBookingBruksela()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/be/brussels.pl.html");


        }

        public async void NavigateToBookingBrugia()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/be/brugge.pl.html");


        }

        public async void NavigateToBookingAntwerpia()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/be/antwerpen.pl.html");


        }

        public async void NavigateToBookingGandawa()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/be/gent.pl.html");


        }

        public async void NavigateToBookingArdeny()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/be/ardennes.pl.html");


        }

        public async void NavigateToBookingBelgia()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/be.pl.html");


        }

        public async void NavigateToBookingSofia()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/bg/sofia.pl.html");


        }

        public async void NavigateToBookingPlowdiw()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/bg/plovdiv.pl.html");


        }

        public async void NavigateToBookingWarna()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/bg/varna.pl.html");


        }

        public async void NavigateToBookingBansko()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/bg/bansko.pl.html");


        }

        public async void NavigateToBookingRilskie_Gory_i_Monastyr_Rilski()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/bg/rila-mountains.pl.html");


        }

        public async void NavigateToBookingBulgaria()
        {
            if (webView21.CoreWebView2 == null)
            {
                // Spróbuj zainicjalizować WebView2, jeśli jeszcze nie zostało zainicjalizowane
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing WebView2: {ex.Message}");
                    return;
                }
            }

            // Teraz wykonaj nawigację, gdy WebView2 jest gotowe
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/bg.pl.html");


        }


    }
}
