using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Podcast : Media
    {
        private Host Host { get; set; }

        public Podcast(int id, string title, float duration, Host host) : base(id, title, duration)
        {
            Host = host;
        }

        public override void Play()
        {
            Console.WriteLine($"Playing Podcast: {base.ToString()} hosted by {Host.ToString()}");
        }
    }
}
