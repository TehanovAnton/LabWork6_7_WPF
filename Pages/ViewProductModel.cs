﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace LabWork6_7.Pages
{
    public class ViewProductModel : INotifyPropertyChanged
    {      

        private Product selectedProduct;
        public ProductsViewModel products { get; set; }


        public Product SelectedProduct
        {
            get {
                return selectedProduct; }
            set 
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }


        public ViewProductModel()
        {
            products = ProductsViewModel.GetInstance();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
