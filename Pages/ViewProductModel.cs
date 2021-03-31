using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LabWork6_7.Pages
{
    public class ViewProductModel : INotifyPropertyChanged
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


        public ViewProductModel()
        {
            products = new ObservableCollection<Product>
            {
                new Product("Pencil", "ErichCrause", "твёрдомягкий карандаш"),
                new Product("Pen", "Elbrus", "шариковая ручка синего цвета"),
                new Product("Glue", "ПВХ", "бытавой клей")
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
