using System;

namespace MyVideoGameCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ReadFromExcel.getExcelFile();

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}