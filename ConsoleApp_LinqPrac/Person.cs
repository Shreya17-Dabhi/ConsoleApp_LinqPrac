using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LinqPrac
{
    public class Person
    {
        public int Pid { get; set; }
        public string pname { get; set; }
        public string pemailid { get; set; }
        public string pcontact { get; set; }
        public int info { get; set; }

        public Person(int pid, string pname, string pemailid, string pcontact, int info)
        {
            Pid = pid;
            this.pname = pname;
            this.pemailid = pemailid;
            this.pcontact = pcontact;
            this.info = info;
        }
    }
}
