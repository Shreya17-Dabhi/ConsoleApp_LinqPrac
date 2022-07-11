using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// changes
namespace ConsoleApp_LinqPrac
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Person = PersonDatabase.GetPersonData();
            var Pinfo = PersonInfo.GetPersonInfoData();

            // Inner Join
            var data = from p1 in Person
                       join p2 in Pinfo
                       on p1.info equals p2.infoid
                       select new
                       {
                           PersonName = p1.pname,
                           PersonCity = p2.city
                       };

            foreach(var item in data)
            {
                Console.WriteLine($"{item.PersonName} - {item.PersonCity}");
            }

            //METHOD based Linq
            /*var query = Person.Select(b => b.pname);
            var query = Person.Select(b => new
            {
                PersonName = b.pname,
                PersonEmailId = b.pemailid,
                PersonCity = b.pcontact
            }); 

            //QUERY based Linq
            var query = from p in Person select p.pname;
            var query = from p in Person
                        select new
                        {
                            PersonName = p.pname,
                            PersonEmailId = p.pemailid,
                            PersonCity = p.pcontact
                        }; */

            //var query = Person.Where(p => p.Pid > 1); (select query)

            //var q2 = from p in Person where p.Pid == 1 select p.pname;

            //foreach(var item1 in q2)
            //{
            //    Console.WriteLine(item1);
            //}

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.pname} - {item.pemailid} - {item.pcontact}");
            //}

            Console.ReadLine();
        }
    }
}