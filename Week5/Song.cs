using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Song : Media
    {
        private Artist Artist { get; set; }

        public Song(int id, string title, float duration, Artist artist)
            : base(id, title, duration)
        {
            Artist = artist;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing Song: {base.ToString()} by {Artist.ToString()}");
        }
    }
}
