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

        public static IEnumerable<Person> GetPersonData()
        {
            return new List<Person>
            {
               new Person{Pid=1,pname="Shreya",pemailid="std@gmail.com",pcontact="123456789",info=1},
               new Person{Pid=2,pname="Yesha",pemailid="y@gmail.com",pcontact="123123123",info=2},
               new Person{Pid=3,pname="Nisheeta",pemailid="nishee@gmail.com",pcontact="159159159",info=1},
               new Person{Pid=4,pname="Gopi",pemailid="gtdabhi@gmail.com",pcontact="357357357"},
            };
        }
    }
}
