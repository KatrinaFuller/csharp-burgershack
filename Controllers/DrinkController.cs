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
            _drinkService.GetDrinks(index - 1); //prints the drink details
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
      foreach (string message in _drinkService.Messages)
      {
        System.Console.WriteLine(message); //after this loop need to empty this message
      }
      Console.WriteLine("Type a number to see details or Q to quit");
      _drinkService.Messages.Clear();  //prints them and then empties the list
    }


  }
}