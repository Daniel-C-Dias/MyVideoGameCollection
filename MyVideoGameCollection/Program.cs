using System;

namespace MyVideoGameCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VideoGameCatalog videoGameCatalog = ReadFromExcel.getVideoGames();
            videoGameCatalog.ShowVideoGames();

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}