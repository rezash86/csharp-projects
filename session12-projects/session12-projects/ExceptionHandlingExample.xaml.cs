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

namespace session12_projects
{
    /// <summary>
    /// Interaction logic for ExceptionHandlingExample.xaml
    /// </summary>
    public partial class ExceptionHandlingExample : Window
    {
        public ExceptionHandlingExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An unhandled exception occured" + exc.Message, "exception Message",
                    MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            
        }
    }
}
