using System;

namespace Solution
{
    /// <summary>
    /// Class that represents a mathematician polynom
    /// </summary>
    public sealed class Polynomial
    {
        double[] _coefficients;

        Polynomial(params double[] coefficients)
        {
            _coefficients = coefficients;
        }

        public double this[int n]
        {
            get => _coefficients[n];
            set => _coefficients[n] = value; 
        }

        public int Order => _coefficients.Length;

        public override string ToString() => string.Format("Coefficients:*" + string.Join(";*", _coefficients));

        public double Calculate(double x)
        {
            int n = _coefficients.Length - 1;
            double results =_coefficients[n];

            for(int i = n - 1; i >= 0; i--)
                results = x * results + _coefficients[i];
            
            return results;
        }

        public static Polynomial operator - (Polynomial pFirst, Polynomial pSecond)
        {
            int itemCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemCount];
            for(int i = 0; i < itemCount; i++)
            {
                    double a = 0;
                    double b = 0;
                    if (i < pFirst._coefficients.Length)
                    {
                        a = pFirst[i];
                    }
                    if (i < pSecond._coefficients.Length)
                    {
                        b = pSecond[i];
                    }
                    result[i] = a - b;
            }
            return new Polynomial(result);
        }

        public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
            var result = new double[itemsCount];
            for (int i = 0; i < itemsCount; i++)
            {
                double a = 0;
                double b = 0;
                if (i < pFirst._coefficients.Length)
                {
                    a = pFirst[i];
                }
                if (i < pSecond._coefficients.Length)
                {
                    b = pSecond[i];
                }
                result[i] = a + b;
            }

            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
        {
            int itemsCount = pFirst._coefficients.Length + pSecond._coefficients.Length - 1;
            var result = new double[itemsCount];
            for (int i = 0; i < pFirst._coefficients.Length; i++)
            {
                for (int j = 0; j < pSecond._coefficients.Length; j++)
                {
                    result[i + j] += pFirst[i] * pSecond[j];
                }
            }

            return new Polynomial(result);
        }
    }
}
