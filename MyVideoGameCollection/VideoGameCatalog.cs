namespace MyVideoGameCollection
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class VideoGameCatalog
    {
        private List<VideoGame> VideoGameList = new List<VideoGame>();

        public void AddVideoGameToList(VideoGame videogame)
        {
            this.VideoGameList.Add(videogame);
        }

        public VideoGameCatalog() { }
    }
}
