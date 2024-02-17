namespace data_structure_and_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sorting            
            //int[] arr = { 64, 25, 12, 22, 11 };
            //arr = Sort.BubbleSortAsc(arr);
            //arr = Sort.BubbleSortAscRecursive(arr, arr.Length);
            //arr = Sort.SelectionSortAsc(arr);
            //arr = Sort.InsertionSortAsc(arr);
            #endregion

            #region Searching 
            //int[] arr = new int[] { 1, 25, 50, 75, 82, 100 };
            //int index = Search.BinarySearch(Sort.BubbleSortAsc(arr), 64);
            //int index = Search.BinarySearchRecursive(Sort.BubbleSortAsc(arr), 105, 0, arr.Length - 1);
            #endregion

            #region
            Stack stack = new Stack();
            stack.Pop();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.PrintStack();
            stack.Peek();
            Console.WriteLine("Item popped from Stack: {0}", stack.Pop());
            stack.PrintStack();
            #endregion
        }
    }
}
