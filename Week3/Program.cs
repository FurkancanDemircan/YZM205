using Week3;

BankRepository repository = new BankRepository();

repository.AddAccount(new BankAccount()
{
    FirstName="A",
    LastName="A",
    Balance=1500
});
repository.AddAccount(new BankAccount()
{
    FirstName="B",
    LastName="A",
    Balance=-1500
});
repository.AddAccount(new BankAccount()
{
    FirstName="C",
    LastName="A",
    Balance=5500
});

repository.UpdateAccountName(1, "Veli", "Tepe");
repository.DepositToAccount(1, 450);
repository.WithdrawFromAccount(0, 4500);

foreach (var item in repository.GetAllAccounts())
{
    Console.WriteLine($"{item.AccountNumber} {item.FirstName} {item.LastName} {item.Balance} {item.CreateDate}");
}