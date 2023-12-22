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
            if(head==null){
                Console.WriteLine("The DLL does not exist!");
            }else{
                Node tempNode = head;
                for(int i=0; i<size;i++){
                    Console.Write(tempNode.value+" ");
                    tempNode=tempNode.next;
                }
                Console.Write("\n");
            }
        }

        public void reversePrintDLL(){
            if(head!=null){
                Node tempNode =tail;
                for(int i=0;i<size;i++){
                    Console.Write(tempNode.value+" ");
                    tempNode = tempNode.prev;
                }
            }else{
                Console.WriteLine("The DLL does not exist!");
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

        public bool searchNode(int nodeValue){
            if(head!=null){
                Node tempNode = head;
                for(int i=0;i<size;i++){
                    if(tempNode.value == nodeValue){
                        Console.WriteLine("The Node is found at index: "+i);
                        return true;
                    }
                    tempNode = tempNode.next;
                }
            }
            Console.WriteLine("The Node is NOT found");
            return false;
        }

        public void deleteNode(int location){     //use index
            if(head==null){
                Console.WriteLine("The DLL is not exist!");
                return;              /////////need to work on when size=1
            }else if(location ==0){             //delete the first node
                if(size==1){
                    head=null;
                    tail=null;
                    size--;
                }else{
                    Node tempNode = head;
                    head = tempNode.next;
                    head.prev = null;
                    size--;
                };
            }else if(location>=size-1){        //delete the last node
                if(size==1){
                    head.next=null;
                    head.prev=null;
                    head=tail=null;
                    size--;
                }else{
                    Node tempNode = tail.prev;
                    tempNode.next = null;
                    tail = tempNode;
                    size--;
                }
            }else{                              //delete in the middle
                Node tempNode = head;
                for(int i=0;i<location-1;i++){
                    tempNode = tempNode.next;
                }
                tempNode.next = tempNode.next.next;
                tempNode.next.prev = tempNode;
                size--;
            }
        }

        public void deleteDLL(){
            if(head==null){
                Console.WriteLine("The DLL does not exist!");
            }else{
                Node tempNode = head.next;
                for(int i=0; i<size-1;i++){
                    tempNode.prev = null;
                    tempNode = tempNode.next;
                }
                size=0;
                head = null;
                tail = null;
            }

        }
    }
}