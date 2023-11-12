using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace DSA
{
    public class UseLinkedList
    {
        public ListNode head;
        public ListNode tail;
        public int size;
        public void deletDups(SinglyLinkedList sll){
            //Write a method to remove duplicates from an unsorted linked list.
            //linkedList = 1->2->1->3
            //deleteDups(linkedList)
            //Output
            //1->2->3

            Node tempNode1 = sll.head;
            int i=0;
            while(i<sll.size){
                int j=i+1;
                Node tempNode2 = sll.head;
                for(int k=0;k<j;k++){
                    tempNode2 = tempNode2.next;
                }
                while(j<sll.size){
                    if(tempNode1.value == tempNode2.value){
                        sll.deleteNode(j);
                        //sll.printSinglyLinkedList();
                        j--;
                    }
                    tempNode2 = tempNode2.next;
                    j++;
                }
                tempNode1 = tempNode1.next;
                i++;
            }
            sll.printSinglyLinkedList();
        }

        public Node partition(SinglyLinkedList ll, int x){
            Node dummy = new Node();
            dummy.next = ll.head;
            Node curr = ll.head;
            for(int i=0;i<ll.size;i++){
                if(curr.value<x ){ // in the middle
                    ll.deleteNode(i);
                    ll.insertInLinkedList(curr.value,0);
                }
                curr = curr.next;
            }
            return dummy.next;
        }

        public ListNode partition(ListNode head, int x){
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode curr = head;
            while(curr.next!=null){
                
                curr = curr.next;
            }

        }

        public void printLL(Node head){
            while (head != null)
            {
                Console.Write(head.value + " -> ");
                head = head.next;
            }
            Console.WriteLine("None");
        }

        public void findNthLast(SinglyLinkedList  sll, int location){
            Node tempNode = sll.head;
            int index = sll.size - location;
            for(int i=0; i<index;i++){
                tempNode = tempNode.next;
            }
            Console.WriteLine(tempNode.value);
        }

        public void createLinkedList(int nodeValue){
            //Node dummy = new Node();
            ListNode node = new ListNode(nodeValue);
            head = node;
            tail = node;
            size = 1;
            //return head;
        }

        public void add(int nodeValue){    //add at the end of list
            ListNode nn = new ListNode(nodeValue);
            nn.next = null;
            tail.next = nn;
            tail = nn;
            size++;
        }

        public ListNode SwapPairs(ListNode head) {
            //LeetCode 24. Swap Nodes in Pairs
            
            if(head==null || head.next==null){
                return head;
            }
            
            ListNode dummy = new ListNode(0);   //create a dummy node at the beginning
            dummy.next = head;
            ListNode curr = head;
            ListNode prev = dummy;
            while(curr!=null && curr.next!=null){
                ListNode nextPair = curr.next.next;
                ListNode sec = curr.next;

                //swap 1st and 2nd node in current pair
                prev.next = sec;
                sec.next = curr;
                curr.next = nextPair;

                //update the prev and curr in the next pair
                prev = curr;
                curr = nextPair;
            }
            return dummy.next;
        }

        public void printLL(ListNode head){
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine("None");
        }

    }
}