using System;

namespace FractionClass
{
    class Fraction
    {
        private int top = 1;
        private int bottom = 1;

        public Fraction()
        {}

        public Fraction(int t)
        {
            top = t;
        }

        public Fraction(int t, int b)
        {
            top = t;
            bottom = b;
        }

        public int GetTop()
        {
            return top;
        }

        public void SetTop(int n)
        {
            top = n;
        }

        public int GetBottom()
        {
            return bottom;
        }

        public int SetBottom(int n)
        {
            if(n==0)
                return 1; //Error 1: Cannot divide by zero
            bottom = n;
            return 0; //No error
        }

        public string GetFractionString()
        {
            return top.ToString()+'/'+bottom.ToString();
        }

        public double GetDecimalValue()
        {
            return (double)top/bottom;
        }
    }
}