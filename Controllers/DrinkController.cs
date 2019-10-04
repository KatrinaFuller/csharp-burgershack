using System;
using csharp_burgershack.Services;

namespace csharp_burgershack.Controllers
{
  public class DrinkController
  {
    //prop
    private DrinkService _drinkService { get; set; } = new DrinkService();

    //method
    public void UserInput()
    {
      _drinkService.GetDrinks();  //now messages have been populated
      Print();
      Console.WriteLine("Press Q to quit");
      string choice = Console.ReadLine().ToLower();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
      }
    }

    private void Print() //this is just like a draw function
    {
      foreach (string message in _drinkService.Messages)
      {
        System.Console.WriteLine(message); //after this loop need to empty this message
        _drinkService.Messages.Clear();  //prints them and then empties the list
        Console.WriteLine("Type a number to see details or Q to quit");
      }
    }


  }
}