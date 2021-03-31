using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork6_7.Pages
{
    public class Product
    {
        private string title;
        private string producer;
        private string discription;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }
        public string Discription
        {
            get
            {
                return discription;
            }
            set
            {
                discription = value;
            }
        }

        public Product(string title, string producer, string discription)
        {
            this.title = title;
            this.producer = producer;
            this.discription = discription;
        }
    }
}
