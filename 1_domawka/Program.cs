
        int x;
        int y;
        int max;
        
        Console.WriteLine("x = ");
        x = (int) inputValue();
        Console.WriteLine("y = ");
        y = (int) inputValue();
        Console.WriteLine("max = ");
        max = x;
        if (x < y)
        {
            Console.WriteLine(y);
        }
        else
        {
            Console.WriteLine(x);
        }
double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }

