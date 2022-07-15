using System;

namespace Subtraction
{
    public class Subt
    {
        public int Subtract(int a,int b)
        {
            if(a>b)
            {
                return b - a;
            }
            else
            {
                return a - b;
            }
        }
    }
}
