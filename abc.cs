// Correct
public class Account
{
  public static string BankName;
  public static decimal Reserves;      
  public string Number { get; set; }
  public DateTime DateOpened { get; set; }
  public DateTime DateClosed { get; set; }
  public decimal Balance { get; set; }     
  // Constructor
  public Account()
  {
    // ...
  }
}