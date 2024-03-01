using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problems_2.The_problems_from_27_to_46
{
    public class SortLinkedList
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

        class LinkedList
        {
            public Node head;

            public LinkedList()
            {
                head = null;
            }

            public void AddNode(int data)
            {
                Node node = new Node(data);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }

            public void DisplayList()
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write($"{current.data} -> ");
                    current = current.next;
                }
                Console.WriteLine("null");
            }
        }
        class sortLinkedList
        {

            public static LinkedList SortedLinkedList(LinkedList linkedList)
            {
                if (linkedList == null || linkedList.head == null)
                {
                    return linkedList;
                }

                Node sortedList = linkedList.head;

                for (Node node = sortedList; node != null; node = node.next)
                {
                    for (Node nextNode = node.next; nextNode != null; nextNode = nextNode.next)
                    {
                        if (node.data > nextNode.data)
                        {
                            int temp = node.data;
                            node.data = nextNode.data;
                            nextNode.data = temp;
                        }
                    }
                }
                return linkedList;
            }
        }
    }

}

