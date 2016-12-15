using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        public T Data { set; get; }
        public Node<T> NextNode { set; get; }
    }
}
