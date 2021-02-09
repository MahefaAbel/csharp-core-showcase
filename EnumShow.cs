using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_core_showcase
{
    class EnumShow
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            Console.Write(Days.Sun);

            Console.ReadKey();
        }
    }
}
