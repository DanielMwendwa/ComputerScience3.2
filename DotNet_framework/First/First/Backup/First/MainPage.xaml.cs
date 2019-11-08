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

namespace First
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void txtfname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnFullnames_Click(object sender, RoutedEventArgs e)
        {
            string fname, mname, lname, fullname;

            if (string.IsNullOrEmpty(txtFname.Text)) {
                MessageBox.Show("Please enter a first name");
                txtFname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtMname.Text)) {
                MessageBox.Show("Please enter a middle name");
                txtMname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtLname.Text)) {
                MessageBox.Show("Please enter a last name");
                txtLname.Focus();
                return;
            }

            fname = txtFname.Text;
            mname = txtMname.Text;
            lname = txtLname.Text;
            fullname = fname + " " + mname + " " + lname;

            MessageBox.Show("Your fullnames are : " + fullname, "Full names", MessageBoxButton.OKCancel);
        }
    }
}