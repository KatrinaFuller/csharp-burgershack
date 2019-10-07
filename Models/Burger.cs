using System.Collections.Generic;
using csharp_burgershack.Interfaces;

namespace csharp_burgershack.Models
{
  public class Burger : FoodItem, IPurchasable, ISize
  {
    public string Type { get; set; }
    public double BasePrice { get; set; }
    public IEnumerable<string> Toppings { get; set; }
    public double SizeMultiplier { get; set; }


    public double GetPrice(Size s)
    {
      return BasePrice + (SizeMultiplier * (int)size);
    }

    public Burger(string name, int calories, int fat, int protien, int carbohydrates, string meat, double price, IEnumerable<string> toppings) : base(name, calories, fat, protien, carbohydrates)
    {
      Type = meat;
      BasePrice = price;
      Toppings = toppings;
    }

  }
}