using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class LinkedListImplementation
    {
        class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        // LinkedList class represents the linked list and its operations
        class LinkedList
        {
            public Node head;

            // Constructor to initialize an empty linked list
            public LinkedList()
            {
                head = null;
            }
            public void AddNode(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            // Function to remove a node with given data from the list
            public void RemoveNode(int data)
            {
                if (head == null)
                {
                    return;
                }

                if (head.data == data)
                {
                    head = head.next;
                    return;
                }

                Node current = head;
                while (current.next != null)
                {
                    if (current.next.data == data)
                    {
                        current.next = current.next.next;
                        return;
                    }
                    current = current.next;
                }
            }

            // Function to display the elements of the list
            public void DisplayList()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write($"{current.data} >> ");
                    current = current.next;
                }
                Console.WriteLine("null");
            }
        }
        public static void ImplementLinkedList()
        {
            LinkedList list = new LinkedList();
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
           
            Console.WriteLine("Initial Linked List:");
            list.DisplayList();

            list.RemoveNode(3);
            Console.WriteLine("Linked List after removing node : ");
            list.DisplayList();
        }

    }

}