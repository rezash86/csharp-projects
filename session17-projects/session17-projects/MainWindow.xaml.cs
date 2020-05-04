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

namespace session17_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZzaEntities1 _ZzaContext = new ZzaEntities1();
        MainPageViewModel _viewModel = new MainPageViewModel();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedOrder = _ZzaContext.Orders.Include("OrderItems")
                .Where(o => o.OrderDate == (DateTime)OrderList.SelectedItem &&
                o.CustomerId == (Guid)CustomerIdLabel.Content).FirstOrDefault();
           
            _viewModel.OrderItems = selectedOrder.OrderItems.ToList();
            this.DataContext = _viewModel;
            OrderItemsDataGrid.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var firstCustomer = _ZzaContext.Customers.FirstOrDefault();

            //Using traditional value transfer
            //CustomerIdLabel.Content = firstCustomer.Id;
            //CustomerNameTextBox.Text = firstCustomer.LastName;

            _viewModel.Customer = firstCustomer;
            this.DataContext = firstCustomer;

            var orderDates = _ZzaContext.Orders.Where(o => o.CustomerId == firstCustomer.Id)
                .Select(order => order.OrderDate).ToList();

            //Using traditional value transfer
            //OrderList.ItemsSource = orderDates;
            //OrderList.DataContext = orderDates;

            _viewModel.OrderDates = orderDates;
            this.DataContext = _viewModel;

        }

        private void OnSave_Click(object sender, RoutedEventArgs e)
        {
            //Updated the customer
            var firstCustomer = _ZzaContext.Customers.FirstOrDefault();
            firstCustomer.LastName = CustomerNameTextBox.Text;

            //Add a new the customer

            Customer myCustomer = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "A",
                LastName = "B",
                Phone = "3333"
            };
            _ZzaContext.Customers.Add(myCustomer);

            //Add Order
            Order order = new Order()
            {
                Id = _ZzaContext.Orders.Count() + 1,
                CustomerId = myCustomer.Id,
                ItemsTotal = 500,
                OrderDate = DateTime.Now,
                OrderStatusId = 2

            };

            var RemovedCustomer = from c in _ZzaContext.Customers
                                  where c.FirstName == "shakira"
                                  select c;


            _ZzaContext.Customers.Remove(RemovedCustomer.FirstOrDefault());

            _ZzaContext.Orders.Add(order);

            _ZzaContext.SaveChanges();
        }


    }
}
