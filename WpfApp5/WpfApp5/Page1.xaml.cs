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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login1 = textBoxLogin1.Text.Trim();
            string pas1 = PasBox1.Password.Trim();




            if (login1.Length < 1 && login1.Length > 10)
            {
                textBoxLogin1.ToolTip = "Это поле введено некоректно";
                textBoxLogin1.Background = Brushes.DarkRed;
            }
            else if (pas1.Length < 5)
            {
                PasBox1.ToolTip = "Это поле введено некоректно";
                PasBox1.Background = Brushes.DarkRed;
            }

            else
            {
                textBoxLogin1.ToolTip = "";
                textBoxLogin1.Background = Brushes.Transparent;
                PasBox1.ToolTip = "";
                PasBox1.Background = Brushes.Transparent;
                MyFrame2.Content = new Page2();
               
                
            }

        }
    }
}
