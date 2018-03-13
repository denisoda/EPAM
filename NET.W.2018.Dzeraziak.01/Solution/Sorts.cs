using System;

namespace Solution.Sorts
{
    public static class Sorts
    {
        #region QickSort
        
        ///<summary>QuickSort implementation</summary>  
         public  static void QuickSort(int[] array,int left,int right)
        {
            int k = left, i = right;
            int pivot = array[left + (right - left >> 1)];

            while (k <= i)
            {
                while (array[k].CompareTo(pivot) < 0)
                {
                    k++;
                }

                while (array[i].CompareTo(pivot) > 0)
                {
                    i--;
                }

                if (k <= i)
                {
                    // Swaping
                    int tmp = array[k];
                    array[k] = array[i];
                    array[i] = tmp;

                    k++;
                    i--;
                }
            }

            // Recursive calls
            if (left < i)
            {
                QuickSort(array, left, i);
            }

            if (k < right)
            {
                QuickSort(array, k, right);
            }
        }

        #endregion

        public static void MergeSort()
        {

        }
    }    
}
