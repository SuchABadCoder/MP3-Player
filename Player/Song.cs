namespace Player
{
    class Song
    {
        public string Title { get; set; }
        public string Performer { get; set; }
        public uint Year { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string Path { get; set; }

        public Song(string title, string performer, uint year, string album, string genre, string path)
        {
            Title = title;
            Performer = performer;
            Year = year;
            Album = album;
            Genre = genre;
            Path = path;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
