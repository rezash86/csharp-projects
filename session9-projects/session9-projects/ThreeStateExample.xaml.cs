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
    /// Interaction logic for ThreeStateExample.xaml
    /// </summary>
    public partial class ThreeStateExample : Window
    {
        public ThreeStateExample()
        {
            InitializeComponent();
        }

        private void chAllFeautures_Checked(object sender, RoutedEventArgs e)
        {
            bool newValue = (chAllFeautures.IsChecked == true);
            cbFeautureAbc.IsChecked = newValue;
            cbFeautureXyz.IsChecked = newValue;
            cbFeautureWww.IsChecked = newValue;
        }

        private void cbFeauture_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox box =  sender as CheckBox;
            //box will be the checkbox that made this event handler to be triggered
            MessageBox.Show(box.Name);
                

            chAllFeautures.IsChecked = null;
            if(cbFeautureAbc.IsChecked == true && cbFeautureXyz.IsChecked == true &&
                    cbFeautureWww.IsChecked == true)
            {
                chAllFeautures.IsChecked = true;
            }
            if (cbFeautureAbc.IsChecked == false && cbFeautureXyz.IsChecked == false &&
                    cbFeautureWww.IsChecked == false)
            {
                chAllFeautures.IsChecked = false;
            }

        }


    }
}
