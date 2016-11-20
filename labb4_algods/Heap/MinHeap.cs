using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoDS_Labb3
{
    public class MinHeap<T> where T : IComparable<T>
    {
        int count = 0;
        T[] heap;

        /// <summary>
        /// gör det möjligt att föra in siffrorna i heapen i strängformat
        /// </summary>
        /// <returns>strängen med heapens värden</returns>
        public override string ToString()
        {

            string s = "";
            bool f = true;

            for (int i = 0; i < count; i++) //itererar genom heapen och dess värden
            {
                if (f)
                {
                    s += heap[i];
                    f = false;
                }
                else
                {
                    s += ", " + heap[i];
                }
            }
            return s;
        }
        /// <summary>
        /// konstruktor till klassen MinHeap
        /// </summary>
        public MinHeap()
        {
            heap = new T[100]; //skapar en heap med 100 platser
        }

        /// <summary>
        /// lägger till ett värde på en plats i heapen
        /// </summary>
        /// <param name="item">det införda värdet</param>
        public void Add(T item)
        {
            heap[count] = item;
            count = count + 1;
            MinHeapify(); //anropar metoden MinHeapify för att ändra om ordningen innan output
        }

        /// <summary>
        /// sorterar heapen enligt de regler som ska appliceras
        /// </summary>
        public void MinHeapify()
        {
            int i = count - 1;

            while (i > 0 && heap[i].CompareTo(heap[(i - 1) / 2]) < 0)
            {
                T temporary = heap[i];
                heap[i] = heap[(i-1)/2];
                heap[(i-1)/2] = temporary;
                i = (i - 1) / 2;
            }

        }

        /// <summary>
        /// hittar ett index i en plats i en array och returnerar det
        /// </summary>
        /// <param name="heap">inskickad heap</param>
        /// <param name="item">eftersökt index i heap</param>
        /// <returns>det eftersökta indexet</returns>
        public int FindIndex(T[] heap, T item)
        {
            int index = 0;
            for (int i = 0; i < count; i++) //
            {
                if (heap[i].CompareTo(item) == 0) //jämför ett index i heapen med det inskickade värdet
                {
                    index = i;
                }
            }
            return index;
        }

        public T[] Items
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// tar bort ett element i heapen
        /// </summary>
        /// <param name="item">värde i element som ska tas bort</param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            int index = FindIndex(heap, item);

            if (heap[index].CompareTo(item) != 0) 
            {
                return false;
            }

            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (index < 0) //om index < 0, returneras false
            {
                return false;
            }

            count = count - 1;
            heap[index] = heap[count];

            while (left < count && (Larger(heap[index], heap[left]) || Larger(heap[index], heap[right])))
            {
                if (Larger(heap[right], heap[left]))
                {
                    Swap(heap, left, index); //anropar swapmetoden och flyttar index till vänster
                    index = left;
                }
                else
                {
                    Swap(heap, right, index); //anropar swap och flyttar index till höger
                    index = right;
                } 
            }

            MinHeapify();
            return true;
        }
        /// <summary>
        /// metod som byter elemntplats på två indexplatser
        /// </summary>
        /// <param name="heap">input heap</param>
        /// <param name="firstIndex">första index</param>
        /// <param name="secondIndex">andra index</param>
        /// <returns>en swappad variant av heap</returns>
        static T[] Swap(T[] heap, int firstIndex, int secondIndex)
        {
            T temporary = heap[firstIndex];
            heap[firstIndex] = heap[secondIndex];
            heap[secondIndex] = temporary;
            return heap;
        }

        /// <summary>
        /// klass som hjälper till att hämta index[0] ur heapen och skicka till PriorityQueue
        /// </summary>
        /// <returns>heapens index[0]</returns>
        public T First()
        {
            return heap[0];
        }

        /// <summary>
        /// Metod som jämför om ett objekt är större än ett annat objekt.
        /// </summary>
        private bool Larger(IComparable<T> first, T second)
        {
            return first.CompareTo(second) > 0;
        }
    }
}
