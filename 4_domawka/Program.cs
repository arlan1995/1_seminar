using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        
        Console.WriteLine("N = ");
        n = (int) inputValue();
        int index;
        
        index = 1;
        while (index <= n )
        {
            Console.Write(index.ToString() + " ");
            index = (index + 1);
                if (index % 2 == 0)
                    Console.Write("index");
                else
                    Console.Write("no");
      }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
