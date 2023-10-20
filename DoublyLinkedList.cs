using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class DoublyLinkedList
    {
        DoublyNode head;
        DoublyNode tail;
        int size;

        public void createDoublyLinkedList(int nodeValue){
            DoublyNode node = new DoublyNode();
            node.value = nodeValue;
            node.next = null;
            node.prev = null;
            size=1;
        }
    }
}