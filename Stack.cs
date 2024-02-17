using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        private ArrayList list;
        public int Count 
        {
            get { return list.Count; }
        }

        public Stack()
        {
            top = -1;
            list = new ArrayList(MAX);
        }

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(object item)
        {
            if (top > MAX)
            {
                throw new Exception("Stack Overflow");                
            }
            else
            {
                top++;
                list.Add(item);
                return true;
            }           
        }

        public object Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow.");
                return 0;
            }
            else 
            {
                Object obj = list[top];
                list.RemoveAt(top);
                top--;
                return obj;
            }            
        }

        public void Clear() 
        {
            list = new ArrayList();
            top = -1;
        }

        public object Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                Console.WriteLine("The topmost element of Stack is: {0}", list[top]);
                return list[top];
            }           
        }

        public bool Contains(object item) 
        {
            return list.Contains(item);
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
            }
            else
            {
                for(int i = top; i>= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
