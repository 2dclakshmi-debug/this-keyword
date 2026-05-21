using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class newClass
    {
        int a;
        int b;  
        public newClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            int c = a + b;
            Console.WriteLine("Sum is :" + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            newClass nc=new newClass(10,20);
            nc.Add();
            Console.WriteLine();

            Console.WriteLine("Student details :");
            Console.WriteLine("-----------------");
            Console.WriteLine("Enter student id :"); 
            int stdid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name :"); 
             string stdname = Console.ReadLine();

            student std = new student(stdid,stdname);
            std.display();

            Console.WriteLine();
            Console.WriteLine("Enter number of students :");
            int n=int.Parse(Console.ReadLine());
            students[] stds=new students[n];
            for(int i=0;i<stds.Length;i++)
            {
                Console.WriteLine("\n Enter Student Details :");
                Console.WriteLine("Enter student id :");
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student name :");
                string name=Console.ReadLine();
                stds[i] =new students(id,name);
            }
            for(int i=0; i<stds.Length;i++)
            {
                Console.WriteLine("student details :");
                stds[i].display();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Enter number of employees :");
            int num=Convert.ToInt32(Console.ReadLine());
            employeearray[] emp=new employeearray[num];
            Console.WriteLine("\n Enter Employee Details :");
            for (int i=0;i<emp.Length ; i++)
            {
                
                Console.WriteLine("Enter Employee id :");
               int eid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee name :");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter Employee salary:");
                double esal = double.Parse(Console.ReadLine());

                emp[i]=new employeearray(eid,ename,esal);
            }
            for(int i=1;i<emp.Length; i++)
            {
                Console.WriteLine("Employee Details :");
                emp[i].display1();
            }


        }
    }
}
