using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LabWork6_7
{
    class MainViewModel
    {
        private UserControl welcomePage;
        private UserControl curentPage;
        private UserControl addProductPage;

        private ICommand addProduct_Click;
        public ICommand AddProduct_Click
        {
            get
            {
                return addProduct_Click ?? (addProduct_Click = new RelayCommand(obj => { CurentPage = new Pages.AddProduct(); }));
            }
        }


        public double FrameOpacity;


        public UserControl CurentPage
        {
            get
            {
                return curentPage;
            }

            set
            {
                curentPage = value;
                OnPropertyChanged("CurentPage");
            }
        }        

        public MainViewModel()
        {
            welcomePage = new Pages.Welcome();
            addProductPage = new Pages.AddProduct();

            FrameOpacity = 1;
            CurentPage = welcomePage;
        }

        public event PropertyChangedEventHandler PropertyChanged; public void OnPropertyChanged([CallerMemberName] string prop = "") { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
    }
}
