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

        public void isertInLinkedList(int nodeValue, int location){
            Node nn = new Node();
            nn.value = nodeValue;
            if(head == null){
                createSinglyLinkedList(nodeValue);
                return;
            }
            else if(location == 0){ // beginning of the node
                nn.next = head;
                head = nn;
            }else if(location >= size){  // insert at end of the node
                nn.next = null;
                tail.next = nn;
                tail = nn;
            }else{                      // insert at location
                Node tempNode = head;
                int index = 0;
                while(index < location-1){
                    tempNode = tempNode.next;
                    index++;
                }
                Node nextNode = tempNode.next;
            }
        }


    }
}