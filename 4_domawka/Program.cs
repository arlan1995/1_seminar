int n;
              Console.WriteLine("N = ");
        n = (int) inputValue();
        int index;
        
        index = 1;
        while (index <= n )
        
            Console.Write(index.ToString() + " ");
            index = (index + 1);
            {
                if (n % 2 == 0 && n != 0){
                    Console.WriteLine("n");}    
            
                else
                {
                   
                }
                    
      }
 double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }

