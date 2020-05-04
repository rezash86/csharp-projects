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

namespace session16_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ZzaEntities zzaEntities = new ZzaEntities(); 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bindData();
        }

        public void bindData()
        {
            //I will use LINQ
            var query = from customer in zzaEntities.Customers
                            //where
                        select new { customer.Id, customer.FirstName, customer.LastName, customer.Phone };

            this.DataContext = query.ToList();
            //dataGridSample.ItemsSource = query.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //txtfirst , txtLAstname, txtPhone
            //Could generate a Customer Object with the attributes
            //pass the customer object (BO) into the service
            service.CustomerService service = new service.CustomerService();
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };
            Guid result = service.AddCustomer(customer);
            MessageBox.Show(result.ToString());
            bindData();
        }

        private void dataGridSample_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            object item = dataGridSample.SelectedItem;
            string ID = (dataGridSample.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            txtId.Text = ID;


            //MessageBox.Show(dataGridSample.SelectedCells.ElementAt(0).Column.
        }


        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            string customerId = txtId.Text;
            string newName = txtNewName.Text;

            service.CustomerService service = new service.CustomerService();

            if (service.EditCustomer(Guid.Parse(customerId), newName))
            {
                MessageBox.Show("edited successfully");
            }

        }
    }
}
