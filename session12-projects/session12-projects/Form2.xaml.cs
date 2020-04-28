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
    /// Interaction logic for Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {

        public Form1 form1;
        
        public Form2()
        {
            InitializeComponent();           
        }

        public Form2(string strTextValue)
        {
            InitializeComponent();
            lblValue.Content = strTextValue;
        }

        public Form2(object strTextValue)
        {
            InitializeComponent();
            lblValue.Content = strTextValue;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //This is used for using object
            //lblValue.Content = ((Form1)form1).txtfirstName.Text;
        }

        public void passData(TextBox txt)
        {
            lblValue.Content = txt.Text;
        }

        public string _textBox
        {
            set { lblValue.Content = value; }
        }
    }
}
