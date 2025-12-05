namespace Week11.Models
{
    public class CityPark : Park
    {
        public bool HasPlayground { get; set; }
        public int ParkingSpaces { get; set; }

        public CityPark()
        {
            ParkType = "CityPark";
        }

        public override decimal CalculateEntryFee(int visitors)
        {
            // City parks are free entry
            return 0m;
        }
    }

}
