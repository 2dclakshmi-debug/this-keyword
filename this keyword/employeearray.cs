using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    internal class employeearray
    {
        int empid;
        string empname;
        double empsalary;
        public employeearray(int empid, string empname, double empsalary)
        {
            this.empid = empid;
            this.empname = empname;
            this.empsalary = empsalary;
        }
        public void display1()
        {
            Console.WriteLine("Employee id :" + empid);
            Console.WriteLine("Employee name :" + empname);
            Console.WriteLine("Employee salary :" + empsalary);
            Console.WriteLine("-------------------------");
        }
    }
}
