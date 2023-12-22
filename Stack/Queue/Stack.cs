using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;

namespace DSA
{
    public class Stack  //last in first out
    {
        int[] arr;
        int topOfStack;

        public Stack(int size){
            this.arr = new int[size];
            this.topOfStack = -1;
            Console.WriteLine("The Stack is created with size of: "+ size);
        }

        public bool isEmpty(){
            if(topOfStack==-1){
                return true;
            }else{
                return false;
            }
        }

        public bool isFull(){
            if(topOfStack==arr.Length-1){
                Console.WriteLine("The stack is full.");
                return true;
            }else{
                return false;
            }
        }

        //Push
        public void push(int value){
            if(isFull()){}
            else{
                arr[topOfStack+1] = value;
                topOfStack++;
                Console.WriteLine("The value is successfully inserted");
            }
        }

        //Pop
        public void pop(){
            if(isEmpty()){
                Console.WriteLine("The stack is empty");
            }else{
                int topStack = arr[topOfStack];
                topOfStack--;
            }
        }

        //Peek
        public int? peek(){
            if(isEmpty()){
                Console.WriteLine("The stack is empty!");
                return null;
            }else{
                return arr[topOfStack];
            }
        }

        //Delete
        public void deleteStack(){
            arr=null;
            Console.WriteLine("The stack has successfully deleted!");
        }
    }
}