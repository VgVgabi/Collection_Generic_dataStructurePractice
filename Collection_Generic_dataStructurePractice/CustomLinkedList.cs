using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Generic_dataStructurePractice
{
    public class CustomLinkedList<T>
    {
        
        public Node<T> First { get; private set; }
        public Node<T> Current { get; private set; }
        public Node<T> Last { get; private set; }
        //
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Current == null)
            {
                First = newNode;
                Current = newNode;
            }
            else
            {
                Current.Next = newNode;
                newNode.Previous = Current;
                Current = newNode;
            }
            Last = newNode;
        }
        //
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        //
        public IEnumerable<T> GetEnumerableDESC()
        {
            Node<T> current = Last;
            while (current != null)
            {                
                yield return current.Value;
                current = current.Previous;
            }                            
        }
    }
}
