using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class DoublyLinkedList<T>
    {
        public Node<T>? header;

        public DoublyLinkedList()
        {
            header = null;
        }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = header;
            if (header != null) { header.Previous = node; }
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
            newNode.Previous = current;
        }

        public bool Remove(T value)
        {
            if (header == null) { return false; }

            if (header.Value.Equals(value))
            {
                header = header.Next;
                header.Previous = null;
                return true;
            }


            Node<T> current = header;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next.Next.Previous = current;
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
                    current.Next.Previous = nodeToInsert;
                    nodeToInsert.Next = current.Next;
                    nodeToInsert.Previous = current;
                    current.Next = nodeToInsert;
                    return true;
                }

                current = current.Next;
            }

            return false;
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
