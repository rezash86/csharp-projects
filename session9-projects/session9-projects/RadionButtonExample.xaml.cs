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

namespace session9_projects
{
    /// <summary>
    /// Interaction logic for RadionButtonExample.xaml
    /// </summary>
    public partial class RadionButtonExample : Window
    {
        public RadionButtonExample()
        {
            InitializeComponent();          
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "Option 1 is selected";
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "Option 2 is selected";
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            if(lblTest != null)
            {
                lblTest.Content = "Option 3 is selected";
            }
            
        }

        private void rb1_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 1 is unchecked");
        }

        private void rb2_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 2 is unchecked");
        }

        private void rb3_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Option 3 is unchecked");
        }
    }
}
