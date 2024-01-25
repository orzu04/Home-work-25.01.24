

public class BankAccount
{
    int accountId;
    decimal balance;
    public string?  OwnerName { get; set; }
    bool  isFrozen;


    public BankAccount(int accountId,decimal balance,string ownerName, bool isFrozen)
    {
        this.accountId = accountId;
         this.balance = balance;
       this.OwnerName = ownerName;
      this.isFrozen = isFrozen;




    }
    public void Deposit(decimal balance )
    {
        if(isFrozen==true)
        this.balance= this.balance+balance;
        
    }
    public void Withdraw(decimal balance)
    {
         if(isFrozen==true)
        this.balance= this.balance-balance;
    }
    public void FreezeAccount()
    {
        isFrozen=true;

    }
     public void UnfreezeAccount()
    {
        isFrozen=false;

    }






}
