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

        public void insertInCSLL(int nodeValue, int location){
            Node nn = new Node();
            nn.value = nodeValue;
            if(head == null){
                createCSLL(nodeValue);
                return;
            }
            else if(location == 0){ // beginning of the node
                nn.next = head;
                head = nn;
                tail.next = nn;
                size++;
            }else if(location >= size){  // insert at end of the node
                tail.next = nn;
                tail = nn;
                nn.next = head;
                size++;
            }else{                      // insert at location
                Node tempNode = head;
                int index = 0;
                while(index < location-1){
                    tempNode = tempNode.next;
                    index++;
                }
                Node nextNode = tempNode.next;
                tempNode.next = nn; 
                nn.next = nextNode;
                size++;
            }
        }

        public void printCSLL(){
            Node tempNode = head;
            for(int i=0; i<size;i++){
                Console.Write(tempNode.value+" ");
                tempNode=tempNode.next;
            }
            Console.Write("\n");
        }
    }
}