﻿using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        static string imgPath = @"C:\Users\Anton\source\repos\pacei_NV_OOTP\лабораторные\решения\LabWork6_7(WPF)\Images\Add_Photo_Icon.png";

        public AddProduct()
        {
            InitializeComponent();

            this.photo.SetValue(Image.SourceProperty, (new ImageSourceConverter()).ConvertFromString(imgPath));
        }
    }
}
