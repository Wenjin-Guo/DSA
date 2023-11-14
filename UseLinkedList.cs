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

        public SinglyLinkedList partition(SinglyLinkedList ll, int x){
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
            return ll;
        }

        public ListNode partition(ListNode head, int x){
            // Create dummy nodes to hold nodes less than x and nodes greater than or equal to x
            ListNode beforeDummy = new ListNode(0);
            ListNode afterDummy = new ListNode(0);

            // Create pointers for the two partitions and initialize them to the dummy nodes
            ListNode before = beforeDummy;
            ListNode after = afterDummy;

            // Create a pointer to traverse the original list, starting from the head
            ListNode current = head;

            // Traverse the original list
            while (current != null)
            {
                // Check if the current node's value is less than x
                if (current.val < x)
                {
                    // Append the current node to the "before" partition
                    before.next = current;
                    
                    // Move the "before" pointer to the newly added node
                    before = before.next;
                }
                else
                {
                    // Append the current node to the "after" partition
                    after.next = current;

                    // Move the "after" pointer to the newly added node
                    after = after.next;
                }

                // Move to the next node in the original list
                current = current.next;
            }

            // Connect the two partitions by setting the next of the "before" pointer to the head of the "after" partition
            before.next = afterDummy.next;

            // Set the next of the "after" pointer to null to terminate the partitioned list
            after.next = null;

            // Return the head of the partitioned list (excluding the dummy node)
            return beforeDummy.next;
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