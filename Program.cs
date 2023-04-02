using System.Linq;

namespace Cashier
{
  class Program
  {
    static void Main(string[] args)
    {
        var handler = new FileStreamHandler();

        var menu = new MenuController();
        menu.Run();
    }
  }
}