using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7
{
    public class LinkedList<T>
    {
        public Node<T> first = null;
        public Node<T> last = null;
        public int Count { private set; get; } = 0;

        public void Add(Node<T> node)
        {
            // Get the first element
            var head = first;
            // If it's null, set the first and the last elements
            if (head == null)
            {
                first = node;
                last = node;
            }
            // If it's not a null, i.e. linked list has at least one element in it
            else
            {
                // While current element has a pointer to the next element we iterate through them
                while (head.Next != null)
                {
                    head = head.Next;
                }
                // And then when we hit the last element which
                head.Next = node;
                last = node;
            }
            this.Count++;
        }

        /// <summary>
        /// Removes the last element of the linked list
        /// </summary>
        public void Remove()
        {
            var head = this.first;
            // If we have at least one element
            if (head != null)
            {
                // If that element is the only one in the list
                if (head.Next == null)
                {
                    this.first = null;
                    this.last = null;
                }
                // Else we have more than one element in the list
                else
                {
                    // While next element is not last we move head
                    while (head.Next != last)
                    {
                        head = head.Next;
                    }
                    // At this point we have an element before the last one
                    this.last = null;
                    head.Next = null;
                    this.last = head;
                }
                this.Count--;
            }
        }

        public bool Any()
        {
            return this.Count == 0;
        }

        // Ideally, should be done with the help of enumerator at some point
        public Node<T>[] ToArray()
        {
            Node<T>[] result = new Node<T>[this.Count];
            int counter = 0;
            var head = this.first;
            while (head != null)
            {
                result[counter] = head;
                counter++;
                head = head.Next;
            }
            return result;
        }

        public Node<T> GetByIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Specified index is out of range for this linked list");
            }
            else
            {
                int counter = 0;
                var head = this.first;
                while (head != null)
                {
                    if (counter == index)
                    {
                        return head;
                    }
                    counter++;
                    head = head.Next;
                }
                // Alibi statement
                return null;
            }
        }

        public void RemoveByIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Specified index is out of range for this linked list");
            }
            else
            {
                // Deleting first element
                if (index == 0)
                {
                    var newFirst = first.Next;
                    this.first = newFirst;
                }
                // Deleting last element
                else if (index == this.Count - 1)
                {
                    this.Remove();
                }
                // Deleting any other element
                else
                {
                    int counter = 0;
                    var head = this.first;
                    var previous = this.first;
                    while (head != null)
                    {
                        if (counter == index)
                        {
                            previous.Next = head.Next;
                            head = null;
                            break;
                        }
                        counter++;
                        previous = head;
                        head = head.Next;
                    }
                }
                this.Count--;
            }
        }
    }
}
