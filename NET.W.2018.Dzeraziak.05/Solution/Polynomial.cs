using System;
using Solution.Extensions;

namespace Solution.Polynom
{
    /// <summary>
    /// Class that represents the polynom
    /// <exeption>
    /// <paramref>
    ///     <name>coefficients</name>
    /// </paramref>
    ///     is null
    /// </exeption>
    /// </summary>
    public sealed class Polynom
    {
        private readonly double[] _coefficients;
        
        public Polynom(params double[] coefficients)
        {
            _coefficients = coefficients ?? throw new ArgumentNullException(nameof(coefficients));
        }

        public double this[int n]
        {
            get => _coefficients[n];
            set => _coefficients[n] = value; 
        }

        public int Order => _coefficients.Length;
        /// <summary>
        /// An overloading of the object's virtual method for the formatted output
        /// </summary>
        /// <returns>Formated string</returns>        
        public override string ToString() => string.Format("Coefficients:*" + string.Join(";*", _coefficients));

        /// <summary>
        /// A function which calculates two polynoms
        /// </summary>
        /// <param name="x">A real number coofficient</param>
        /// <returns>Calculated coofficient</returns>
        public double Calculate(double x)
        {
            int n = _coefficients.Length - 1;
            double results =_coefficients[n];

            for(int i = n - 1; i >= 0; i--)
                results = x * results + _coefficients[i];
            
            return results;
        }

        /// <summary>
        /// An overloading of the minus operator for polynom's objects 
        /// </summary>
        /// <param name="pFirst">First polynom</param>
        /// <param name="pSecond">Second polynom</param>
        /// <returns>A result of the substaction</returns>
        public static Polynom operator - (Polynom pFirst, Polynom pSecond)
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
            return new Polynom(result);
        }

        /// <summary>
        /// An overloading of the plus operator for polynom's objects 
        /// </summary>
        /// <param name="pFirst">First polynom</param>
        /// <param name="pSecond">Second polynom</param>
        /// <returns>A result of the addition</returns>
        public static Polynom operator +(Polynom pFirst, Polynom pSecond)
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

            return new Polynom(result);
        }
        
        /// <summary>
        /// An overloading of the multiplication operator for polynom's objects 
        /// </summary>
        /// <param name="pFirst">First polynom</param>
        /// <param name="pSecond">Second polynom</param>
        /// <returns>A result of the multiplication</returns>
        public static Polynom operator *(Polynom pFirst, Polynom pSecond)
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

            return new Polynom(result);
        }
    }
}
