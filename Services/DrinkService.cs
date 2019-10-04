using System.Collections.Generic;
using csharp_burgershack.Models;

namespace csharp_burgershack.Services
{
  public class DrinkService
  {
    //prop
    public List<Drink> Drinks { get; set; }


    //constructor
    public DrinkService()
    {
      Drinks = new List<Drink>();
    }
  }
}