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
      Messages.Add("Available Drinks");
      for (int i = 0; i < Drinks.Count; i++)
      {
        Drink d = Drinks[i];
        Messages.Add($"{i + 1}: {d.Title} {d.Price}"); //adds to the message

      }
    }


    //constructor
    public DrinkService()
    {
      Drinks = new List<Drink>();
    }
  }
}