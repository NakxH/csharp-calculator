namespace ConsoleApp
{
  internal class Progam
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Console App Running");
      var calculator = new Calculator();

      do
      {
        Console.WriteLine("Enter a Command (Add, Multiply, Subtract, Divide)");
        var command = Console.ReadLine()?.ToLower();

        if (string.IsNullOrEmpty(command) || (command != "add" && command != "subtract" && command != "divide" && command != "multiply"))
        {
          Console.WriteLine("Try again...");
          continue;
        }

        Console.WriteLine("Enter first number");
        var x = Console.ReadLine();

        if (string.IsNullOrEmpty(x) || !float.TryParse(x, out float xParsed))
        {
          Console.WriteLine("Nope that is not a number you are going back to the beginning");
          continue;
        }

        Console.WriteLine("Enter second number");
        var y = Console.ReadLine();

        if (string.IsNullOrEmpty(y) || !float.TryParse(y, out float yParsed))
        {
          Console.WriteLine("Nope that is not a number you are going back to the beginning");
          continue;
        }

        switch (command.ToLower())
        {
          case "add":
            Console.WriteLine("Your answer is... \n\n{0}", calculator.Add(xParsed, yParsed).ToString());
            break;
          case "subtract":
            Console.WriteLine("Your answer is... \n\n{0}", calculator.Subtract(xParsed, yParsed).ToString());
            break;
          case "divide":
            Console.WriteLine("Your answer is... \n\n{0}", calculator.Divide(xParsed, yParsed).ToString());
            break;
          case "multiply":
            Console.WriteLine("Your answer is... \n\n{0}", calculator.Multiply(xParsed, yParsed).ToString());
            break;
          default:
            break;
        }
      } while (true);
    }
  }
}