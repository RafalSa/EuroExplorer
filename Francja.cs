﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class Francja : Form
    {
        private User user;
        public Francja(User user)
        {
            InitializeComponent();
            this.user = user;
            Task task = DisplayWeatherAsync();
        }



        public class WeatherData
        {
            public MainData? Main { get; set; }
        }

        public class MainData
        {
            public double Temp { get; set; }
        }

        private async Task DisplayWeatherAsync()
        {
            string city = "Paris";
            string countryCode = "FR";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoFrancja1.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd pobierania danych pogodowych: {ex.Message}");
            }
        }



        static async Task<WeatherData?> GetWeatherData(string city, string countryCode, string apiKey)
        {
            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city},{countryCode}&appid={apiKey}&units=metric");
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadFromJsonAsync<WeatherData?>();
                    return data;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd pobierania danych pogodowych: {ex.Message}");
                }
            }
        }

        private async Task GetCurrentTimeInParisAsync()
        {
            try
            {
                string apiKey = "22feb2021db55d19eb0608f7237cb536";
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Zagreb&appid={apiKey}&units=metric";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        int timezoneOffset = (int)data.timezone / 3600;

                        DateTime ParisTime = DateTime.UtcNow.AddHours(timezoneOffset);

                        InfoFrancja.Text = $"Aktualna godzina w Paris: {ParisTime.ToString("HH:mm:ss")}";
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił problem podczas pobierania danych z serwera.");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Błąd podczas wykonywania żądania HTTP: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await GetCurrentTimeInParisAsync();
        }

        private void InfoFrancja_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoFrancja1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            bool formFOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormF)
                {
                    formFOpen = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!formFOpen)
            {
                Form1 form1 = new Form1(user);
                form1.Show();
            }
        }

        private void bookingFrancja_Click(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingFrancja();
        }

        private void Paryz_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingParyz();
        }

        private void Lazurowe_Wybrzeze_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingLazuroweWybrzeze();
        }

        private void Lyon_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingLyon();
        }

        private void Bordeaux_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingBordeaux();
        }

        private void Marsylia_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingMarsylia();
        }
    }
}
