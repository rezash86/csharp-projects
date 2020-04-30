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

namespace session14_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>();

            items.Add(new User { Name = "TOTO", Age = 14, Mail = "toto@gmail.com" });
            items.Add(new User { Name = "POPO", Age = 24, Mail = "popo@gmail.com" });
            items.Add(new User { Name = "JOJO", Age = 34, Mail = "jojo@gmail.com" });

            lvSampleDataTemplate.ItemsSource = items;

        }


    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

        //public override string ToString()
        //{
        //    return this.Name + ", " + this.Age + " years old";

        //}
    }
}
