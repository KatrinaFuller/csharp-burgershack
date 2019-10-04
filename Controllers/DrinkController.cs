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
      Console.WriteLine("Press Q to quit");
      string choice = Console.ReadLine().ToLower();
      switch (choice)
      {
        case "q":
          Environment.Exit(1);
          break;
      }
    }
  }
}