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

namespace WPF_Basics_Sample_Application
{
    /// <summary>
    /// Interaction logic for Assign5.xaml
    /// </summary>
    public partial class Assign5 : Window
    {
        public Assign5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 6, 7, 8, 5, 4, 3, 3, 1, 1 };

            var freq = from num in arr1
                       group num by num 
                       into grp
                       select grp;

            string output = "";
            foreach(var arrnum in freq)
            {
                output += $"{arrnum.Key} happened {arrnum.Count()} times";
                output += "\n";
            }


            MessageBox.Show(output);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(7);
            numList.Add(13);
            numList.Add(24);
            numList.Add(6);
            numList.Add(9);
            numList.Add(8);
            numList.Add(7);

            int count = 0;
            if (txtCount.Text != "")
                count = Int32.Parse(txtCount.Text);

            numList.Sort();
            numList.Reverse();

            string output = "";
            foreach (int topn in numList.Take(count))
            {
                output += topn;
                output += "\n";
            }

            MessageBox.Show(output);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Item_mast> itemList = new List<Item_mast>
            {
                new Item_mast{ ItemId = 1, ItemDes= "chocolat"},
                new Item_mast{ ItemId = 2, ItemDes= "Honey"},
                new Item_mast{ ItemId = 3, ItemDes= "Bread"},
                new Item_mast{ ItemId = 4, ItemDes= "Butter"},
                new Item_mast{ ItemId = 5, ItemDes= "Cheese"},
            };

            List<Purchase> purchaseList = new List<Purchase>()
            {
                new Purchase{ InvNo = 100, ItemId =3, PurQty= 800 },
                new Purchase{ InvNo = 101, ItemId =2, PurQty= 650 },
                new Purchase{ InvNo = 102, ItemId =3, PurQty= 700 },
                new Purchase{ InvNo = 103, ItemId =4, PurQty= 300 },
                new Purchase{ InvNo = 104, ItemId =3, PurQty= 900 },
                new Purchase{ InvNo = 105, ItemId =4, PurQty= 500 },
                new Purchase{ InvNo = 106, ItemId =1, PurQty= 600 },
            };


            var innerJoin = from item in itemList
                            join d in purchaseList
                            on item.ItemId equals d.ItemId
                            select new
                            {
                                itid = item.ItemId,
                                itdes = item.ItemDes,
                                prqt = d.PurQty
                            };

            string output = "";
            foreach (var data in innerJoin)
            {
                output += $"{data.itid} :  {data.itdes} : {data.prqt} ";
                output += "\n";
            }

            MessageBox.Show(output);
        }
    }

    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }
}
