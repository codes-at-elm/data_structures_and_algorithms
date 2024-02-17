using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal static class Search
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">Sorted integer array.</param>
        /// <param name="searchVal">Value to search in the array.</param>
        /// <returns>Returns index of item if the item is found in the array else returns -1.</returns>
        public static int BinarySearch(int[] arr, int searchVal)
        {
            int lowerIndex = 0;
            int upperIndex = arr.Length - 1;
            int midpoint;

            while (lowerIndex <= upperIndex)
            {
                midpoint = (lowerIndex + upperIndex) / 2;

                if (arr[midpoint] == searchVal)
                {
                    return midpoint;
                }
                else
                {
                    if (searchVal > arr[midpoint])
                    {
                        lowerIndex = midpoint + 1;
                    }
                    else
                    {
                        upperIndex = midpoint - 1;
                    }
                }
            }

            return -1;
        }

        public static int BinarySearchRecursive(int[] arr, int searchVal, int firstElementIndex, int lastElementIndex)
        {
            if (lastElementIndex >= firstElementIndex)
            {                
                int mid = (lastElementIndex + firstElementIndex) / 2;

                if (searchVal == arr[mid])
                    return mid;

                if (searchVal < arr[mid])
                    return BinarySearchRecursive(arr, searchVal, firstElementIndex, mid - 1);
                else
                    return BinarySearchRecursive(arr, searchVal, mid + 1, lastElementIndex);
            }

            return -1;
        }
    }
}
