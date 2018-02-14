namespace MyVideoGameCollection
{
    public class VideoGame
    {
        public VideoGame(string name, string platform, string form)
        {
            this.Name = name;
            this.Platform = platform;
            this.Form = form;
        }

        public string Form { get; set; }
        public string Name { get; set; }

        public string Platform { get; set; }
    }
}