using System;

namespace Exercisez02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            foreach (var num in args)
            {
                Console.WriteLine(num);
                if (int.TryParse(num, out int intNum))
                {
                    sum += intNum;
                }
                
                        
                    
                    
            }
            Console.WriteLine(sum);
        }
    }
}
