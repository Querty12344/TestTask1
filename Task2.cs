using System;

namespace PiApproximation
{
  internal class Task2
  {
    public static void Main(string[] args)
    {
      CalculatePi(200000);
    }

    public static void CalculatePi(int dotsCount)
    {
      Random r = new Random();
      int pointInCircleBounds = 0;
      for (int i = 0; i < dotsCount; i++)
      {
        double x = r.NextDouble();
        double y = r.NextDouble();
        if (x * x + y * y < 1)
        {
          pointInCircleBounds++;
        }
      }

      double pi = 4f * pointInCircleBounds/dotsCount;
      Console.WriteLine(" Pi :  " + pi);
      Console.WriteLine(pi);
    }
  }
}