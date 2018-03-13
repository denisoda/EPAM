using System;

namespace Solution.Sorts
{
    public static class Sorts
    {
        #region QickSort

        ///<summary>Custom quickSort implementation</summary>  
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

        ///<summary>Custom merge sort implementation</summary>
        public static void MergeSort(int[] input, int low, int high)
    {
        if (low < high)
        {
            int middle = (low / 2) + (high / 2);
            MergeSort(input, low, middle);
            MergeSort(input, middle + 1, high);
            Merge(input, low, middle, high);
        }
    }

    public static void MergeSort(int[] input)
    {
        MergeSort(input, 0, input.Length - 1);
    }

    private static void Merge(int[] input, int low, int middle, int high)
    {

        int left = low;
        int right = middle + 1;
        int[] tmp = new int[(high - low) + 1];
        int tmpIndex = 0;

        while ((left <= middle) && (right <= high))
        {
            if (input[left] < input[right])
            {
                tmp[tmpIndex] = input[left];
                left = left + 1;
            }
            else
            {
                tmp[tmpIndex] = input[right];
                right = right + 1;
            }
            tmpIndex = tmpIndex + 1;
        }

        if (left <= middle)
        {
            while (left <= middle)
            {
                tmp[tmpIndex] = input[left];
                left = left + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        if (right <= high)
        {
            while (right <= high)
            {
                tmp[tmpIndex] = input[right];
                right = right + 1;
                tmpIndex = tmpIndex + 1;
            }
        }

        for (int i = 0; i < tmp.Length; i++)
        {
            input[low + i] = tmp[i];
        }

    }

    public static string PrintArray(int[] input)
    {
        string result = String.Empty;

        for (int i = 0; i < input.Length; i++)
        {
            result = result + input[i] + " ";
        }
        if (input.Length == 0)
        {
            result = "Array is empty.";
            return result;
        }
        else
        {
            return result;
        }
    }
    }    
}
