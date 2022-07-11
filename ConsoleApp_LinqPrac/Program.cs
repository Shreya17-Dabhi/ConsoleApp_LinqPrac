using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
// changes
// unset  
namespace ConsoleApp_LinqPrac
{
    class Program
    {
        public static void Main(string[] args)
        {
            var person = Person.GetPersonData();
            var Pinfo = PersonInfo.GetPersonInfoData();

            // GroupBy
            var gb = from g in person
                     group g by g.salary into b
                     select new
                     {
                         Salary = b.Key,
                         PersonCount = b.Count()
                     };

            foreach (var item in gb)
            {
                Console.WriteLine($"{item.Salary} - {item.PersonCount}");
            }
            


            // OrderBy 
            //var ob = from o in person orderby o.salary,o.pname descending select o;
            //var ob = person.OrderByDescending(o => o.salary).ThenBy(o => o.pname);

            //foreach(var item in ob)
            //{
            //    Console.WriteLine($"{item.pname} - {item.salary}");
            //}

            // Left Outer Join Query Based
            //var loj = from pd in person
            //          join pi in Pinfo
            //          on pd.info equals pi.infoid into GroupedPerson
            //          from gp in GroupedPerson.DefaultIfEmpty()
            //          select new
            //          {
            //              PersonName = pd.pname,
            //              City = gp == null ? "No City" : gp.city
            //          };

            //foreach(var p in loj)
            //{
            //    Console.WriteLine($"{p.PersonName} - {p.City}");
            //}

            //Inner Join Query Based
            //var ij = from pd in person
            //         join pi in Pinfo
            //         on pd.info equals pi.infoid
            //         select new
            //         {
            //             PersonName = pd.pname,
            //             PeraonCity = pi.city,
            //             PersonCountry = pi.country
            //         };

            //foreach (var p in ij)
            //{
            //    Console.WriteLine($" Name : {p.PersonName} , City : {p.PeraonCity} , Country : {p.PersonCountry}");
            //}

            //Group Join Query Based
            //var gj = from pi in Pinfo
            //         join p in person
            //         on pi.infoid equals p.info into Groupedperson
            //         select new
            //         {
            //             City = pi.city,
            //             pergroup = Groupedperson
            //         };

            //foreach (var item in gj)
            //{
            //    Console.WriteLine($" CityName : {item.City}");
            //    foreach (var item2 in item.pergroup)
            //    {
            //        Console.WriteLine($"             {item2.pname}");
            //    }
            //}


            //METHOD based Linq
            /* var query = Person.Select(b => b.pname);
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