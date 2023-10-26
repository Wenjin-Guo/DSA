using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class DoublyLinkedList
    {
        public Node head;
        public Node tail;
        public int size;

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
            Node nn = new Node();
            nn.value = nodeValue;
            if(head == null){
                createDoublyLinkedList(nodeValue);
            }else if(location ==0){    //at the beginning of the list
                nn.next = head;
                head.prev = nn;
                head = nn;
                nn.prev =null;
                size++;
            }else if(location >= size){    // at the end
                tail.next = nn;
                nn.next = null;
                nn.prev = tail;
                tail = nn;
                size++;
            }else{                          //in the middle
                Node tempNode = head;
                for(int i=0; i<location-1;i++){
                    tempNode=tempNode.next;
                }
                Node nextNode = tempNode.next;
                tempNode.next = nn;
                nn.next = nextNode;
                nn.prev = tempNode;
                nn.next.prev = nn;
                size++;
            }
        }

        public void printDLL(){
            Node tempNode = head;
            for(int i=0; i<size;i++){
                Console.Write(tempNode.value+" ");
                tempNode=tempNode.next;
            }
            Console.Write("\n");
        }

        public void reversePrintDLL(){
            if(head!=null){
                Node tempNode =tail;
                for(int i=0;i<size;i++){
                    Console.Write(tempNode.value+" ");
                    tempNode = tempNode.prev;
                }
            }
            Console.WriteLine();
        }

        public int getValue(int location){
            Node tempNode = head;
            if(location>=size){
                return tail.value;
            }else{
                for(int i=0; i<location;i++){
                    tempNode=tempNode.next;
                }
            }
            return tempNode.value;
        }

        public Node getNode(int location){
            Node tempNode = head;
            if(location>=size){
                return tail;
            }else{
                for(int i=0; i<location;i++){
                    tempNode=tempNode.next;
                }
            }
            return tempNode;
        }
    }
}