using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace LabWork6_7
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private ProductsViewModel products;

        private Page currentInfoPage;
        private Page addRroductPage;
        private Page myBasketPage;
        private Page catatlogPage;

        public Page CurrentInfoPage
        {
            get { return currentInfoPage; }
            set
            {
                currentInfoPage = value;
                OnPropertyChanged("CurrentInfoPage");
            }
        }
        public Page AddProductPage
        {
            get { return addRroductPage; }
            set
            {
                addRroductPage = value;
                OnPropertyChanged("AddRroductPage");
            }
        }
        public Page MyBasketPage
        {
            get { return myBasketPage; }
            set
            {
                myBasketPage = value;
                OnPropertyChanged("MyBasketPage");
            }
        }
        public Page CatatlogPage
        {
            get
            {
                return catatlogPage;
            }
            set
            {
                catatlogPage = value;
                OnPropertyChanged("CatatlogPage");
            }
        }


        private RelayCommand setAddProductPage;
        public RelayCommand SetAddProductPage
        {
            get
            {
                return setAddProductPage ?? (new RelayCommand(
                    obj =>
                    {
                        CurrentInfoPage = AddProductPage;
                    }));
            }
        }


        private RelayCommand setMyBasket;
        public RelayCommand SetMyBasket
        {
            get
            {
                return setMyBasket ?? (setMyBasket = new RelayCommand(
                        obj =>
                        {
                            CurrentInfoPage = MyBasketPage;
                        }
                    ));
            }
        }


        private RelayCommand setCatalogPage;
        public RelayCommand SetCatalogPage
        {
            get
            {
                return setCatalogPage ?? (setCatalogPage = new RelayCommand(
                        obj =>
                        {
                            CurrentInfoPage = CatatlogPage;
                        }
                    ));
            }
        }


        public ApplicationViewModel()
        {
            products = ProductsViewModel.GetInstance();

            AddProductPage = new Pages.AddProduct();
            myBasketPage = new Pages.MyBasket();
            currentInfoPage = new Pages.Welcome();
            catatlogPage = new Pages.Catalog();

            AddProductPage = AddProductPage;
            MyBasketPage = myBasketPage;
            CurrentInfoPage = currentInfoPage;
            CatatlogPage = catatlogPage;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
