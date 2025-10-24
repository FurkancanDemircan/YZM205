using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Media : IComparable<Media>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float Duration { get; set; }

        public Media(int id, string title, float duration)
        {
            Id = id;
            Title = title;
            Duration = duration;
        }

        public virtual void Play()
        {
            Console.WriteLine($"Playing: {Title} ({Duration} min)");
        }

        public override string? ToString()
        {
            return $"{Id} {Title} {Duration}";
        }

        public int CompareTo(Media? other)
        {
            return Duration.CompareTo(other.Duration);
        }
    }
}
