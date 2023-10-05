namespace ConsoleApp
{
  public class Calculator
  {
    public int attempts = 0;

    public float Add(float x, float y)
    {
      this.attempts++;
      return x + y;
    }

    public float Subtract(float x, float y)
    {
      this.attempts++;
      return x - y;
    }

    public float Divide(float x, float y)
    {
      this.attempts++;
      return x / y;
    }

    public float Multiply(float x, float y)
    {
      this.attempts++;
      return x * y;
    }
  }
}