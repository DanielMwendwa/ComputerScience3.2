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

namespace Grading
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton save = new ApplicationBarIconButton();
            save.IconUri = new Uri("/icons/save.png", UriKind.Relative);
            save.Text = "Save record";
            ApplicationBar.Buttons.Add(save);
            save.Click += new EventHandler(save_Click);

            ApplicationBarIconButton cancel = new ApplicationBarIconButton();
            cancel.IconUri = new Uri("/icons/cancel.png", UriKind.Relative);
            cancel.Text = "Cancel";
            ApplicationBar.Buttons.Add(cancel);
            cancel.Click += new EventHandler(cancel_Click);
        }

        void cancel_Click(object sender, EventArgs e)
        {
            // code for cancel
        }

        void save_Click(object sender, EventArgs e)
        {
            // code for save
            // validations
            if (string.IsNullOrEmpty(reg.Text))
            {
                MessageBox.Show("Registration number required");
                reg.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(name.Text))
            {
                MessageBox.Show("Student name required");
                name.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(unit.Text))
            {
                MessageBox.Show("Unit name required");
                unit.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cat1.Text)) {
                MessageBox.Show("Cat 1 mark required");
                cat1.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cat2.Text))
            {
                MessageBox.Show("Cat 2 mark required");
                cat2.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(exam.Text))
            {
                MessageBox.Show("Exam mark required");
                exam.Focus();
                return;
            }
            else if (int.Parse(cat1.Text) < 0 || int.Parse(cat1.Text) > 30)
            {
                MessageBox.Show("Invalid cat1 marks. Marks should be between 0 and 30");
            }
            else if (int.Parse(cat2.Text) < 0 || int.Parse(cat2.Text) > 30)
            {
                MessageBox.Show("Invalid cat2 marks. Marks should be between 0 and 30");
            }
            else if (int.Parse(exam.Text) < 0 || int.Parse(exam.Text) > 70)
            {
                MessageBox.Show("Invalid exam marks. Marks should be between 0 and 70");
            }
        }
    }
}