// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="DanielDias, Lda">
//   Copyright (c) Daniel Dias. All rights reserved.
// </copyright>
// <summary>
// WriteOnExcel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyVideoGameCollection
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // WriteOnExcel.insertVideoGame(new VideoGame("test", "Sega Mega Drive", "test")); // Test if it's being writen on the excel file

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}