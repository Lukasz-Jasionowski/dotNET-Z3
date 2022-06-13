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

namespace dotNET_Z3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model model = new Model();
        public MainWindow()
        {
            DataContext = new Model();
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Record newRecord = model.AddNewRecord();
            ListBox recordsList = (ListBox)this.FindName("ListaDanych");
            recordsList.ItemsSource = model.Records;
            new DetailsWindow(newRecord).Show();
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            ListBox recordsList = (ListBox)this.FindName("ListaDanych");
            Record whatRecord = (Record)recordsList.SelectedItem;
            if (whatRecord != null)
                (new DetailsWindow(whatRecord)).Show();
        }
    }
}
