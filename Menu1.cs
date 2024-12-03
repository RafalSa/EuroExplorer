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

        public async void NavigateToBookingDubrownik()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hr/dubrovnik.pl.html");


        }

        public async void NavigateToBookingSplit()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hr/split.pl.html");


        }

        public async void NavigateToBookingZagrzeb()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hr/zagreb.pl.html");


        }

        public async void NavigateToBookingZadar()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hr/zadar.pl.html");


        }

        public async void NavigateToBookingIstria()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/hr/istria.pl.html");


        }

        public async void NavigateToBookingChorwacja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/hr.pl.html");


        }

        public async void NavigateToBookingNikozja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cy/nicosia.pl.html");


        }

        public async void NavigateToBookingLimassol()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cy/limassol.pl.html");


        }

        public async void NavigateToBookingPafos()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cy/paphos.pl.html");


        }

        public async void NavigateToBookingLarnaka()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cy/larnaca.pl.html");


        }

        public async void NavigateToBookingAyiaNapa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cy/ayia-napa.pl.html");


        }

        public async void NavigateToBookingCypr()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/cy.pl.html");


        }

        public async void NavigateToBookingPraga()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cz/prague.pl.html");


        }

        public async void NavigateToBookingBrno()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cz/brno.pl.html");


        }

        public async void NavigateToBookingCzeskiKrumlov()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cz/cesky-krumlov.pl.html");


        }

        public async void NavigateToBookingKarloweWary()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cz/karlovy-vary.pl.html");


        }

        public async void NavigateToBookingOstrawa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/cz/ostrava.pl.html");


        }

        public async void NavigateToBookingCzechy()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/cz.pl.html");


        }

        public async void NavigateToBookingKopenhaga()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/dk/copenhagen.pl.html");


        }

        public async void NavigateToBookingAarhus()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/dk/aarhus.pl.html");


        }

        public async void NavigateToBookingOdense()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/dk/odense.pl.html");


        }

        public async void NavigateToBookingAalborg()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/dk/aalborg.pl.html");


        }

        public async void NavigateToBookingBornholm()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/dk/bornholm.pl.html");


        }

        public async void NavigateToBookingDania()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/dk.pl.html");


        }

        public async void NavigateToBookingTallin()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ee/tallinn.pl.html");


        }

        public async void NavigateToBookingTartu()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ee/tartu.pl.html");


        }

        public async void NavigateToBookingParnu()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ee/parnu.pl.html");


        }

        public async void NavigateToBookingNarwa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ee/narva.pl.html");


        }

        public async void NavigateToBookingWyspaSaaremaa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/ee/saaremaa.pl.html");


        }

        public async void NavigateToBookingEstonia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/ee.pl.html");


        }

        public async void NavigateToBookingHelsinki()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fi/helsinki.pl.html");


        }

        public async void NavigateToBookingRovaniemi()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fi/rovaniemi.pl.html");


        }

        public async void NavigateToBookingTurku()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fi/turku.pl.html");


        }

        public async void NavigateToBookingTampere()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fi/tampere.pl.html");


        }

        public async void NavigateToBookingWyspyAlandzkie()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/fi/land.pl.html");


        }

        public async void NavigateToBookingFinlandia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/fi.pl.html");


        }

        public async void NavigateToBookingParyz()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fr/paris.pl.html");


        }

        public async void NavigateToBookingLazuroweWybrzeze()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/fr/riviera.pl.html?aid=1610843");


        }

        public async void NavigateToBookingLyon()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fr/lyon.pl.html");


        }

        public async void NavigateToBookingBordeaux()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fr/bordeaux.pl.html");


        }

        public async void NavigateToBookingMarsylia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/fr/marseille.pl.html");


        }

        public async void NavigateToBookingFrancja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/fr.pl.html");


        }

        public async void NavigateToBookingAteny()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/gr/athens.pl.html");


        }

        public async void NavigateToBookingSantorini()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/gr/santorini.pl.html");


        }

        public async void NavigateToBookingKreta()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/gr/crete.pl.html");


        }

        public async void NavigateToBookingMykonos()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/gr/mykonos.pl.html");


        }

        public async void NavigateToBookingRodos()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/gr/rhodes.pl.html");


        }

        public async void NavigateToBookingGrecja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/gr.pl.html");


        }

        public async void NavigateToBookingMadryt()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/es/madrid.pl.html");


        }

        public async void NavigateToBookingBarcelona()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/es/barcelona.pl.html");


        }

        public async void NavigateToBookingSewilla()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/es/sevilla.pl.html");


        }

        public async void NavigateToBookingWalencja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/es/valencia.pl.html");


        }

        public async void NavigateToBookingGranada()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/es/granada.pl.html");


        }

        public async void NavigateToBookingHiszpania()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/es.pl.html");


        }

        public async void NavigateToBookingAmsterdam()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/nl/amsterdam.pl.html");


        }

        public async void NavigateToBookingRotterdam()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/nl/rotterdam.pl.html");


        }

        public async void NavigateToBookingHaga()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/nl/den-haag.pl.html");


        }

        public async void NavigateToBookingUtrecht()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/nl/utrecht.pl.html");


        }

        public async void NavigateToBookingMaastricht()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/nl/maastricht.pl.html");


        }

        public async void NavigateToBookingHolandia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/nl.pl.html");


        }

        public async void NavigateToBookingDublin()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ie/dublin.pl.html");


        }

        public async void NavigateToBookingGalway()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ie/galway.pl.html");


        }

        public async void NavigateToBookingCork()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ie/cork.pl.html");


        }

        public async void NavigateToBookingLimerick()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ie/limerick.pl.html");


        }

        public async void NavigateToBookingKilkenny()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ie/kilkenny.pl.html");


        }

        public async void NavigateToBookingIrlandia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/ie.pl.html");


        }
        public async void NavigateToBookingMiastoLuksemburg()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lu/luxembourg.pl.html");


        }

        public async void NavigateToBookingVianden()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lu/vianden.pl.html");


        }

        public async void NavigateToBookingEchternach()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lu/echternach.pl.html");


        }

        public async void NavigateToBookingClervaux()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lu/clervaux.pl.html");


        }

        public async void NavigateToBookingEschsurSure()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lu/esch-sur-sure.pl.html");


        }

        public async void NavigateToBookingLuksemburg()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/lu.pl.html");


        }

        public async void NavigateToBookingWilno()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lt/vilnius.pl.html");


        }

        public async void NavigateToBookingKowno()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lt/kaunas.pl.html");


        }

        public async void NavigateToBookingKlajpeda()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lt/klaipeda.pl.html");


        }

        public async void NavigateToBookingDruskienniki()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lt/druskininkai.pl.html");


        }

        public async void NavigateToBookingTroki()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lt/trakai.pl.html");


        }

        public async void NavigateToBookingLitwa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/lt.pl.html");


        }

        public async void NavigateToBookingŁotwa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/lv.pl.html");


        }

        public async void NavigateToBookingLiepaja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lv/liepaja.pl.html");


        }

        public async void NavigateToBookingKuldiga()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lv/kuldiga.pl.html");


        }

        public async void NavigateToBookingSigulda()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lv/sigulda.pl.html");


        }

        public async void NavigateToBookingJurmala()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lv/jurmala.pl.html");


        }

        public async void NavigateToBookingRyga()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/lv/riga.pl.html");


        }

        public async void NavigateToBookingValletta()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/mt/valletta.pl.html");


        }

        public async void NavigateToBookingMdina()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/mt/mdina.pl.html");


        }

        public async void NavigateToBookingSliema()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/mt/sliema.pl.html");


        }

        public async void NavigateToBookingGozo()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Gozo%2C+Malta");


        }

        public async void NavigateToBookingMarsaxlokk()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/mt/marsaxlokk.pl.html");


        }

        public async void NavigateToBookingMalta()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/mt.pl.html");


        }

        public async void NavigateToBookingNiemcy()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/de.pl.html");


        }

        public async void NavigateToBookingDrezno()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/de/dresden.pl.html");


        }

        public async void NavigateToBookingKolonia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/de/cologne.pl.html");


        }

        public async void NavigateToBookingHafenstadtHamburg()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/de/hamburg.pl.html\r\n");


        }

        public async void NavigateToBookingMonachium()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/de/munich.pl.html");


        }

        public async void NavigateToBookingBerlin()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/de/berlin.pl.html");


        }

        public async void NavigateToBookingWarszawa()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pl/warsaw.pl.html");


        }

        public async void NavigateToBookingKrakow()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pl/krakow.pl.html");


        }

        public async void NavigateToBookingWroclaw()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pl/wroclaw.pl.html");


        }

        public async void NavigateToBookingGdansk()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pl/gdansk.pl.html");


        }

        public async void NavigateToBookingZakopane()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pl/zakopane.pl.html");


        }

        public async void NavigateToBookingPolska()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/pl.pl.html");


        }

        public async void NavigateToBookingLizbona()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pt/lisbon.pl.html");


        }

        public async void NavigateToBookingPorto()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pt/porto.pl.html");


        }

        public async void NavigateToBookingFunchal()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pt/funchal.pl.html");


        }

        public async void NavigateToBookingAlbufeira()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pt/albufeira.pl.html");


        }

        public async void NavigateToBookingSintra()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/pt/sintra.pl.html");


        }

        public async void NavigateToBookingPortugalia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/pt.pl.html");


        }

        public async void NavigateToBookingBukareszt()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ro/bucharest.pl.html");


        }

        public async void NavigateToBookingBran()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Bran%2C+Rumunia&dest_id=-1153567&dest_type=city");


        }

        public async void NavigateToBookingSighişoara()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ro/sighisoara.pl.html");


        }

        public async void NavigateToBookingSybin()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/ro/sibiu.pl.html");


        }

        public async void NavigateToBookingTransylwania()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/ro/transylvania.pl.html");


        }

        public async void NavigateToBookingRumunia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/ro.pl.html");


        }

        public async void NavigateToBookingBratysława()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/sk/bratislava.pl.html");


        }

        public async void NavigateToBookingTatryWysokie()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Tatry+Wysokie%2C+S%C5%82owacja&dest_type=region&dest_id=2039");


        }

        public async void NavigateToBookingKoszyce()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/sk/kosice.pl.html");


        }

        public async void NavigateToBookingZamekSpiski()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/sk/levoca.pl.html");


        }

        public async void NavigateToBookingBanskaSzczawnica()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/sk/banska-stiavnica.pl.html");


        }

        public async void NavigateToBookingSlowacja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/sk.pl.html");


        }

        public async void NavigateToBookingLublana()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/si/ljubljana.pl.html");


        }

        public async void NavigateToBookingBled()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/si/bled.pl.html");


        }

        public async void NavigateToBookingPostojna()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Postojna");


        }

        public async void NavigateToBookingPiran()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/si/piran.pl.html");


        }


        public async void NavigateToBookingTriglavski()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Centrum+informacyjne+Triglavskiego+Parku+Narodowego");


        }

        public async void NavigateToBookingSlowenia()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/si.pl.html");


        }


        public async void NavigateToBookingSztokholm()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/se/stockholm.pl.html");


        }

        public async void NavigateToBookingGoeteborg()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/se/goteborg.pl.html");


        }

        public async void NavigateToBookingMalmo()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/se/malmo.pl.html");


        }

        public async void NavigateToBookingKiruna()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/se/kiruna.pl.html");


        }


        public async void NavigateToBookingSzwecja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/se.pl.html");


        }

        public async void NavigateToBookingPark_Narodowy_Abisko()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Abisko+National+Park%2C+Szwecja");


        }

        public async void NavigateToBookingBudapeszt()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hu/budapest.pl.html");


        }

        public async void NavigateToBookingDebreczyn()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hu/debrecen.pl.html");


        }

        public async void NavigateToBookingSzeged()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hu/szeged.pl.html");


        }

        public async void NavigateToBookingBalaton()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/searchresults.pl.html?ss=Jezioro+Balaton");


        }

        public async void NavigateToBookingEger()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/hu/eger.pl.html");


        }

        public async void NavigateToBookingWegry()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/hu.pl.html");


        }

        public async void NavigateToBookingRzym()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/it/rome.pl.html");


        }

        public async void NavigateToBookingWenecja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/it/venice.pl.html");


        }

        public async void NavigateToBookingFlorencja()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/it/florence.pl.html");


        }

        public async void NavigateToBookingNeapoliPompeje()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/city/it/naples.pl.html");


        }

        public async void NavigateToBookingJezioroGarda()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/region/it/lake-garda.pl.html");


        }

        public async void NavigateToBookingWlochy()
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
            webView21.CoreWebView2.Navigate("https://www.booking.com/country/it.pl.html");


        }
    }
}
