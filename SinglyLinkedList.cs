using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class SinglyLinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public Node createSinglyLinkedList(int nodeValue){
            head = new Node();
            Node node = new Node();
            node.next = null;
            node.value = 5;
            head = node;
            tail = node;
            size = 1;
            return head;
        }
    }
}