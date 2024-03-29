﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_and_algorithms
{
    internal class Node<T>
    {
        public T? Value { get; set; }
        public Node<T>? Next { get; set; }
        public Node<T>? Previous { get; set; }
        public Node()
        {
            Value = default(T);
            Next = null;
            Previous = null;
        }

        public Node(T? value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }

    //internal class Node
    //{
    //    public int Value { get; set; }
    //    public Node Parent { get; set; }
    //    public List<Node> Children { get; set; }

    //    public Node(int value, Node parent)
    //    {
    //        Value = value;
    //        Parent = parent;
    //        Children = new List<Node>();
    //    }


    //    public void PrintPretty(string indent, bool last)
    //    {
    //        Console.Write(indent);
    //        if (last)
    //        {
    //            Console.Write("\\-");
    //            indent += "  ";
    //        }
    //        else
    //        {
    //            Console.Write("|-");
    //            indent += "| ";
    //        }
    //        Console.WriteLine(Value);

    //        for (int i = 0; i < Children.Count; i++)
    //            Children[i].PrintPretty(indent, i == Children.Count - 1);
    //    }
    //}
}
