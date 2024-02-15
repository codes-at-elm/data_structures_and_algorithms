namespace data_structure_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1 };
            Sort sort = new Sort(arr);
            arr = sort.BubbleSortAscending();
        }
    }
}
