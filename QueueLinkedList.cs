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
            Node node = new Node();
            node.next = null;
            node.prev = null;
            head=null;
            tail = null;
            size=0;
        }

        public bool isEmpty(){
            if(head == null){
                return false;
            }else{
                return true;
            }
        }

        public void enQueue(int value){
            Node nn = new Node();
            nn.value = value;
            if(size==0){
                head = nn;
                tail = nn;
                nn.next=null;
                nn.prev=null;
                size++;
            }else{
                tail.next = nn;
                nn.prev = tail;
                tail = nn;
                nn.next = head;
                head.prev = tail;
                size++;
            }
        }

        public void printQLL(){
            if(head==null){
                Console.WriteLine("The CDLL does not exist!");
            }else{
                Node tempNode = head;
                for(int i=0; i<size;i++){
                    Console.Write(tempNode.value+" ");
                    tempNode=tempNode.next;
                }
                Console.Write("\n");
            }
        }
    }
}