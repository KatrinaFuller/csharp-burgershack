using System;
using csharp_burgershack.Controllers;

namespace csharp_burgershack
{
  class Program
  {
    static void Main(string[] args)
    {
      DrinkController dc = new DrinkController();
      while (true)
      {
        dc.UserInput();
      }
    }
  }
}
