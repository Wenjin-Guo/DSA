using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class CircularDoublyLinkedList
    {
        public Node head;
        public Node tail;
        public int size;

        public Node createCDLL(int nodeValue){
            Node node = new Node();
            node.value = nodeValue;
            node.next = node;
            node.prev = node;
            head = node;
            tail = node;
            size=1;
            return head;
        }

        public void insertInCDLL(int nodeValue, int location){
            Node nn = new Node();
            nn.value = nodeValue;
            if(head==null){
                createCDLL(nodeValue);
            }else if(location==0){                   //insert at the beginning
                nn.next = head;
                head = nn;
                nn.prev = tail;
                nn.next.prev = nn;
                nn.prev.next = nn;
                size++;
            }else if(location>=size){              //insert at the end
                nn.next = head;
                tail.next = nn;
                nn.prev = tail;
                tail = nn;
                nn.next.prev = nn;
                size++;
            }else{                                   //insert in the middle
                Node tempNode = head;
                for(int i=0;i<location-1;i++){
                    tempNode = tempNode.next;
                }
                Node nextNode = tempNode.next;
                nn.next = nextNode;
                tempNode.next = nn;
                nn.prev = tempNode;
                nn.next.prev = nn;
                size++;
            }
        }

        public void printCDLL(){
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

        public void reversePrintCDLL(){
            if(head!=null){
                Node tempNode =tail;
                for(int i=0;i<size;i++){
                    Console.Write(tempNode.value+" ");
                    tempNode = tempNode.prev;
                }
            }else{
                Console.WriteLine("The CDLL does not exist!");
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
    }
}