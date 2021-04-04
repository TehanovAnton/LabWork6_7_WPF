using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace LabWork6_7
{    
    public class ProductsViewModel
    {
        private string listProductsPath;
        private static readonly Lazy<ProductsViewModel> instance = new Lazy<ProductsViewModel>(() => new ProductsViewModel());

        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }

        private ProductsViewModel()
        {
            listProductsPath = @"C:\Users\Anton\source\repos\pacei_NV_OOTP\лабораторные\решения\LabWork6_7(WPF)\ListProducts.txt";

            string text;
            using (StreamReader f = new StreamReader(listProductsPath))
                text = f.ReadToEnd();

            ObservableCollection<Product> l = JsonConvert.DeserializeObject<ObservableCollection<Product>>(text);
            products = l == null || l.Count == 0 ? new ObservableCollection<Product>() : l;
            Products = products;
        }
        public static ProductsViewModel GetInstance()
        {
            return instance.Value;
        }
    }
}
