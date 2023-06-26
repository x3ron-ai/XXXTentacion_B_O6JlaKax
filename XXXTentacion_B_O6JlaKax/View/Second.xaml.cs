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
using System.Windows.Shapes;
using XXXTentacion_B_O6JlaKax.ViewModel;

namespace XXXTentacion_B_O6JlaKax
{
    /// <summary>
    /// Логика взаимодействия для Second.xaml
    /// </summary>
    public partial class Second : Window
    {
        public Second()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
