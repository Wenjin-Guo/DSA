using System;
using System.Collections.Generic;
using System.Linq;
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