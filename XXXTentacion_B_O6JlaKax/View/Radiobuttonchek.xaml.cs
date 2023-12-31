﻿using System;
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
    /// Логика взаимодействия для Radiobuttonchek.xaml
    /// </summary>
    public partial class Radiobuttonchek : UserControl
    {
        public static readonly DependencyProperty property = DependencyProperty.Register("Title", typeof(string), typeof(Radiobuttonchek), new PropertyMetadata(string.Empty));
        public string Title
        {
            get { return (string)GetValue(property); }
            set { SetValue(property, value); }
        }

        public Radiobuttonchek()
        {
            InitializeComponent();
        }
    }
}
