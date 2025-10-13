namespace Week3
{
    public class BankRepository
    {
        private List<BankAccount> _accounts;

        public BankRepository()
        {
            _accounts = new List<BankAccount>();
        }

        // CRUD -> Create - Read - Update - Delete
        // HTTP -> Post - Get - Put - Delete

        public void AddAccount(BankAccount account)
        {
            account.AccountNumber = _accounts.Count; // + 1
            _accounts.Add(account);
        }

        public List<BankAccount> GetAllAccounts()
        {
            return _accounts;
        }

        public BankAccount GetAccountById(int accountNumber)
        {
            // LINQ
            /*
            _accounts
                .Where(item => item.AccountNumber.Equals(accountNumber))
                .FirstOrDefault();
            */
            foreach (var item in _accounts)
            {
                if (item.AccountNumber.Equals(accountNumber))
                    return item;
            }
            return null;
        }

        public void UpdateAccountName(int accountNumber, string firstName, string lastName)
        {
            var account = GetAccountById(accountNumber);
            if (account != null)
            {
                account.FirstName = firstName;
                account.LastName = lastName;
                return;
            }
        }

        public void DepositToAccount(int accountNumber, double balance)
        {
            var account = GetAccountById(accountNumber);
            if (account != null)
                account.Balance += balance;
        }

        public void WithdrawFromAccount(int accountNumber, double balance)
        {
            var account = GetAccountById(accountNumber);

            if (account != null && account.Balance > balance && balance > 0)
            {
                account.Balance -= balance;
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            var account = GetAccountById(accountNumber);
            if (account != null)
                _accounts.Remove(account);
        }
    }
}