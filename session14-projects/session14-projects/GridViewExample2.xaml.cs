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

namespace session14_projects
{
    /// <summary>
    /// Interaction logic for GridViewExample2.xaml
    /// </summary>
    public partial class GridViewExample2 : Window
    {
        public GridViewExample2()
        {
            InitializeComponent();

            List<Author> authors = new List<Author>();
            authors.Add(new Author { Name = "reza sh", Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "brad pit", Age = 80, Book = "the marriage", MVP = false });

            lvAuthors.ItemsSource = authors;


        }


        public class Author
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Book { get; set; }
            public bool MVP { get; set; }

            public DateTime Birthday { get; set; }

            public string Mail { get; set; }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = sender as GridViewColumnHeader;
            
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
