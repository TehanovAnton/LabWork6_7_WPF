using LabWork6_7.Images;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace LabWork6_7.Pages
{
    class CatalogViewModel : INotifyPropertyChanged
    {
        private Page viewer;
        private Page currentPage;

        public Page CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }
        public Page Viewer
        {
            get { return viewer; }
            set
            {
                viewer = value;
                OnPropertyChanged("Viewer");
            }
        }


        private RelayCommand setDrawingViewer;
        public RelayCommand SetDrawingViewer
        {
            get
            {
                return setDrawingViewer ?? (setDrawingViewer = new RelayCommand(
                        obj =>
                        {
                            CurrentPage = new Viewer(ProductsViewModel.GetInstance().DrawingProducts);
                        }
                    ));
            }
        }


        private RelayCommand setMVechDrawingViewer;
        public RelayCommand SetMechDrawingViewer
        {
            get
            {
                return setMVechDrawingViewer ?? (setMVechDrawingViewer = new RelayCommand(
                        obj =>
                        {
                            CurrentPage = new Viewer(ProductsViewModel.GetInstance().MechDrawingProducts);
                        }
                    ));
            }
        }


        private RelayCommand setWritingViewer;
        public RelayCommand SetWritingViewer
        {
            get
            {
                return setWritingViewer ?? (setWritingViewer = new RelayCommand(
                        obj =>
                        {
                            CurrentPage = new Viewer(ProductsViewModel.GetInstance().WwritingProducts);
                        }
                    ));
            }
        }


        public CatalogViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
