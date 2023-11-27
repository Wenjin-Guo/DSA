using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class QueueLinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public QueueLinkedList(){
            Node dummy = new Node();
            Node node = new Node();
            node.next = null;
            node.prev = dummy;
            dummy.next = node;
            head=null;
            tail = null;
            size=1;
        }
    }
}