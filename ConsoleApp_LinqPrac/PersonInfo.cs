using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LinqPrac
{
    public class PersonInfo
    {
        public int infoid { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public static IEnumerable<PersonInfo> GetPersonInfoData()
        {
            return new List<PersonInfo>
            {
                new PersonInfo{infoid=1,city="Rajkot",country="India"},
                new PersonInfo{infoid=2,city="A'Bad",country="India"},
                new PersonInfo{infoid=3,city="Surat",country="India"}
            };
        }
    }
}
