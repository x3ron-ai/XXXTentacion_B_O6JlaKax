using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XXXTentacion_B_O6JlaKax.ViewModel.Helpers;
using System.Windows;
using System.Windows.Controls;
using XXXTentacion_B_O6JlaKax.View;
using System.Windows.Data;
using XXXTentacion_B_O6JlaKax.Model;
using System.IO;
using System.Windows.Input;
using System.Threading;

namespace XXXTentacion_B_O6JlaKax.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Команды
        public BindableCommand StartWeather { get; set; }
        public BindableCommand Page_one { get; set; }
        public BindableCommand Page_two { get; set; }
        public BindableCommand Exit { get; set; }
        public BindableCommand Save { get; set; }

        #endregion
        #region Свойства
        public Page Frame
        {
            get { return frame; }
            set
            {
                frame = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<for_wrappanel> List
        {
            get => list;
            set
            {
                list = value;
                Set(ref list, value);
            }
        }
        #endregion
        #region Переменные
        public Page frame;
        public string city;
        private ObservableCollection<for_wrappanel> list = new ObservableCollection<for_wrappanel>();
        public List<for_wrappanel> favoriteCity = new List<for_wrappanel>();
        #endregion
        public MainViewModel()
        {
            if (!File.Exists("favours.json"))
            {
                File.WriteAllText("favours.json", "[]");
            }

            if (Properties.Settings.Default.City != null && Properties.Settings.Default.City != "")
                City = Properties.Settings.Default.City;
            else City = "Ваш город";
            Frame = new Hour();
            StartWeather = new BindableCommand(_ => startweather());
            Page_one = new BindableCommand(_ => page_one());
            Page_two = new BindableCommand(_ => page_two());
            Exit = new BindableCommand(_ => exit());
            Save = new BindableCommand(_ => save());

            see_them();
        }
        private void startweather()
        {
            if (city == null || city == "" || city == "Ваш город")
            {
                MessageBox.Show("Ошибка ввода!");
                Environment.Exit(0);
            }
            Properties.Settings.Default.City = city;
            Properties.Settings.Default.Save();
            Second s = new Second();
            s.Show();
        }
        private void page_one()
        {
            Frame = new Hour();
        }
        private void page_two()
        {
            Frame = new Settings();
            List.Add(new for_wrappanel());
        }
        async void see_them()
        {
            while (true)
            {
                await set_them();
            }
        }
        async Task set_them()
        {
            string them = "";
            List<List<int>> times = new List<List<int>>()
            {
                new List<int> { 0,1,2,3 },
                new List<int> {4,5,6,7,8,9,10,11,17,18,19,20,21,22,23},
                new List<int> { 12,13,14,15 },
            };
            if (times[0].Contains(Convert.ToInt32(DateTime.Now.Hour)))
                them = "Night";
            if (times[1].Contains(Convert.ToInt32(DateTime.Now.Hour)))
                them = "MorningEvening";
            if (times[2].Contains(Convert.ToInt32(DateTime.Now.Hour)))
                them = "Night";
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Insert(0, new ResourceDictionary { Source = new Uri($"pack://application:,,,/Style;component/{them}.xaml") });
            await Task.Delay((60 - Convert.ToInt32(DateTime.Now.Minute)) * 6000);
        }
        void exit()
        {
            Environment.Exit(0);
        }
        void save()
        {
            City = "";
        }
    }
}
