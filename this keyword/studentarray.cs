using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    class students
    {
        int Sid;
        string Sname;
        public students(int Sid, string Sname)
        {
            this.Sid = Sid;
            this.Sname = Sname;

        }
        public void display()
        {
            Console.WriteLine("Student id :" + Sid);
            Console.WriteLine("Student name :" + Sname);
            Console.WriteLine("-----------------------");
        }
    }


}
