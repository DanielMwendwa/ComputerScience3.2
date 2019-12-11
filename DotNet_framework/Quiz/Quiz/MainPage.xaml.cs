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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton save = new ApplicationBarIconButton();
            save.IconUri = new Uri("/images/save.png", UriKind.Relative);
            save.Text = "save record";
            ApplicationBar.Buttons.Add(save);
            save.Click += new EventHandler(save_Click);
        }

        void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryID.Text))
            {
                MessageBox.Show("Category ID is required");
                txtCategoryID.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtPropertyCategory.Text))
            {
                MessageBox.Show("Property category is required");
                txtPropertyCategory.Focus();
                return;
            }
               
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Your name is required");
                txtName.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Price is required");
                txtPrice.Focus();
                return;
            }
                
            else if (string.IsNullOrEmpty(txtLoc.Text))
            {
                MessageBox.Show("Location is required");
                txtLoc.Focus();
                return;
            }

            else if (int.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Property price cannot be less than 0");
                txtPrice.Focus();
                return;
            }
            else
            {
                globalVariables.location = txtLoc.Text;
                globalVariables.pcat = txtPropertyCategory.Text;
                globalVariables.pid = int.Parse(txtCategoryID.Text);
                globalVariables.pname = txtName.Text;
                globalVariables.price = double.Parse(txtPrice.Text);
                MessageBox.Show("Records saved successfully");
                
                NavigationService.Navigate(new Uri("/search.xaml", UriKind.Relative));
            }
        }
    }
}