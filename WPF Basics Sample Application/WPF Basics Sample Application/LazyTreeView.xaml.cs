using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_Basics_Sample_Application
{
    /// <summary>
    /// Interaction logic for LazyTreeView.xaml
    /// </summary>
    public partial class LazyTreeView : Window
    {
        public LazyTreeView()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                trvStructure.Items.Add(CreateTreeItem(drive));
            }
        }

        private void trvStructure_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if(item.Items.Count == 1 && item.Items[0] is string)
            {
                item.Items.Clear();

                DirectoryInfo directoryInfo = null;
                
                if(item.Tag is DriveInfo)
                {
                    directoryInfo = (item.Tag as DriveInfo).RootDirectory;
                }
                if(item.Tag is DirectoryInfo)
                {
                    directoryInfo = (item.Tag as DirectoryInfo);
                }

                try
                {
                    foreach(DirectoryInfo subDir in directoryInfo.GetDirectories())
                    {
                        item.Items.Add(CreateTreeItem(subDir));
                    }
                }
                catch { }
            }
        }

        private TreeViewItem CreateTreeItem(object o)
        {
            TreeViewItem item = new TreeViewItem()
            {
                Header = o.ToString(),
                Tag = o,
            };
            item.Items.Add("Loading");

            return item;

        }
    }
}
