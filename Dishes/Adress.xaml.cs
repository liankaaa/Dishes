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
using System.Windows.Shapes;

namespace Dishes
{
    /// <summary>
    /// Логика взаимодействия для Adress.xaml
    /// </summary>
    public partial class Adress : Window
    {
        public Adress()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Korzina wnd = new Korzina();
            wnd.Show();
            this.Hide();
        }
    }
}
