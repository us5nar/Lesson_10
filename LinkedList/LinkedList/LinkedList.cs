using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        public Node<T> Head { set; get; }
        public Node<T> Last { set; get; }
        public void Add(T NewElement)
        {
        }
        public void Incert(T NewElement, int count) { }
        public T Get(int count) { return Head; }
    }
}
