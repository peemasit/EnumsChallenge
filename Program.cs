using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsChallenge {
    class Program {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su }
        enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul , Aug, Sep, Oct, Nov, Dec }
        static void Main(string[] args) {
            Month jan = Month.Jan;
            Month may = Month.May;
            Console.WriteLine(jan);
            Console.WriteLine((int)may);
            Console.ReadKey();
        }
    }
}
