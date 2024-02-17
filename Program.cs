namespace data_structure_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            #region Sorting            
            //arr = Sort.BubbleSortAsc(arr);
            //arr = Sort.BubbleSortAscRecursive(arr, arr.Length);
            //arr = Sort.SelectionSortAsc(arr);
            //arr = Sort.InsertionSortAsc(arr);
            #endregion

            #region Searching 
            int index = Search.BinarySearch(Sort.BubbleSortAsc(arr), 64);
            #endregion
        }
    }
}
