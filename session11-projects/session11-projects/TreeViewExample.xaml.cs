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
    /// Interaction logic for TreeViewExample.xaml
    /// </summary>
    public partial class TreeViewExample : Window
    {
        TreeViewItem treeViewItem = new TreeViewItem();

        public TreeViewExample()
        {
            InitializeComponent();
        }

        public TreeViewItem getGeorgiaItem()
        {
            TreeViewItem treeViewItem = new TreeViewItem();

            treeViewItem.Header = "Georgia";

            treeViewItem.Items.Add(new TreeViewItem() { Header = "H" });
            treeViewItem.Items.Add(new TreeViewItem() { Header = "I" });
            treeViewItem.Items.Add(new TreeViewItem() { Header = "J" });

            return treeViewItem;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.treeViewItem = getGeorgiaItem();
            tvStates.Items.Add(this.treeViewItem);

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            //if (tvStates.Items.Count > 2)
            //{
            //    tvStates.Items.RemoveAt(2);
            //}

            if (tvStates.Items.Contains(this.treeViewItem))
            {
                tvStates.Items.Remove(this.treeViewItem);
            }
            
        }
    }
}
