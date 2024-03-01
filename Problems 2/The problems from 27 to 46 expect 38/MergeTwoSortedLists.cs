using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_2.The_problems_from_27_to_46
{
    public class MergeTwoSortedLists
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
        }

        class mergeSortedLists
        {
            public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
            {
                LinkedList mergedList = new LinkedList();

                while (list1.head != null && list2.head != null)
                {
                    if (list1.head.data < list2.head.data)
                    {
                        mergedList.AddNode(list1.head.data);
                        list1.RemoveNode(list1.head.data);
                    }
                    else
                    {
                        mergedList.AddNode(list2.head.data);
                        list2.RemoveNode(list2.head.data);
                    }
                }

                while (list1.head != null)
                {
                    mergedList.AddNode(list1.head.data);
                    list1.RemoveNode(list1.head.data);
                }

                while (list2.head != null)
                {
                    mergedList.AddNode(list2.head.data);
                    list2.RemoveNode(list2.head.data);
                }

                return mergedList;
            }
        }
    }
}
