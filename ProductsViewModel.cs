using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork6_7
{
    public class ProductsViewModel
    {
        private static readonly Lazy<ProductsViewModel> instance = new Lazy<ProductsViewModel>(() => new ProductsViewModel());


        private List<Product> products;
        public List<Product> Products
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
            products = new List<Product>();

            Products = products;

            Products.Add(new Product("Pencil", "ErichCrause", "твёрдомякий", "fordraWing", 100));
            Products.Add(new Product("Pen", "ErichCrause", "синяя шариковая", "fordraWing", 100));
            Products.Add(new Product("Ruler", "ErichCrause", "твёрдомякий", "forMechdrawing", 100));
            Products.Add(new Product("Glue", "ErichCrause", "твёрдомякий", "forMechdrawing", 100));
        }
        public static ProductsViewModel GetInstance()
        {
            return instance.Value;
        }


        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
