using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class DoublyLinkedList
    {
        Node head;
        Node tail;
        int size;

        public void createDoublyLinkedList(int nodeValue){
            Node node = new Node();
            node.value = nodeValue;
            node.next = null;
            node.prev = null;
            head = node;
            tail = node;
            size=1;
        }

        public void insertInDLL(int nodeValue, int location){
            
        }

    }
}