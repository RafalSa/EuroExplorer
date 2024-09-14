﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using EuroExplorer.Models;

namespace EuroExplorer
{
    public partial class Austria : Form
    {
        private User loggedInUser;

        public Austria(User user)
        {
            InitializeComponent();
            loggedInUser = user;
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
            string city = "Wiedeń";
            string countryCode = "AT";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoAustria1.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
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

        private async Task GetCurrentTimeInViennaAsync()
        {
            try
            {
                string apiKey = "22feb2021db55d19eb0608f7237cb536";
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Vienna&appid={apiKey}";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        int timezoneOffset = data.timezone;

                        TimeZoneInfo viennaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");

                        DateTime viennaTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, viennaTimeZone);

                        InfoAustria.Text = $"Aktualna godzina w Wiedeń: {viennaTime.ToString("HH:mm:ss")}";
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił problem podczas pobierania danych z serwera.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await GetCurrentTimeInViennaAsync();
        }

        private void OpisAustrii_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoAustria_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoAustria1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            bool formAOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormA)
                {
                    formAOpen = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!formAOpen)
            {
                Form1 form1 = new Form1(loggedInUser);
                form1.Show();
            }
        }

        private void bookingAustria_Click(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingAustria();
        }

        private void Wieden_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingWiedeń();
        }

        private void Salzburg_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingSalzburg();
        }

        private void Innsbruck_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingInnsbruck();
        }

        private void Hallstatt_i_region_Salzkammergut_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingHallstatt_i_region_Salzkammergut();
        }

        private void Tyrol_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(loggedInUser);
            menu1.Show();
            menu1.NavigateToBookingTyrol();
        }
    }
}
