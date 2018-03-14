using System;

namespace BarnardosTest
{
    /// <summary>
    /// PD Linked List
    /// </summary>    
    public class PdLinkedList<T>
    {
        private Node<T> CurrentNode;
        private Node<T> HeadNode;
        private int NodesCount;

        // Constructor
        public PdLinkedList()
        {
            HeadNode = new Node<T>();
            CurrentNode = HeadNode;
        }

        // Add new node
        public void Add(T value)
        {
            var newNode = new Node<T>();
            newNode.Value = value;
            CurrentNode.NextNode = newNode;
            CurrentNode = newNode;
            NodesCount++;
        }

        // Indexer to get linked list values like an array
        public T this[int index]
        {
            get
            {
                if (index > NodesCount - 1)
                    throw new IndexOutOfRangeException();

                var currentNode = HeadNode.NextNode;
                var counter = 0;

                while (currentNode.NextNode != null)
                {
                    if (counter == index) break;

                    currentNode = currentNode.NextNode;
                    counter++;
                }

                return currentNode.Value;
            }
        }

    }

    /// <summary>
    /// Node class
    /// </summary>    
    class Node<T>
    {
        public T Value;
        public Node<T> NextNode;
    }

}
