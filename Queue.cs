using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class Queue
    {
        private ArrayList list; 
        public Queue() 
        {
            list = new ArrayList();
        }
        public void EnQueue(object item)
        {
            list.Add(item);
        }
        public object DeQueue()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            object obj = list[0];
            list.RemoveAt(0);
            return obj;
        }
        public object Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return list[0];
        }
        public void ClearQueue()
        {
            list.Clear();
        }

        public int Count => list.Count;

        public bool IsEmpty => list.Count == 0;
    }
}
