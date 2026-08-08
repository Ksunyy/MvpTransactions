public class Account
{
    public Guid uuid{get; private set;}
    public decimal amountOfMoney{get; private set;}

    public Guid userId{get; private set;}

    public AccountStatus status{get; set;} =0;

    public Account(User user) 
    {
        this.uuid = Guid.NewGuid();
        this.amountOfMoney = decimal.Zero;
        this.userId = user.guid;

    }

}