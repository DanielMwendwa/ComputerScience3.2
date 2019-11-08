using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ListBox
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // add meals to lstfoods
            lstFoods.Items.Add("Rice");
            lstFoods.Items.Add("Pilau");
            lstFoods.Items.Add("Pizza");
            lstFoods.Items.Add("Fish");
            lstFoods.Items.Add("Chicken");
            txbFoods.Text="Available foods " + lstFoods.Items.Count;
            txbOrders.Text = "Number of ordered foods " + lstOrders.Items.Count;
        }

        private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try {
                lstOrders.Items.Add(lstFoods.SelectedItem);
                lstFoods.Items.Remove(lstFoods.SelectedItem);
                txbFoods.Text = "Available foods " + lstFoods.Items.Count;
                txbOrders.Text = "Number of ordered foods " + lstOrders.Items.Count;
            }
            catch
            {
                MessageBox.Show("Select food first");
                return;
            }
            

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lstFoods.Items.Add(lstOrders.SelectedItem);
                lstOrders.Items.Remove(lstOrders.SelectedItem);
                txbFoods.Text = "Available foods " + lstFoods.Items.Count;
                txbOrders.Text = "Number of ordered foods " + lstOrders.Items.Count;
            }
            catch {
                MessageBox.Show("Select food first");
                return;
            }
             
        }
    }
}