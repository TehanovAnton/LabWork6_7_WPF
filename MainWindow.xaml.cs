using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork6_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.Description.Text);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.Weld.IsChecked = false;
        }

        private void Weld_Checked(object sender, RoutedEventArgs e)
        {
            this.Length.Text += (string)((CheckBox)sender).Content;
        }

        private void Finish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.Note == null)
                return;

            var combo = (ComboBox)sender;
            var comboItem = (ComboBoxItem)combo.SelectedValue;

            this.Note.Text = (string)comboItem.Content;
        }
    }
}
