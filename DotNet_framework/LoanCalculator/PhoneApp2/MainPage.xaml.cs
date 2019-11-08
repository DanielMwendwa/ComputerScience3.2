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

namespace PhoneApp2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            txbMonthlyRepay.Text = "";
            txbTotalLoan.Text = "";
            txbInterest.Text = "";
            //basic validations
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please enter the loan amount");
                txtAmount.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Please enter duration in months");
                txtDuration.Focus();
                return;
            }
            else if (int.Parse(txtDuration.Text) < 1 || int.Parse(txtDuration.Text) > 12)
            {
                MessageBox.Show("Loan Duration must be within 1 and 12");
                txtDuration.SelectAll();
                return;
            }

            else
            { 
                 //compute loan for customer
                const double RATE = 0.12;
                double interest, loanamount, monthlyrepay;
                int duration;
                duration = Convert.ToInt32(txtDuration.Text);
                loanamount = Convert.ToDouble(txtAmount.Text);
                interest = loanamount * RATE * duration;
                double totalloan = loanamount + interest;
                monthlyrepay = totalloan / duration;

                //Display output on  textblocks
                txbInterest.Text = "Loan interest\t" + interest;
                txbTotalLoan.Text = "Toatal loan\t" + totalloan;
                txbMonthlyRepay.Text = "Your monthly amount is\t" + monthlyrepay;

 
            }
        }
    }
}