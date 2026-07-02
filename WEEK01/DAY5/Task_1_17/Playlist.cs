namespace Task_1_17
{
    public class Playlist
    {
        private readonly List<string> _songs = new();

        public int Count => _songs.Count;

        public void Add(string songTitle) => _songs.Add(songTitle);

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _songs.Count)
                    throw new IndexOutOfRangeException(
                        $"Index {index} is out of range. Playlist has {_songs.Count} song(s)."
                    );
                return _songs[index];
            }
            set
            {
                if (index < 0 || index >= _songs.Count)
                    throw new IndexOutOfRangeException(
                        $"Index {index} is out of range. Playlist has {_songs.Count} song(s)."
                    );
                _songs[index] = value;
            }
        }

        public string? this[string title] =>
            _songs.FirstOrDefault(s => string.Equals(s, title, StringComparison.OrdinalIgnoreCase));
    }
}
