using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LabWork6_7.Pages
{
    class MyBasketViewModel : INotifyPropertyChanged
    {
        private Product selectedProduct;
        public ObservableCollection<Product> products { get; set; }


        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public string Title
        {
            get
            {
                return SelectedProduct.Title;
            }
            set
            {
                SelectedProduct.Title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Producer
        {
            get
            {
                return SelectedProduct.Producer;
            }
            set
            {
                SelectedProduct.Producer = value;
                OnPropertyChanged("Producer");
            }
        }
        public string Discription
        {
            get
            {
                return SelectedProduct.Discription;
            }
            set
            {
                SelectedProduct.Discription = value;
                OnPropertyChanged("Discription");
            }
        }
        public string Section
        {
            get
            {
                return SelectedProduct.Section;
            }
            set
            {
                SelectedProduct.Section = value;
                OnPropertyChanged("Section");
            }
        }
        public int Prise
        {
            get
            {
                return SelectedProduct.Prise;
            }
            set
            {
                SelectedProduct.Prise = Convert.ToInt32(value);
                OnPropertyChanged("Prise");
            }
        }


        public MyBasketViewModel()
        {
            products = ProductsViewModel.GetInstance().Products;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
