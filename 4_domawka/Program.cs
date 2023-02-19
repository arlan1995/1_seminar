int n;
        
        Console.WriteLine("N = ");
        n = (int) inputValue();
        int index;
        
        index = 1;
        while (index <= n)
        {
            if (index % 2 == 0)
            {
                Console.WriteLine(index);
                index = index + 1;
            }
            else
            {
                index = index + 1;
            }
        }
double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
