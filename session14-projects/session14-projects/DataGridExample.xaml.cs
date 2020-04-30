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
using static session14_projects.GridViewExample2;

namespace session14_projects
{
    /// <summary>
    /// Interaction logic for DataGridExample.xaml
    /// </summary>
    public partial class DataGridExample : Window
    {
        public DataGridExample()
        {
            InitializeComponent();

            List<Author> authors = new List<Author>();
            authors.Add(new Author { Name = "reza sh", Mail="a@test.com", Birthday=new DateTime(1986, 01, 01), Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "brad pit", Mail = "b@test.com", Birthday = new DateTime(1986, 01, 01), Age = 80, Book = "the marriage", MVP = false });
            authors.Add(new Author { Name = "reza sh", Mail = "c@test.com", Birthday = new DateTime(1987, 02, 01), Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "reza sh", Mail = "d@test.com", Birthday = new DateTime(1988, 03, 01), Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "reza sh", Mail = "e@test.com", Birthday = new DateTime(1989, 04, 01), Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "reza sh", Mail = "f@test.com", Birthday = new DateTime(1990, 05, 01), Age = 20, Book = "the smartest in the world", MVP = true });
            authors.Add(new Author { Name = "reza sh", Mail = "g@test.com",  Birthday = new DateTime(1996, 06, 01), Age = 20, Book = "the smartest in the world", MVP = true });

            MyDataGrid.ItemsSource = authors;

        }
    }

}
