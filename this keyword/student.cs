using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_keyword
{
    internal class student
    {
        public int stdid;
        public string stdname;
        public student( int stdid,string stdname)
        {
            this.stdid = stdid;
            this.stdname = stdname;
        }
        public void display()
        {
            Console.WriteLine("student id :" + stdid);
            Console.WriteLine("Student name :"+stdname);
        }

    }
}
