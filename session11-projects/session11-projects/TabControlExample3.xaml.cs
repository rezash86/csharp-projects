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

namespace session11_projects
{
    /// <summary>
    /// Interaction logic for TabControlExample3.xaml
    /// </summary>
    public partial class TabControlExample3 : Window
    {
        public TabControlExample3()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if(newIndex < 0)
            {
                newIndex = tcSample.Items.Count - 1;
            }
            tcSample.SelectedIndex = newIndex;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if(newIndex >= tcSample.Items.Count)
            {
                newIndex = 0;
            }
            tcSample.SelectedIndex = newIndex;
        }

        private void btnSelected_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab => " + (tcSample.SelectedItem as TabItem).Header);
        }
    }
}
