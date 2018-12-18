using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
