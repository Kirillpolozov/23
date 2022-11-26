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

namespace coffe
{
    /// <summary>
    /// Логика взаимодействия для Waiter.xaml
    /// </summary>
    public partial class Waiter : Window
    {
        public Waiter()
        {
            InitializeComponent();
            model = new Model();

            presenter = new Presenter(model);
            OrdersList.ItemsSource = model.Orders;
            DataContext = model;
        }
        private Presenter presenter;
        private Model model;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.Save1();
            OrdersList.ItemsSource = model.Orders;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            model.Save1();
            OrdersList.ItemsSource = model.Orders;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var readliness = (sender as ComboBox).SelectedItem as ReadLiness;
            model.SelectedReadliness = readliness;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var payments = (sender as ComboBox).SelectedItem as Payments;
            model.SelectedPayments = payments;
        }

        private void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orders = (sender as DataGrid).SelectedItem as Order;
            model.SelectedOrder = orders;
        }

       
       
    }
}
