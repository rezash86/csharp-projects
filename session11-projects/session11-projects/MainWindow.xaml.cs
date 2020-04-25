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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace session11_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ContextMenu x = sender as ContextMenu; ==> this is wrong
            
            //with this code I could access to the property resource and I could make the context menu 
            //open
            ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
            cm.IsOpen = true;
            //MessageBox.Show(cm.Items.Count.ToString());
        }
    }
}
