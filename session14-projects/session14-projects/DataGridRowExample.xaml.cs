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
    /// Interaction logic for DataGridRowExample.xaml
    /// </summary>
    public partial class DataGridRowExample : Window
    {
        public DataGridRowExample()
        {
            InitializeComponent();

            List<Author> authors = new List<Author>();
            authors.Add(new Author { Id=  1, ImageUrl= @"images\homer-simpson.jpeg" , Name = "reza sh1", Birthday = new DateTime(1986, 01, 01)});
            authors.Add(new Author { Id = 2, ImageUrl = @".\images\homer-simpson.jpeg", Name = "reza sh2", Birthday = new DateTime(1986, 01, 01) });
            authors.Add(new Author { Id = 3, ImageUrl = @"..\images\homer-simpson.jpeg", Name = "reza sh3", Birthday = new DateTime(1986, 01, 01) });
            authors.Add(new Author { Id = 4, ImageUrl = @"\images\homer-simpson.jpeg", Name = "reza sh4", Birthday = new DateTime(1986, 01, 01) });

            //Connect to database and fetch => old way provider = sql clinet.... entityprovider
            //do the query and 
            // calling a strored procedure
            // Using LINQ
            //populate the grid

            //READ Operatios
            dGAuthors.ItemsSource = authors;

            //CUD operation
        }


        public class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
            
            public DateTime Birthday { get; set; }

            //homer-simpson
            public string ImageUrl { get; set; }
            public string Details
            {
                get
                {
                    return string.Format("{0} was born in {1}. this can be a long description of the author", this.Name, this.Birthday);
                }
            }
        }
    }
}
