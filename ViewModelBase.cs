using System;
using System.Collections.Generic;
using System.Text;

namespace LabWork6_7
{
    class ViewModelBase
    {
        public RelayCommand relayCommand { get; set; }

        public ViewModelBase()
        {            
        }

        public void RelayMethod()
        {
            Console.WriteLine("workd");
        }
    }
}
