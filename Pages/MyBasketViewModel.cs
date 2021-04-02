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

        
        public MyBasketViewModel()
        {
            products = new ObservableCollection<Product>(ProductsViewModel.GetInstance().Products);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
