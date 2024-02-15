using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class Sort
    {
        public int[] Arr { get; set; }

        public Sort(int[] arr)
        {
            Arr = arr;
        }

        public int[] BubbleSortAscending()
        {
            int temp = 0;

            for (int i = Arr.GetUpperBound(0); i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }

            return Arr;
        }
    }
}
