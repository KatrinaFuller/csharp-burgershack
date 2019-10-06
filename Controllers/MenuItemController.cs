using System;
using csharp_burgershack.Services;

namespace csharp_burgershack.Controllers
{
  public class MenuItemController
  {
    //prop
    private MenuItemService _menuItemService { get; set; } = new MenuItemService();

    //method
    public void UserInput()
    {
      _menuItemService.GetDrinks();  //now messages have been populated
      Print();
      string choice = Console.ReadLine().ToLower();
      Console.Clear();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
        default:
          if (int.TryParse(choice, out int index)) //to figure out if it is a number
          {
            _menuItemService.GetDrinks(index - 1); //prints the drink details
            Print();
            Console.ReadKey();
            Console.Clear();
          }
          else
          {
            System.Console.WriteLine("Invalid Command!");
          }
          break;

      }
    }

    private void Print() //this is just like a draw function
    {
      foreach (string message in _menuItemService.Messages)
      {
        System.Console.WriteLine(message); //after this loop need to empty this message
      }
      _menuItemService.Messages.Clear();  //prints them and then empties the list
      System.Console.WriteLine();
    }


  }
}