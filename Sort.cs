﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class Sort
    {
        public int[] BubbleSortAsc(int[] arr)
        {
            int temp = 0;

            for (int i = arr.GetUpperBound(0); i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public int[] BubbleSortAscRecursive(int[] arr, int n)
        {
            if (n == 1)
                return arr;

            int temp = 0;
            int count = 0;

            for (int i = arr.GetUpperBound(0); i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        count++;
                    }
                }
            }

            if (count == 0)
                return arr;

            return BubbleSortAscRecursive(arr, n - 1);
        }

        public int[] SelectionSortAsc(int[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));

            int smallestIndex = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                smallestIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallestIndex])
                        smallestIndex = j;
                }

                temp = arr[i];
                arr[i] = arr[smallestIndex];
                arr[smallestIndex] = temp;

                Console.WriteLine(string.Join(" ", arr));
            }

            return arr; 
        }
    }
}
