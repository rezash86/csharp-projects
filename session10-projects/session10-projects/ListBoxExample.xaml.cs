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
    /// Interaction logic for ListBoxExample.xaml
    /// </summary>
    public partial class ListBoxExample : Window
    {
        public ListBoxExample()
        {
            InitializeComponent();

            List<string> bookItems = new List<string>();
            bookItems.Add("data structures");
            bookItems.Add("C#");
            bookItems.Add("Java");
            bookItems.Add("Python");

            lstBooks.ItemsSource = bookItems;

        }
    }
}
