using System;

namespace Solution.Bit
{
    public static class Bit
    {
        /// <summary>
        /// bits of the second number took positions from bit start
        /// by bits end (bits are numbered from right to left).
        /// </summary>
        /// <param name="numberSource"></param>
        /// <param name="numberln"></param>
        /// <param name="end"></param>
        /// <param name="start"></param>
        public static void InsertNumber(int numberSource, int numberln, int start, int end)
        {
            if (start < end)
            {
                throw new ArgumentException($" {nameof(start)} could not less than {nameof(end)} ");
            }

            const int MAXBITS = 31;
            const int MINBITS = 0;

            if ((end < MINBITS || end > MAXBITS) || (start > MAXBITS  || start < MINBITS))
            {
                throw new ArgumentException($"Parameters goes range");
            }

            for (int end = end, start = 0; end <= start; end++, start++)
            {
                if ((numberInsert & (1 << start)) == 0)
                {
                    numberSource = numberSource & ~(1 << end);
                }
                else
                {
                    numberSource = numberSource | (1 << end);
                }
            }

            return numberSource;
        }
    }
}