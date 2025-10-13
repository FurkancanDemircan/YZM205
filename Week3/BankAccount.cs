namespace Week3
{
    public class BankAccount
    {
        private DateTime _createDate;

        private double _balance;

        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0) return;
                _balance = value;
            }
        }

        public DateTime CreateDate
        {
            get { return _createDate; }
        }

        public BankAccount()
        {
            _balance = 0;
            _createDate = DateTime.Now;
        }

    }
}