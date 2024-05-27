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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private string[] words = { "Наушники", "iphone", "телевизор", "мышка игровая", "вишня", "слива", "персик", "манго", "киви", "ананас" };
        public Page2()
        {
            InitializeComponent();
            SearchTextBox.KeyDown += SearchTextBox_KeyDown;
            LoadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFRame2.Navigate(new Uri("Page1.xaml", UriKind.Relative));

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
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

                Search();


            }
        }

        public void Search()
        {
            string keyword = SearchTextBox.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                bool found = false;
                foreach (string word in words)
                {
                    if (word.ToLower() == keyword)
                    {
                        MyFRame2.Content = new Page1();

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    SearchTextBox.ToolTip = "Данного товара нет в нашем магазине!";

                }
            }
            else
            {
                SearchTextBox.ToolTip = "Введите запрос для поиска.";

            }
        }
    }
}
