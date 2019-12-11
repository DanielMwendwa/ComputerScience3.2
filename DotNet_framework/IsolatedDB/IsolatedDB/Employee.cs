using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace IsolatedDB
{
    public class Employee
    {
        // define a method known as add employee
        public void addEmployee(string ename, string etitle, string position, string gender, double salary)
        { 
            // we shall use the employeecontext connection
            using (employeeContext context = new employeeContext(employeeContext.dbconstring))
            {
                //create a new instance of the class employee
                employee e = new employee();
                //assign fields values
                e.empname = ename;
                e.title = etitle;
                e.gender = gender;
                e.position = position;
                e.salary = salary;
                //submit for insertion
                context.tblEmployee.InsertOnSubmit(e);
                //save the records
                context.SubmitChanges();
            }
        }
    }
}
