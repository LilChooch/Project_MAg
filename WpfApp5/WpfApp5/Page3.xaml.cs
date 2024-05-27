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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            LoadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFRame3.Navigate(new Uri("Page2.xaml", UriKind.Relative));

        }
        private void LoadData()
        {
            List<string> items = new List<string>();
            for (int i = 1; i <= 100; i++) 
            {
                items.Add($"Наушники {i}");
            }
            MyListBox.ItemsSource = items;
        }
    }
}
