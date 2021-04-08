using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LabWork6_7
{
    public class Product : INotifyPropertyChanged
    {
        private string title;
        private string producer;
        private string discription;
        private string section;
        private int prise;
        private bool selected;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
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
                OnPropertyChanged("Producer");
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
                OnPropertyChanged("Discription");
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
                OnPropertyChanged("Section");
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
                OnPropertyChanged("Prise");
            }
        }
        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged("Selected");
            }
        }

        public Product(string title, string producer, string discription, string section, int prise)
        {
            this.title = title;
            this.producer = producer;
            this.discription = discription;
            this.section = section;
            this.prise = prise;
            this.selected = true;
        }
        public Product() { }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
