using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class MenuItemService
  {
    //prop
    public List<MenuItem> MenuItem { get; set; }
    public List<string> Messages { get; set; }

    //method
    public void GetDrinks()
    {
      Messages.Add("--- Burger Shack Menu ---");
      for (int i = 0; i < MenuItem.Count; i++)
      {
        MenuItem d = MenuItem[i];
        Messages.Add($"{i + 1}: {d.Title} ${d.Price}"); //adds to the message

      }
      Messages.Add("Type a number to see details or Q to quit");
    }

    internal void GetDrinks(int index)
    {
      if (index < MenuItem.Count && index > -1)
      {
        MenuItem menuItem = MenuItem[index];  //creating an alias
        Messages.Add(menuItem.GetTemplate());
        if (menuItem is Drink)
        {
          Drink drinkMenuItem = (Drink)menuItem;
          drinkMenuItem.WantToPurchase();
        }
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

      Entree dburger = new Entree("Double Cheese Burger", 8, "Delicious cheese burger from Culvers");
      Entree burger = new Entree("Cheese Burger", 7, "Delicious cheese burger");
      Entree sandwhich = new Entree("Chicken Sandwich", 7, "Healthier option from a burger");
      Entree nuggets = new Entree("Chicken Nuggets", 5, "5 piece chicken nuggets");

      Side fries = new Side("French fries", 2, "perfect crispy fries");
      Side curlyFries = new Side("Curly Fries", 3, "when regular fries are not fun enough");
      Side curds = new Side("Cheese curds", 3, "delicious fried cheese");
      Side apple = new Side("Apple slices", 2, "a healthy option instead of fries");

      MenuItem.AddRange(new MenuItem[] { drpepper, chocolateSmoothie, coffee, monster, dburger, burger, sandwhich, nuggets, fries, curlyFries, curds, apple });
    }


    //constructor
    public MenuItemService()
    {
      Messages = new List<string>();
      MenuItem = new List<MenuItem>();
      SetUp();
    }
  }
}