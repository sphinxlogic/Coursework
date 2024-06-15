using System;
using System.Collections.Generic;
using System.Text;


namespace DateLinkedList
{
    public class LinkedListElement<T>
    {
        public T Data;
        public LinkedListElement<T> Prev;
        public LinkedListElement<T> Next;

        public LinkedListElement(T Data)
        {
            this.Data = Data;
        }
    }

    public class MyLinkedList<T>
    {

        public LinkedListElement<T> Head;
        public LinkedListElement<T> Tail;

        public MyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void Add(T element)
        {
            LinkedListElement<T> Listelement = new LinkedListElement<T>(element);
            if (Head == null)
            {
                Head = Listelement;
            }
            else
            {
                Listelement.Prev = Tail;
                Tail.Next = Listelement;
            }
            Tail = Listelement;
        }

        public LinkedListElement<T> Next(LinkedListElement<T> element)
        {
            if (element == null)
                throw new Exception("LinkedListElement<T> null is not a valid argument");
            return element.Next;
        }

        public LinkedListElement<T> Prev(LinkedListElement<T> element)
        {
            if (element == null)
                throw new Exception("LinkedListElement<T> null is not a valid argument");
            return element.Prev;
        }

        public void Remove(LinkedListElement<T> element)
        {
            if (element == null)
                throw new Exception("LinkedListElement<T> null is not a valid argument");

            if (element == Head)
                Head = element.Next;
            if (element == Tail)
                Tail = element.Prev;

            if (element.Prev != null)
            {
                LinkedListElement<T> prev = element.Prev;
                prev.Next = element.Next;
            }
            if (element.Next != null)
            {
                LinkedListElement<T> next = element.Next;
                next.Prev = element.Prev;
            }
        }

        public LinkedListElement<T> Find(T needle)
        {
            return Find(needle, Head);
        }

        public LinkedListElement<T> Find(T needle, LinkedListElement<T> start)
        {
            LinkedListElement<T> iterator = start;
            while (iterator != null)
            {
                if (iterator.Data.Equals(needle)) return iterator;
                iterator = iterator.Next;
            }
            return null;
        }

    }

}
