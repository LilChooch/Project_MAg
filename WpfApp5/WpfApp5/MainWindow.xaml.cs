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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string login = textBoxLogin.Text.Trim();
            string pas = PasBox.Password.Trim();
            string pas1 = Pas1Box.Password.Trim();
            string email =emailBox.Text.Trim();


            if ( login.Length < 5 ) 
            {
                textBoxLogin.ToolTip = "Логин должен состоять минимум 5 символов!";
                textBoxLogin.Background = Brushes.Red;
            }
            else if(pas.Length < 1) 
            {
               PasBox.ToolTip = "Пароль должен состоять минимум из 6 символов!";
                PasBox.Background = Brushes.Red;
            }
            else if(pas != pas1)
            {
               Pas1Box.ToolTip = "Пароли должны быть одинаковыми!";
               Pas1Box.Background = Brushes.Red;
            }
            else if(email.Length < 8 || !email.Contains("@") || !email.Contains("."))
            {
                emailBox.ToolTip = "Такого email не сущуствует";
                emailBox.Background = Brushes.Red;
            }
            else 
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background= Brushes.Transparent;
                PasBox.ToolTip = "";
                PasBox.Background = Brushes.Transparent;
                Pas1Box.ToolTip = "";
                Pas1Box.Background = Brushes.Transparent;
                emailBox.ToolTip = "";
                emailBox.Background = Brushes.Transparent;
                MessageBox.Show("Успешно!");

                MyFrame.Content = new Page2();
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
                MyFrame.Content = new Page1();
            
        
        }
    }
    

}
