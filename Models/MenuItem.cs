namespace csharp_burgershack.Models
{
  public abstract class MenuItem
  {
    //props
    public string Title { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }


    //method
    public virtual string GetTemplate()
    {
      string template = $@"
Title: {Title}
Price: {Price:c}
Description: {Description}

press any key to return to the main menu
      ";
      return template;
    }

    //constructor
    public MenuItem(string title, int price, string description)
    {
      Title = title;
      Price = price;
      Description = description;
    }
  }
}