using System;

namespace Solution.Sorts
{
    public static class Sorts
    {
         public  static void QuickSort(int[] array,int left,int right)
        {
            int i = left, j = right;
            int pivot = array[left + (right - left >> 1)];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(array, left, j);
            }

            if (i < right)
            {
                QuickSort(array, i, right);
            }
        }

        public static void MergeSort()
        {

        }
    }    
}
