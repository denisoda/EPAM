using System;
using System.Collections;

namespace Fibo
{
    public static class Fibo 
    {
        public static IEnumerable Generate(int number)
        {
            for(int i = 0; i < number; i++)
            {
                int first = 0;
                int second = 1;
                int temp = first + second;

                first = second;
                second = temp;

                yield return first;
            }
        }
    }
}
