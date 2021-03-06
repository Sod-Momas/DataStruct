using System;

namespace DataStruct
{
    class LinkedList<T> : List<T>
    {
        Node<T> first;
        Node<T> last;
        int size;

        public void add(T value)
        {
            Node<T> tail = last;
            Node<T> newNode = new Node<T>(tail, value, null);
            last = newNode;
            if (tail == null)
            {
                first = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            ++size;
        }

        public void printAll()
        {
            Node<T> current = this.first;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.next;
            }
        }
        class Node<E>
        {
            E item;
            Node<E> prev;
            public Node<E> next { get; set; }

            public Node(Node<E> prev, E item, Node<E> next)
            {
                this.prev = prev;
                this.item = item;
                this.next = next;
            }

            public override string ToString()
            {
                return item == null ? "null" : item.ToString();
            }
        }

    }

}