

namespace MyVideoGameCollection
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VideoGame
    {
        public string Name { get; set; }

        public string Platform { get; set; }

        public string Form { get; set; }

        public VideoGame(string name, string platform, string form)
        {
            this.Name = name;
            this.Platform = platform;
            this.Form = form;
        }

    }
}
