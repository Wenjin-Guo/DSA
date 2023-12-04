using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DSA
{
    public class StackLinkedList
    {
        //LIFO(last in first out)
        SinglyLinkedList ll;

        public StackLinkedList(){
            ll = new SinglyLinkedList();
        }

        public void push(int value){
            ll.insertInLinkedList(value,0);
            Console.WriteLine("Insert "+value+" in the Linked List.");
        }

        public void pop(){
            if(isEmpty()){
                Console.WriteLine("The stack is empty!");
            }else{
                ll.deleteNode(0);
            }
            
        }

        public void peek(){
            if(isEmpty()){
                Console.WriteLine("The stack is empty!");
            }else{
                Console.WriteLine("The top element is "+ ll.head.value);
            }
        }

        public bool isEmpty(){
            if(ll.head==null){
                return true;
            }else{
                return false;
            }
        }

        public void deleteStack(){
            ll.deleteSinglyLinkedList();
        }
    }
}