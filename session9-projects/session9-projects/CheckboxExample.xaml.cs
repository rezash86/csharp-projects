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
    /// Interaction logic for CheckboxExample.xaml
    /// </summary>
    public partial class CheckboxExample : Window
    {
        public CheckboxExample()
        {
            InitializeComponent();
        }

        private void chChoc_Checked(object sender, RoutedEventArgs e)
        {
            
            HandleChocolate(sender as CheckBox);

        }

        private void chSugar_Checked(object sender, RoutedEventArgs e)
        {
            lable2.Content = "No sugar is selected";
            
        }

        private void chSugar_Unchecked(object sender, RoutedEventArgs e)
        {
            lable2.Content = "";
            
        }

        private void chChoc_Unchecked(object sender, RoutedEventArgs e)
        {
            HandleChocolate(sender as CheckBox);

        }


        void HandleChocolate(CheckBox checkBox)
        {
            bool flag = checkBox.IsChecked.Value;
            if (flag)
            {
                lable1.Content = "Extra chocolate is selected";
            }
            else
            {
                lable1.Content = "";
            }
        }
    }
}
