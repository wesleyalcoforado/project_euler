using System;

namespace ProjectEuler
{
    class Problem2
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2, sum = num2;
            int aux;

            while (num1 + num2 <= 4000000)
            {
                aux = num1;
                num1 = num2;
                num2 = aux + num1;

                if (num2 % 2 == 0) 
                {
                    sum += num2;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
