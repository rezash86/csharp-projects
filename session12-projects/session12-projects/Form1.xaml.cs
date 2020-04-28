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
    /// Interaction logic for Form1.xaml
    /// </summary>
    public partial class Form1 : Window
    {
        public delegate void delPassDate(TextBox txt);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendValue_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtfirstName.Text;

            //Using constructor
            //Form2 form2 = new Form2(firstName);
            //form2.Show();

            //using objects
            //Form2 frm = new Form2();
            //frm.form1 = this;
            //frm.Show();


            //Using properties
            //Form2 frm = new Form2();
            //frm._textBox = _textbox1;
            //frm.Show();

            //using delegate
            Form2 frm = new Form2();
            delPassDate delPassDate = new delPassDate(frm.passData);
            delPassDate(this.txtfirstName);
            frm.Show();
        }

        public string _textbox1
        {
            get { return txtfirstName.Text; }
        }
    }
}
