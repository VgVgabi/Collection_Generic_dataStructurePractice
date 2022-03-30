using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_dataStructurePractice
{
    public class Node<T>
    {
        public Node<T> Previous;
        public Node<T> Next;
        public T Value;
        public Node() : this(default(T)) { }
        public Node(T value)
        {
            Value = value;
        }
        //
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
