using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class MenuItemService
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

    internal void GetDrinks(int index)
    {
      if (index < Drinks.Count && index > -1)
      {
        Drink d = Drinks[index];  //creating an alias
        Messages.Add($@"
Title: {d.Title}
Price: {d.Price:c}
Description: {d.Description}

press any key to return to the main menu
        ");
      }
      else
      {
        Messages.Add("Invalid Choice");
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
    public MenuItemService()
    {
      Messages = new List<string>();
      Drinks = new List<Drink>();
      SetUp();
    }
  }
}