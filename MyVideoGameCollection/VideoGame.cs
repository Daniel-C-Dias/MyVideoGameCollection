// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VideoGame.cs" company="DanielDias, Lda">
//   Copyright (c) Daniel Dias. All rights reserved.
// </copyright>
// <summary>
// WriteOnExcel
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MyVideoGameCollection
{
    public class VideoGame
    {
        public VideoGame(string name, string platform, string form)
        {
            this.Name = name;
            this.Platform = platform;

            if (form == null || form == "")
            {
                this.Form = "Physical";
            }
            else
            {
                this.Form = form;
            }
        }

        public VideoGame()
        {
        }

        public VideoGame(string name, string platform)
        {
            this.Name = name;
            this.Platform = platform;
            this.Form = "Physical";
        }

        public string Form { get; set; }
        public string Name { get; set; }

        public string Platform { get; set; }

        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}", this.Platform, this.Name, this.Form);
        }
    }
}