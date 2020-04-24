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

namespace session10_projects
{
    /// <summary>
    /// Interaction logic for FrameExample.xaml
    /// </summary>
    public partial class FrameExample : Window
    {
        public FrameExample()
        {
            InitializeComponent();
        }

        private void btnMsft_Click(object sender, RoutedEventArgs e)
        {
            frame1.Visibility = Visibility.Hidden; //Intel frame hidden
            frame.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnIntel_Click(object sender, RoutedEventArgs e)
        {
            frame.Visibility = System.Windows.Visibility.Hidden;//Microsoft frame hidden
            frame1.Visibility = Visibility.Visible;
        }
    }
}
