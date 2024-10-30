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

namespace ComputerShop.views
{
    /// <summary>
    /// Логика взаимодействия для catalog.xaml
    /// </summary>
    public partial class catalog : Window
    {
        public catalog()
        {
            InitializeComponent();
        }

        private void btReturnCatalog_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.Show();
            this.Hide();
        }
    }
}
