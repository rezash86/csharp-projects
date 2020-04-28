using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for RespondChangesExample.xaml
    /// </summary>
    public partial class RespondChangesExample : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public RespondChangesExample()
        {
            InitializeComponent();

            users.Add(new User() { Name = "Angenila Jolie" });
            users.Add(new User() { Name = "Brad Pitt" });

            lbUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "reza" });
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                (lbUsers.SelectedItem as User).Name = "TOTO";
            }
        }

        private void btnDeletUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                users.Remove(lbUsers.SelectedItem as User);
            }

        }
    }

    public class User: INotifyPropertyChanged
    {
        private string name;

        private string telnum;
        public string Name
        {
            get { return this.name; }
            set
            {
                if(this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }


        public string TelNum
        {
            get { return this.telnum; }
            set
            {
                if (this.telnum != value)
                {
                    this.telnum = value;
                    this.NotifyPropertyChanged("TelNum");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if(this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
