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
                head = nn;
                nn.prev =null;
                size++;
            }else if(location >= size-1){    // at the end
                Node tempNode = head;
                for(int i=0;i<size-1;i++){
                    tempNode=tempNode.next;
                }
                tempNode.next = nn;
                tail = nn;
                nn.prev = tempNode;
                nn.next = null;
                size++;
            }else{
                Node tempNode = head;
                for(int i=0; i<location-1;i++){
                    tempNode=tempNode.next;
                }
                tempNode.next = nn;
                nn.prev = tempNode;
                nn.next = tempNode.next.next;
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

    }
}