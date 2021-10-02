//Below code gets input from user

using System;

namespace UserInput
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name:");
      string name = Console.ReadLine();
      Console.WriteLine("Welcome " + name);
    }
  }
}
