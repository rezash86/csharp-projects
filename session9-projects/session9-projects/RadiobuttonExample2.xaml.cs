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
    /// Interaction logic for RadiobuttonExample2.xaml
    /// </summary>
    public partial class RadiobuttonExample2 : Window
    {
        public RadiobuttonExample2()
        {
            InitializeComponent();
        }

        private void btnSelected_Click(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                MessageBox.Show("rb1 is checked");
            }
        }

        private void Generic_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rbtn=sender as RadioButton;
            MessageBox.Show(rbtn.Name);
        }
    }
}
