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
    /// Interaction logic for ToggleButton.xaml
    /// </summary>
    public partial class ToggleButton : Window
    {
        public ToggleButton()
        {
            InitializeComponent();
            Background = Brushes.LightGreen;
        }

        private void tglButton_Checked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "It is enabled";
            Background = Brushes.MistyRose;
        }

        private void tglButton_Unchecked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "It is disabled";
            Background = Brushes.LightCoral;
        }
    }
}
