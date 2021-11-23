using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    public class Factors
    {
        public void PrimeFact()
        {
            Console.WriteLine("Enter the number to calculate Prime Factorization :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (int i=2; i*i<=num; i++)
            {
                while(num%i==0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }
            if(num>1)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
    }
}