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

namespace XXXTentacion_B_O6JlaKax.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Команды
        public BindableCommand StartWeather { get; set; }
        public BindableCommand page1 { get; set; }

        #endregion
        public Page Frame
        {
            get { return frame; }
            set
            {
                frame = value;
                OnPropertyChanged();
            }
        }
        #region Свойства

        #endregion
        public Page frame;


        public MainViewModel()
        {
            Frame = new Settings();
        }
        private void startweather(object sender, RoutedEventArgs e)
        {

        }
        public void page_one()
        {

        }
        public void page_two()
        {

        }
    }
}
