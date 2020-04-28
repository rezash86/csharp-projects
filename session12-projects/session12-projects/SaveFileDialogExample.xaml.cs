using Microsoft.Win32;
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

namespace session12_projects
{
    /// <summary>
    /// Interaction logic for SaveFileDialogExample.xaml
    /// </summary>
    public partial class SaveFileDialogExample : Window
    {
        public SaveFileDialogExample()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (saveFileDialog.ShowDialog() == true)
            {
                string txt = txtEditor.Text;
                File.WriteAllText(saveFileDialog.FileName, txt);
            }
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"c:\";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach(string fileName in openFileDialog.FileNames)
                {
                    txtEditor.Text += System.IO.Path.GetFileName(fileName);

                }
            }            
        }
    }
}
