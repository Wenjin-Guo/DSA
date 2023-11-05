using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class UseLinkedList
    {
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
    }
}