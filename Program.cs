using System;
using csharp_burgershack.Controllers;

namespace csharp_burgershack
{
  class Program
  {
    static void Main(string[] args)
    {
      MenuItemController dc = new MenuItemController();
      while (true)
      {
        dc.UserInput();
      }
    }
  }
}
