namespace data_structure_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Sort sort = new Sort();
            //arr = sort.BubbleSortAsc(arr);
            //arr = sort.BubbleSortAscRecursive(arr, arr.Length);
            arr = sort.SelectionSortAsc(arr);
        }
    }
}
