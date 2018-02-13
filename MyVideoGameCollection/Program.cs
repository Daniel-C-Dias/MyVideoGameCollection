using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVideoGameCollection
{
    class Program
    {

        static void Main(string[] args)
        {
            ReadFromExcel.getExcelFile();

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
