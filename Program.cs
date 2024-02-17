using System.Collections.Generic;

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

            #region Stack
            /*
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
            */
            #endregion

            #region Queue
            /*
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            Console.WriteLine($"Peek: {queue.Peek()}"); // Peek at the first item
            Console.WriteLine($"Dequeue: {queue.Dequeue()}"); // Dequeue the first item
            Console.WriteLine($"Peek after dequeue: {queue.Peek()}"); // Peek again
            Console.WriteLine($"Queue size: {queue.Count}");
            */
            #endregion

            #region Palindrome
            /*
            // Test cases for IsPalindrome method
            Console.WriteLine(Palindrome.IsPalindrome("Racecar")); // Should return true
            Console.WriteLine(Palindrome.IsPalindrome("hello"));   // Should return false
            Console.WriteLine(Palindrome.IsPalindrome("Madam"));   // Should return true
            Console.WriteLine(Palindrome.IsPalindrome("12321"));   // Should return true

            // Additional test cases that should return false
            Console.WriteLine(Palindrome.IsPalindrome("apple"));   // Should return false
            Console.WriteLine(Palindrome.IsPalindrome("12345"));   // Should return false
            Console.WriteLine(Palindrome.IsPalindrome("Palindrome")); // Should return false
            */
            #endregion
        }
    }
}
