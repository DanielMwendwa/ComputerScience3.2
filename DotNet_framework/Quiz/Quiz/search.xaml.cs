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
using Microsoft.Phone.Shell;

namespace Quiz
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton npage = new ApplicationBarIconButton();
            npage.IconUri = new Uri("/images/new.png", UriKind.Relative);
            npage.Text = "Add new Propery";
            ApplicationBar.Buttons.Add(npage);
            npage.Click += new EventHandler(npage_Click);

            ApplicationBarIconButton search = new ApplicationBarIconButton();
            search.IconUri = new Uri("/images/search.png", UriKind.Relative);
            search.Text = "search property";
            ApplicationBar.Buttons.Add(search);
            search.Click += new EventHandler(search_Click);
        }

        void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpLoc.Text)) 
            {
                MessageBox.Show("Location is required");
                txtpLoc.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtMinPrice.Text))
            {
                MessageBox.Show("Minimum price is required");
                txtMinPrice.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtMaxPrice.Text))
            {
                MessageBox.Show("Maximum price is required");
                txtMaxPrice.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtpCat.Text))
            {
                MessageBox.Show("Category is required");
                txtpCat.Focus();
                return;
            }
            if (int.Parse(txtMinPrice.Text) <= 0)
            {
                MessageBox.Show("Minimum price should be more than zero");
                txtMinPrice.Focus();
                return;
            }
            if (int.Parse(txtMaxPrice.Text) <= 0)
            {
                MessageBox.Show("Maximum price should be more than zero");
                txtMaxPrice.Focus();
                return;
            }
            else
            {
                findproperty(txtpCat.Text, txtpLoc.Text, double.Parse(txtMaxPrice.Text), double.Parse(txtMinPrice.Text));
            }

        }

        void npage_Click(object sender, EventArgs e)
        {
           NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void findproperty(string category, string location, double maxprice, double minprice)
        {
            if (category == globalVariables.pcat && location == globalVariables.location &&
                maxprice >= globalVariables.price && minprice >= globalVariables.price)
            {
                string output;
                output = "property ID \n " + globalVariables.pid + "\n"
                    + "Property name \n" + globalVariables.pname + "\n"
                    + "property price \n" + globalVariables.price + "\n";
                MessageBox.Show(output);
            }

            else
            {
                MessageBox.Show("There is no matching property");
            }
        }
    }
}