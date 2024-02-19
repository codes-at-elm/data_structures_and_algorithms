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

            #region LinkedList

            //LinkedList<int> linkedList = new LinkedList<int>();
            //linkedList.Print();
            //bool status = linkedList.Remove(15);
            //status = linkedList.Contains(15);
            //Node<int>? node = linkedList.Find(15);
            //status = linkedList.Insert(15, 10);
            //linkedList.AddFirst(1);
            //linkedList.AddLast(2);
            //linkedList.AddLast(3);            
            //linkedList.Print();
            //linkedList.AddLast(5);
            //linkedList.Print();
            //linkedList.Insert(4, 3);
            //linkedList.Print();
            //linkedList.AddFirst(100);
            //linkedList.Print();
            //linkedList.Remove(100);
            //linkedList.Print();
            //status = linkedList.Contains(5);
            //node = linkedList.Find(3);
            //linkedList.Reverse(); ;
            //linkedList.Print();

            #endregion

            #region DoublyLinkedList
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Print();
            bool status = doublyLinkedList.Remove(15);
            status = doublyLinkedList.Contains(15);
            Node<int>? node = doublyLinkedList.Find(15);
            status = doublyLinkedList.Insert(15, 10);
            doublyLinkedList.AddFirst(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);
            doublyLinkedList.Print();
            doublyLinkedList.AddLast(5);
            doublyLinkedList.Print();
            doublyLinkedList.Insert(4, 3);
            doublyLinkedList.Print();
            doublyLinkedList.AddFirst(100);
            doublyLinkedList.Print();
            doublyLinkedList.Remove(100);
            doublyLinkedList.Print();
            status = doublyLinkedList.Contains(5);
            node = doublyLinkedList.Find(3);            
            doublyLinkedList.Print();

            #endregion
        }
    }
}
