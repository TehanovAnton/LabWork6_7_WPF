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
        private Page addProductPage;
        private Page viewProductPage;
        private Page currentInfoPage;

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
            get { return addProductPage; }
            set 
            {
                addProductPage = value;
                OnPropertyChanged("AddProductPage");
            }
        }
        public Page ViewProductPage
        {
            get { return viewProductPage; }
            set
            {
                viewProductPage = value;
                OnPropertyChanged("ViewProductPage");
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
                        }
                    ));
            }
        }


        private RelayCommand setViewProductPage;
        public RelayCommand SetViewProductPage
        {
            get
            {
                return setViewProductPage ?? (new RelayCommand(
                        obj =>
                        {
                            CurrentInfoPage = ViewProductPage;
                        }
                    ));
            }
        }


        public ApplicationViewModel()
        {
            addProductPage = new Pages.AddProduct();
            viewProductPage = new Pages.ViewProducts();
            currentInfoPage = new Pages.Welcome();

            AddProductPage = addProductPage;
            ViewProductPage = viewProductPage;
            CurrentInfoPage = currentInfoPage;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
