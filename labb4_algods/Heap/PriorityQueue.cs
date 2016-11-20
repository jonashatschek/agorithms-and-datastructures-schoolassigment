using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgoDS_Labb3;

namespace Heap
{
    public class PriorityQueue<TKey, TValue> where TKey : IComparable<TKey>
    {

        //K står för key och är den datatyp som används för prioriteten i kön
        //V står för value och är datatypen för värdet i noden.

        MinHeap<PriorityQueueNode<TKey, TValue>> queue;


        public PriorityQueue(TValue T)
        {
            queue = new MinHeap<PriorityQueueNode<TKey, TValue>>();
        }

        /// <summary>
        /// Dequeue-metod, tar bort elementet med den lägsta siffermässiga prioriteten
        /// </summary>
        public void Dequeue()
        {
            queue.Remove(queue.First());
            
        }
        /// <summary>
        /// placerar en input längst bak i kön med bestämd prioritet
        /// </summary>
        /// <param name="item">ny input</param>
        /// <param name="order"></param>
        public void Enqueue(TValue item, TKey order)
        {
            PriorityQueueNode<TKey, TValue> node = new PriorityQueueNode<TKey, TValue>(item, order);
            queue.Add(node);
        }

        public TValue Peek()
        {
            PriorityQueueNode<TKey, TValue> firstElement = queue.First();
            return firstElement.Item; 
        }

        public override string ToString()
        {
            return queue.ToString();
        }
    }

    /// <summary>
    /// Typ som används för noderna i prioritetskön. En nod 
    /// innehåller både en prioritet samt ett generiskt värde.
    /// </summary>
    public class PriorityQueueNode<TKey, TValue> : IComparable<PriorityQueueNode<TKey, TValue>>
        where TKey : IComparable<TKey>
    {
        public TKey Priority { get; private set; }
        public TValue Item { get; private set; }

        public PriorityQueueNode(TValue item, TKey priority)
        {
            this.Priority = priority;
            this.Item = item;
        }

        public int CompareTo(PriorityQueueNode<TKey, TValue> other)
        {
            return Priority.CompareTo(other.Priority);
        }

        public override string ToString()
        {
            return Item.ToString() + " (" + Priority + ")";
        }
    }
}
