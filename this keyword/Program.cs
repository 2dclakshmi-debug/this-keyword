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



        }
    }
}
