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
            Node node = new Node();
            node.next = null;
            node.value = nodeValue;

            head = node;
            tail = node;
            size = 1;
            return head;
        }

        public void add(int nodeValue){
            Node nn = new Node();
            nn.value = nodeValue;
            nn.next = null;
            tail.next = nn;
            tail = nn;
            size++;
        }

        public void insertInLinkedList(int nodeValue, int location){
            Node nn = new Node();
            nn.value = nodeValue;
            if(head == null){
                createSinglyLinkedList(nodeValue);
                return;
            }
            else if(location == 0){ // beginning of the node
                nn.next = head;
                head = nn;
                size++;
            }else if(location >= size){  // insert at end of the node
                nn.next = null;
                tail.next = nn;
                tail = nn;
                size++;
            }else{                      // insert at location
                Node tempNode = head;
                int index = 0;
                while(index < location){
                    tempNode = tempNode.next;
                    index++;
                }
                Node nextNode = tempNode.next;
                tempNode.next = nn; 
                nn.next = nextNode;
                size++;
            }
        }

        public void printSinglyLinkedList(){
            Node tempNode = head;
            while(tempNode != null){
                Console.Write(tempNode.value+" ");
                tempNode=tempNode.next;
            }
        }
    }
}