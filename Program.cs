using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagyobb
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      int b;

      Console.Write("First number: ");
      a = Convert.ToInt32(Console.ReadLine());

      Console.Write("Second number: ");
      b = Convert.ToInt32(Console.ReadLine());

      if (b > a)
      {
        Console.WriteLine("The second number is greater.");
      }
      else
      {
        Console.WriteLine("The first number is greater.");
      }



      Console.ReadKey();
    }
  }
}
