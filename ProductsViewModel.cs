using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Linq;

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
        public ObservableCollection<Product> DrawingProducts
        {
            get
            {
                return new ObservableCollection<Product>(from n in Products where n.Section == "Drawing" select n);
            }
        }
        public ObservableCollection<Product> MechDrawingProducts
        {
            get
            {
                return new ObservableCollection<Product>(from n in Products where n.Section == "MechanicalDrawing" select n);
            }
        }
        public ObservableCollection<Product> WwritingProducts
        {
            get
            {
                return new ObservableCollection<Product>(from n in Products where n.Section == "Writing" select n);
            }
        }
        public ObservableCollection<Product> SelectedProducts
        {
            get
            {
                return new ObservableCollection<Product>(from n in Products where n.Selected select n);
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

            Products.Add(new Product("A", "A", "A", "Drawing", 11));
            Products.Add(new Product("B", "B", "B", "Drawing", 11));
            Products.Add(new Product("C", "C", "C", "MechanicalDrawing", 11));
            Products.Add(new Product("D", "D", "D", "MechanicalDrawing", 11));
            Products.Add(new Product("E", "A", "A", "Drawing", 11));
            Products.Add(new Product("F", "B", "B", "Drawing", 11));
            Products.Add(new Product("G", "C", "C", "MechanicalDrawing", 11));
            Products.Add(new Product("H", "D", "D", "MechanicalDrawing", 11));
            Products.Add(new Product("I", "C", "C", "Writing", 11));
            Products.Add(new Product("J", "D", "D", "Writing", 11));
        }
        public static ProductsViewModel GetInstance()
        {
            return instance.Value;
        }
        public void DeleteProduct(Product p)
        {
            Products.Remove(p);
        }
    }
}
