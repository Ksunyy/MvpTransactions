public class Transaction
{
    public Guid guid{get; private set;}
    public decimal sum{get; set;}
    public Guid idUserSend{get; private set;}
    public Guid idUserGet{get; private set;}
    public TransactionType transactionType;

    public Transaction(decimal sum)
    {
        this.guid = Guid.NewGuid();
        this.sum = sum;

    }

}