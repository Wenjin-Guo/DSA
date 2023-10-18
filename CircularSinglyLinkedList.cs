using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class CircularSinglyLinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public Node createCSLL(int nodeValue){
            Node node = new Node();
            node.value = nodeValue;
            node.next = node;
            head = node;
            tail = node;
            size = 1;
            return head;
        }
    }
}