namespace Week11.Models
{
    public abstract class Park
    {
        private int _currentVisitors;
        private int _visitorLimit;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double AreaInKm { get; set; }
        public string ParkType { get; set; }

        public int VisitorLimit
        {
            get => _visitorLimit;
            set => _visitorLimit = value > 0 ? value : 100;
        }

        public int CurrentVisitors
        {
            get => _currentVisitors;
            private set => _currentVisitors = value;
        }

        public bool IsFull() => CurrentVisitors >= VisitorLimit;

        public bool AddVisitors(int count)
        {
            if (CurrentVisitors + count <= VisitorLimit)
            {
                CurrentVisitors += count;
                return true;
            }
            return false;
        }

        public void RemoveVisitors(int count)
        {
            CurrentVisitors = Math.Max(0, CurrentVisitors - count);
        }

        public abstract decimal CalculateEntryFee(int visitors);
    }

}
