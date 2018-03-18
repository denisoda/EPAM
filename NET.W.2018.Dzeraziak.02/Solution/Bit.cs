using System;
using Sort;

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
        public static int InsertNumber(int numberSource, int numberInsert, int start, int end)
        {
            if (end < start)
            {
                throw new ArgumentException($" {nameof(end)} could not less than {nameof(start)} ");
            }

            const int MAXBITS = 31;
            const int MINBITS = 0;

            if ((start < MINBITS || start > MAXBITS) || (end > MAXBITS || end < MINBITS))
            {
                throw new ArgumentException($"Parameters goes range");
            }

            for (int i = start, j = 0; i <= end; i++, j++)
            {
                if ((numberInsert & (1 << j)) == 0)
                {
                    numberSource = numberSource & ~(1 << i);
                }
                else
                {
                    numberSource = numberSource | (1 << i);
                }
            }

            return numberSource;
        }
    }
}