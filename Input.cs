namespace ConsoleApp
{
  public class InputHandler
  {
    public void Listen()
    {
      do
      {
        var text = Console.ReadLine();
        Console.WriteLine(text);
      } while (true);
    }
  }
}