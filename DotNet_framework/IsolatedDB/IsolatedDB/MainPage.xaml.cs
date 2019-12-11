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

namespace IsolatedDB
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            using (employeeContext context = new employeeContext(employeeContext.dbconstring)) 
            {
                if (!context.DatabaseExists())
                {
                    context.CreateDatabase();
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string ename, title, position, gender="";
            double salary;
            ename = txbName.Text;
            title = txbTitle.Text;
            position = txbPosn.Text;
            salary = double.Parse(txbSalary.Text);
            if (rdoFemale.IsChecked == true)
            {
                gender = "Female";
            }
            else if (rdoMale.IsChecked == true) 
            {
                gender = "Male";
            }
            //create object of type employee
            Employee em = new Employee();
            em.addEmployee(ename, title, position, gender, salary);
            MessageBox.Show("Records Saved");
        }
    }
}