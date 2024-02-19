using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class LinkedList<T>
    {
        public Node<T>? header;

        public LinkedList()
        {
            header = null;
        }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = header;
            header = node;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (header == null)
            {
                header = newNode;
            }

            Node<T> current = header;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public bool Remove(T value)
        {
            if (header == null) { return false; }

            if (header.Value.Equals(value))
            {
                header = header.Next;
                return true;
            }


            Node<T> current = header;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            Node<T> current = header;
            while (current != null)
            {
                if (current.Value.Equals(value)) { return true; }
                current = current.Next;
            }

            return false;
        }

        public Node<T>? Find(T value)
        {
            Node<T> current = header;
            while (current != null)
            {
                if (current.Value.Equals(value)) { return current; }
                current = current.Next;
            }

            return null;
        }

        public bool Insert(T value, T after)
        {
            Node<T> current = header;
            while (current != null)
            {
                if (current.Value.Equals(after))
                {
                    Node<T> nodeToInsert = new Node<T>(value);
                    nodeToInsert.Next = current.Next;
                    current.Next = nodeToInsert;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Reverse()
        {
            Node<T> previous = null;
            Node<T> current = header;

            while (current != null)
            {
                Node<T> next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            header = previous;
        }

        public void Print()
        {
            Node<T> current = header;
            while (current != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }

            Console.WriteLine();
        }


    }
}
