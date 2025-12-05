namespace Week11.Models
{
    public class NationalPark : Park
    {
        public bool HasCampingFacility { get; set; }
        public int NumberOfTrails { get; set; }

        public NationalPark()
        {
            ParkType = "NationalPark";
        }

        public override decimal CalculateEntryFee(int visitors)
        {
            decimal baseFee = visitors * 15m;
            return HasCampingFacility ? baseFee + (visitors * 5m) : baseFee;
        }
    }

}
