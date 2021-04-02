using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace LabWork6_7.Pages
{
    public class AddProductPageViewModel : INotifyPropertyChanged
    {
        private ProductsViewModel pproducts { get; set; }

        private Product newProduct;
        public Product NewProduct
        {
            get { return newProduct; }
            set
            {
                newProduct = value;
                OnPropertyChanged("NewProduct");
            }
        }

        public string Title
        {
            get
            {
                return NewProduct.Title;
            }
            set
            {
                NewProduct.Title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Producer
        {
            get
            {
                return NewProduct.Producer;
            }
            set
            {
                NewProduct.Producer = value;
                OnPropertyChanged("Producer");
            }
        }
        public string Discription
        {
            get
            {
                return NewProduct.Discription;
            }
            set
            {
                NewProduct.Discription = value;
                OnPropertyChanged("Discription");
            }
        }
        public string Section
        {
            get
            {
                return NewProduct.Section;
            }
            set
            {
                NewProduct.Section = value;
                OnPropertyChanged("Section");
            }
        }
        public int Prise
        {
            get
            {
                return NewProduct.Prise;
            }
            set
            {                
                NewProduct.Prise = value;
                OnPropertyChanged("Prise");
            }
        }


        private RelayCommand addNew;
        public RelayCommand AddNew
        {
            get {
                return addNew ?? (addNew = new RelayCommand(
                  obj =>
                  {
                      pproducts.Products.Add(NewProduct);
                      MessageBox.Show(pproducts.Products[pproducts.Products.Count - 1].Producer, "Ok");
                  }
              ));
            }
        }


        public AddProductPageViewModel()
        {
            pproducts = ProductsViewModel.GetInstance();
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
