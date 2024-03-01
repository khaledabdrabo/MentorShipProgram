using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class DetectLoopInLinkedList
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

            public bool DetectLoop()
            {
                if (head == null || head.next == null)
                {
                    return false;
                }

                Node slowPointer = head;
                Node fastPointer = head;

                while (fastPointer != null && fastPointer.next != null)
                {
                    slowPointer = slowPointer.next;
                    fastPointer = fastPointer.next.next;

                    if (slowPointer == fastPointer)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
