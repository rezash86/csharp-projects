using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace session15_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ConStr = ConfigurationManager.ConnectionStrings["zzDatabase"].ConnectionString;
        public MainWindow()
        {
            InitializeComponent();
            BindDatGrid();
        }

        public void BindDatGrid()
        {
            //set Connection 
            SqlConnection connection = new SqlConnection(ConStr);
            //Select Query to fetch data
            SqlDataAdapter da = new SqlDataAdapter("select * from Customer", ConStr);
            
            //we need a data container
            DataSet ds1 = new DataSet();
            //Fill Data inside ds => its a virtual database
            da.Fill(ds1, "CustomerTable");


            //da = new SqlDataAdapter("select * from Order", ConStr);
            //DataSet ds2 = new DataSet();

            //da.Fill(ds2, "OrderTable");

            //var x = from dr in ds1.Tables["CustomerTable"].AsEnumerable()
            //        join dr2 in ds2.Tables["OrderTable"].AsEnumerable()
            //            on dr.Field<Guid>("Id") equals dr2.Field<Guid>("CustomerId")
            //        select dr;

            grdCustomers.ItemsSource = x.ToList();


        }
    }
}
