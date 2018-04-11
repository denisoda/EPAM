using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    public class Queue <T> : IEnumerable
    {
        private List<T> queue;

        public Queue()
        {
            queue = new List<T>();
        }

        public void Enqueue(T value)
        {
            queue.Add(value);
        }

        /// <summary>
        /// Dequeue the element
        /// </summary>
        public void Dequeue()
        {
            if(queue.Count > 0)
                queue.Remove(queue.First());
            else
            {
                throw new ArgumentOutOfRangeException("There is no any element to remove");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return queue.GetEnumerator();
        }
    }
}
