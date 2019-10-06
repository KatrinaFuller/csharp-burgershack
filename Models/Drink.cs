namespace csharp_burgershack.Models
{
  public class Drink : MenuItem
  {
    //props
    public bool WantToPurchase()
    {
      return true;
    }

    //constructor
    public Drink(string title, int price, string description) : base(title, price, description)
    {
    }
  }
}