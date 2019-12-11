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
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace IsolatedDB
{
    public class employeeContext : DataContext
    {
        // Define the connection string to the database
        public static string dbconstring = @"isostore:/employee.sdf";
        public employeeContext(string connstring)
            : base(connstring)
        { 
            
        }
        // associate data with table employee
        public Table<employee> tblEmployee
        {
            get 
            {
                return this.GetTable<employee>();
            }
        }
    }
    [Table]

    public class employee
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int empid { get; set; }
        [Column]
        public string empname { get; set; }
        [Column]
        public string title { get; set; }
        [Column]
        public string position { get; set; }
        [Column]
        public string gender { get; set; }
        [Column]
        public double salary { get; set; }

    }
}
