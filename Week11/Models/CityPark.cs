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
            return 0m;
        }
    }

}
