using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class DrinkService
  {
    //prop
    public List<Drink> Drinks { get; set; }
    public List<string> Messages { get; set; }

    //method
    public void GetDrinks()
    {
      Messages.Add("--- Available Drinks ---");
      for (int i = 0; i < Drinks.Count; i++)
      {
        Drink d = Drinks[i];
        Messages.Add($"{i + 1}: {d.Title} ${d.Price}"); //adds to the message

      }
    }

    public void SetUp()
    {
      Drink drpepper = new Drink("Dr Pepper", 5, "The best soda eva");
      Drink chocolateSmoothie = new Drink("Chocolate Smoothie", 7, "Yummy chocolate");
      Drink coffee = new Drink("Coffee", 4, "For Stephanie");
      Drink monster = new Drink("Monster", 6, "When you really need some energy");

      Drinks.AddRange(new Drink[] { drpepper, chocolateSmoothie, coffee, monster });
    }


    //constructor
    public DrinkService()
    {
      Messages = new List<string>();
      Drinks = new List<Drink>();
      SetUp();
    }
  }
}