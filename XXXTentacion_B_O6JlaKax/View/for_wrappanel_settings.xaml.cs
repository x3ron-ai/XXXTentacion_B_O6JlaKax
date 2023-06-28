using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XXXTentacion_B_O6JlaKax.ViewModel;

namespace XXXTentacion_B_O6JlaKax.View
{
    /// <summary>
    /// Логика взаимодействия для for_wrappanel.xaml
    /// </summary>
    public partial class for_wrappanel : UserControl
    {
        public static readonly DependencyProperty CityNameProperty = DependencyProperty.Register(
            "CityName", typeof(string), typeof(for_wrappanel), new PropertyMetadata(string.Empty));

        public string CityName
        {
            get { return (string)GetValue(CityNameProperty); }
            set { SetValue(CityNameProperty, value); }
        }

        public static readonly DependencyProperty CityCordProperty = DependencyProperty.Register(
            "CityCord", typeof(string), typeof(for_wrappanel), new PropertyMetadata(string.Empty));

        public string CityCord
        {
            get { return (string)GetValue(CityCordProperty); }
            set { SetValue(CityCordProperty, value); }
        }

        public for_wrappanel()
        {
            InitializeComponent();
        }

    }
}
