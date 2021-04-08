﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork6_7.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyBasket.xaml
    /// </summary>
    public partial class MyBasket : Page
    {
        public MyBasket()
        {
            InitializeComponent();

            DataContext = new MyBasketViewModel();
        }
    }
}
