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

namespace Pet_Shop
{
    /// <summary>
    /// Логика взаимодействия для Отчёт.xaml
    /// </summary>
    public partial class Отчёт : Page
    {
        public Отчёт()
        {
            InitializeComponent();
            txtRaba.Content = "За смену заработано: " + Manager.Prib;
            txtRab.Content = "Потраченно на поставках:" + Manager.Trat;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Manager.Forma.GoBack();
        }
    }
}
