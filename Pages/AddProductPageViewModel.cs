using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LabWork6_7.Pages
{
    public class AddProductPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Product> products { get; set; }

        private Product newProduct;
        private ComboBoxItem selected;


        public Product NewProduct
        {
            get { return newProduct; }
            set
            {
                newProduct = value;
                OnPropertyChanged("NewProduct");
            }
        }
        public ComboBoxItem Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged("Selected");
            }
        }



        private RelayCommand addNew;
        public RelayCommand AddNew
        {
            get {
                return addNew ?? (addNew = new RelayCommand(
                  obj =>
                  {
                      NewProduct.Section = (Selected.Content as TextBlock).Text;
                      products.Add(NewProduct);
                      NewProduct = new Product();                      
                  }
              ));
            }
        }


        public AddProductPageViewModel()
        {
            products = ProductsViewModel.GetInstance().Products;
            newProduct = new Product();

            NewProduct = newProduct;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
