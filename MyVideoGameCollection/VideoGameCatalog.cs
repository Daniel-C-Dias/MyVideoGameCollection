// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VideoGameCatalog.cs" company="DanielDias, Lda">
//   Copyright (c) Daniel Dias. All rights reserved.
// </copyright>
// <summary>
// WriteOnExcel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyVideoGameCollection
{
    using System;
    using System.Collections.Generic;

    public class VideoGameCatalog
    {
        private readonly List<VideoGame> VideoGameList = new List<VideoGame>();

        public VideoGameCatalog()
        {
        }

        public void AddVideoGameToList(VideoGame videogame)
        {
            this.VideoGameList.Add(videogame);
        }

        public void ShowVideoGames()
        {
            foreach (VideoGame game in VideoGameList)
            {
                Console.WriteLine(game.ToString());
            }
        }
    }
}