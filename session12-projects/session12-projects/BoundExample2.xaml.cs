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
    /// Interaction logic for BoundExample2.xaml
    /// </summary>
    public partial class BoundExample2 : Window
    {
        public BoundExample2()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
