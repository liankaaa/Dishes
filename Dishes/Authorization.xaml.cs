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

namespace Dishes
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MainPage main = new MainPage();
                main.Show();
                this.Hide();
            }
            else if (textBox1.Text != "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text == "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text != "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            MainPage wnd = new MainPage();
            wnd.Show();
            this.Hide();
        }
    }
}
