namespace MyVideoGameCollection
{
    using System.Collections.Generic;

    public class VideoGameCatalog
    {
        private List<VideoGame> VideoGameList = new List<VideoGame>();

        public VideoGameCatalog()
        {
        }

        public void AddVideoGameToList(VideoGame videogame)
        {
            this.VideoGameList.Add(videogame);
        }
    }
}