using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class RemoveNthNodeFromEnd
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

            public void RemoveHead()
            {
                if (head != null)
                {
                    head = head.next;
                }
            }

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

            public int GetLinkedListLength()
            {
                int length = 0;
                Node current = head;
                while (current != null)
                {
                    length++;
                    current = current.next;
                }
                return length;
            }
        }

        class RemovetheNodeFromEnd
        {
            public static LinkedList RemoveNthNode(LinkedList linkedList, int n)
            {
                int length = linkedList.GetLinkedListLength();

                if (n > length || n <= 0)
                {
                    return linkedList;
                }

                int positionToRemove = length - n + 1;

                if (positionToRemove == 1)
                {
                    linkedList.RemoveHead(); 
                }
                else
                {
                    Node currentNode = linkedList.head;
                    for (int i = 1; i < positionToRemove - 1; i++)
                    {
                        currentNode = currentNode.next;
                    }
                    linkedList.RemoveNode(currentNode.next.data);
                }

                return linkedList;
            }
        }
    }
}
