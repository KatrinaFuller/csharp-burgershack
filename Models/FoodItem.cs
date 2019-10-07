using csharp_burgershack.Interfaces;

namespace csharp_burgershack.Models
{
  public class FoodItem : IConsumable
  {

    public string Name { get; set; }
    public int Calories { get; set; }
    public int Fat { get; set; }
    public int Protein { get; set; }
    public int Carbohydrates { get; set; }

    public FoodItem(string name, int calories, int fat, int protein, int carbohydrates)
    {
      Name = name;
      Calories = calories;
      Fat = fat;
      Protein = protein;
      Carbohydrates = carbohydrates;
    }

  }
}