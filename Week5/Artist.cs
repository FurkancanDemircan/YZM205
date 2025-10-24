namespace Week5
{
    public class Artist : Person
    {
        public string Country { get; set; }

        public Artist(int id, string name, string country) : base(id, name)
        {
            Country = country;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Country}";
        }
    }
}