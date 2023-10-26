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

        public void createSinglyLinkedList(int nodeValue){
            Node node = new Node();
            node.next = null;
            node.value = nodeValue;

            head = node;
            tail = node;
            size = 1;
            //return head;
        }

        public void add(int nodeValue){
            Node nn = new Node();
            nn.value = nodeValue;
            nn.next = null;
            tail.next = nn;
            tail = nn;
            size++;
        }

        public void addBeginning(int nodeValue){
            Node nn = new Node();
            nn.value = nodeValue;
            nn.next = head;
            head = nn;
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
                tempNode.next = nn; 
                nn.next = nextNode;
            }
            size++;
        }

        public void printSinglyLinkedList(){
            Node tempNode = head;
            while(tempNode != null){
                Console.Write(tempNode.value+" ");
                tempNode=tempNode.next;
            }
            Console.Write("\n");
        }

        public void deleteNode(int location){
            if(head==null){
                Console.WriteLine("The Linked List does not exist!");
            }else if(location==0){ //delete the first node
                head = head.next;
                size--;
                if(size==0){
                    tail=null;
                }
            }else if(location>=size-1){  //delete the last node
                Node tempNode = head;
                for(int i=0;i<size-2;i++){
                    tempNode = tempNode.next;
                }
                tempNode.next = null;
                tail = tempNode;
                size--;
            }else{                    //in the middle 
                Node tempNode = head;
                int index =0;
                while(index<location-1){
                    tempNode = tempNode.next;
                    index++;
                }
                tempNode.next =tempNode.next.next;
                size--;
            }
        }

        public void deleteSinglyLinkedList(){
            if(head==null){
                Console.WriteLine("The SLL does not exist!");
            }else{
                head =null;
                tail=null;
            }
        }
    }
}