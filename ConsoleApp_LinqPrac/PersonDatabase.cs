using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LinqPrac
{
    public class PersonDatabase
    {
        public static IEnumerable<Person> GetPersonData()
        {
            return new List<Person>
            {
                new Person(1,"Shreya","std@gmail.com","123456789",1),
                new Person(2,"Yesha","y@gmail.com","987654321",2),
                new Person(3,"Gopi","g123@gmail.com","121212121",3)
            };
        }
    }
}
