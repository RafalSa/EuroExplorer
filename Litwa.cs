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
    public partial class Litwa : Form
    {
        private User user;
        public Litwa(User user)
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
            string city = "Vilnius";
            string countryCode = "LT";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoLitwa1.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
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

        private async Task GetCurrentTimeInVilniusAsync()
        {
            try
            {
                string apiKey = "22feb2021db55d19eb0608f7237cb536";
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Vilnius&appid={apiKey}&units=metric";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        int timezoneOffset = (int)data.timezone / 3600;

                        DateTime VilniusTime = DateTime.UtcNow.AddHours(timezoneOffset);

                        InfoLitwa.Text = $"Aktualna godzina w Vilnius: {VilniusTime.ToString("HH:mm:ss")}";
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
            await GetCurrentTimeInVilniusAsync();
        }

        private void InfoLitwa_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoLitwa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            bool formLOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormL)
                {
                    formLOpen = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!formLOpen)
            {
                Form1 form1 = new Form1(user);
                form1.Show();
            }
        }

        private void bookingLitwa_Click(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingLitwa();
        }

        private void Wilno_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingWilno();
        }

        private void Kowno_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingKowno();
        }

        private void Klajpeda_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingKlajpeda();
        }

        private void Druskienniki_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingDruskienniki();
        }

        private void Troki_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingTroki();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
