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
    public partial class Luksemburg : Form
    {
        private User user;
        public Luksemburg(User user)
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
            string city = "Luxembourg";
            string countryCode = "LU";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoLuksemburg1.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
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

        private async Task GetCurrentTimeInLuxembourgAsync()
        {
            try
            {
                string apiKey = "22feb2021db55d19eb0608f7237cb536";
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Luxembourg&appid={apiKey}&units=metric";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        int timezoneOffset = (int)data.timezone / 3600;

                        DateTime LuxembourgTime = DateTime.UtcNow.AddHours(timezoneOffset);

                        InfoLuksemburg.Text = $"Aktualna godzina w Luxembourg: {LuxembourgTime.ToString("HH:mm:ss")}";
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
            await GetCurrentTimeInLuxembourgAsync();
        }

        private void InfoLuksemburg_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoLuksemburg1_TextChanged(object sender, EventArgs e)
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

        private void bookingLuksemburg_Click(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingLuksemburg();

        }

        private void Miasto_Luksemburg_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingMiastoLuksemburg();
        }

        private void Vianden_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingVianden();
        }

        private void Echternach_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingEchternach();
        }

        private void Clervaux_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingClervaux();
        }

        private void Esch_sur_Sure_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingEschsurSure();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
