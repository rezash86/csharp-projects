﻿using System;
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
    /// Interaction logic for CalendarExample.xaml
    /// </summary>
    public partial class CalendarExample : Window
    {
        public CalendarExample()
        {
            InitializeComponent();
            //cldSample.SelectedDate = DateTime.Now.AddDays(1);
        }

        private void calendarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
