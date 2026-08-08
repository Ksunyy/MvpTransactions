using System.Runtime.CompilerServices;

public class User
{
    public Guid guid {get; private set;}
    public string firstName {get;set;}
    public string lastName{get;set;}
    public string login {get; set;}
    public string email {get; set;}
    public List<Account> accounts{get; set;} = new();
    public UserType userType{get; private set;}
    public bool isConfirmed {get;set;} = false;


    private void generateIdLogin()
    {
        this.guid = Guid.NewGuid();
        this.login = "User_" + this.guid.ToString().Substring(0, 8);
    }

   public User()
    {
        this.generateIdLogin();
        
    }
    public User(UserType userType)
    {
        this.generateIdLogin();
        this.userType = userType;
    }

    public User(string mail, string fname, string lname)
    {
        setPersonalInfo(mail, fname, lname);
        this.generateIdLogin();
        
    }


    public void addAccountToUser()
    {
        if (isConfirmed)
        {
            Account newAccount = new Account(this);
            accounts.Add(newAccount);
        }
    }

    public void setPersonalInfo(string mail, string fname, string lname)
    {
        this.email = mail;
        this.firstName = fname;
        this.lastName = lname;
        
    }

}