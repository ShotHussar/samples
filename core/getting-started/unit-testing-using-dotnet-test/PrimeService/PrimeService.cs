using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            int a = 0;
            for (int i = 1; i <= candidate; i++)
            {
                if (candidate % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}