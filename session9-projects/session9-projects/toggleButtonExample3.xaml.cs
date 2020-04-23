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
    /// Interaction logic for toggleButtonExample3.xaml
    /// </summary>
    public partial class toggleButtonExample3 : Window
    {
        public toggleButtonExample3()
        {
            InitializeComponent();
        }

        private void tb_Checked(object sender, RoutedEventArgs e)
        {
            textResult.Text = "Button is checked";
        }

        private void tb_Unchecked(object sender, RoutedEventArgs e)
        {
            textResult.Text = "Button is Unchecked";
        }

        private void tb_Unchecked_1(object sender, RoutedEventArgs e)
        {
            textResult.Text = "Button is Unchecked for Gao";
        }
    }
}
