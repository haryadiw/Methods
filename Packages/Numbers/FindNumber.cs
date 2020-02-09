using System;

namespace Numbers
{
    public class FindNumber
    {

        static public int FindMax(int[] @params)
        {

            int result = 0;

            foreach(int i in @params)
            {
                if(i > result)
                {
                    result = i;
                }
            }

            return result;

        }

        static public void FindMinMax(int[] @params, out int min, out int max)
        {

            min = 0;
            max = 0;

            foreach (int i in @params)
            {
                if (i > max)
                {
                    max = i;
                }

                if (i < min)
                {
                    min = i;
                }

            }


        }

        static public int FindMin(int[] @params, int n)
        {
            
            if (n == 1)
                return @params[0];

            return Math.Min(@params[n - 1], FindMin(@params, n - 1));


        }

        static public void addNumber(ref int a, int b)
        {
            a += b;
        }


    }
}
