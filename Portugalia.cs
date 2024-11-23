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
    public partial class Portugalia : Form
    {
        private User user;
        public Portugalia(User user)
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
            string city = "Lisbon";
            string countryCode = "PT";
            string openWeatherMapApiKey = "22feb2021db55d19eb0608f7237cb536";

            try
            {
                var weatherData = await GetWeatherData(city, countryCode, openWeatherMapApiKey);

                if (weatherData != null)
                {
                    InfoPortugalia1.Text = $"Aktualna temperatura w {city}, {countryCode}: {weatherData.Main?.Temp}°C";
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

        private async Task GetCurrentTimeInLisbonAsync()
        {
            try
            {
                string apiKey = "22feb2021db55d19eb0608f7237cb536";
                string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q=Lisbon&appid={apiKey}&units=metric";

                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        dynamic data = JObject.Parse(json);

                        int timezoneOffset = (int)data.timezone / 3600;

                        DateTime LisbonTime = DateTime.UtcNow.AddHours(timezoneOffset);

                        InfoPortugalia.Text = $"Aktualna godzina w Lisbon: {LisbonTime.ToString("HH:mm:ss")}";
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
            await GetCurrentTimeInLisbonAsync();
        }

        private void InfoPortugalia_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoPortugalia1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            bool formPOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormP)
                {
                    formPOpen = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!formPOpen)
            {
                Form1 form1 = new Form1(user);
                form1.Show();
            }
        }

        private void Lizbona_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingLizbona();
        }

        private void Porto_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingPorto();
        }

        private void Funchal_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingFunchal();

        }

        private void Albufeira_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingAlbufeira();

        }

        private void Sintra_booking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingSintra();
        }

        private void bookingPortugalia_Click(object sender, EventArgs e)
        {
            Menu1 menu1 = new Menu1(user);
            menu1.Show();
            menu1.NavigateToBookingPortugalia();
        }
    }
}
