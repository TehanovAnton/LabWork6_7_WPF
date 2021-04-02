using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork6_7
{
    public class Product
    {
        private string title;
        private string producer;
        private string discription;
        private string section;
        private int prise;

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
        public string Section 
        {
            get
            {
                return section;
            }
            set
            {
                section = value;
            }
        }
        public int Prise
        {
            get
            {
                return prise;
            }
            set
            {
                prise = value;
            }
        }

        public Product(string title, string producer, string discription, string section, int prise)
        {
            this.title = title;
            this.producer = producer;
            this.discription = discription;
            this.section = section;
            this.prise = prise;
        }
        public Product() { }
    }
}
