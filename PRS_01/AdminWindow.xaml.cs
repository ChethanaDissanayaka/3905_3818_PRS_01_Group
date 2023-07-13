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

namespace PRS_01
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            DataContext = new AdminWindowVM();
            InitializeComponent();
        }
        private void Button_User(object sender, RoutedEventArgs e)
        {
            var Window = new UsersWindow();
            Window.Show();
            this.Close();
        }
        private void Button_Patients(object sender, RoutedEventArgs e)
        {
            var Window = new PatientsWindow();
            Window.Show();
            this.Close();
        }

        private void Button_Bill(object sender, RoutedEventArgs e)
        {
            var Window = new BillWindow();
            Window.Show();
            this.Close();
        }

        private void Button_Back3(object sender, RoutedEventArgs e)
        {
            var Window = new MainWindow();
            Window.Show();
            this.Close();
        }
    }
}
