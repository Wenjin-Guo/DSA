using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class Queue
    {
        int[] arr;
        int topOfQueue;
        int beginingOfQueue;

        public Queue(int size){
            this.arr = new int[size];
            this.topOfQueue = -1;
            this.beginingOfQueue = -1;
            Console.WriteLine("This new Queue has been created with size of "+size);
        }

        public bool isFull(){
            if(topOfQueue==arr.Length-1){
                return true;
            }else{
                return false;
            }
        }

        public bool isEmpty(){
            if(beginingOfQueue==-1||beginingOfQueue == arr.Length){
                return true;
            }else{
                return false;
            }
        }

        public void enQueue(int value){
            if(isFull()){
                Console.WriteLine("The queue is full");
            }else if(isEmpty()){
                beginingOfQueue=0;
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Successfully inserted "+value+ " in the queue");
            }else{
                topOfQueue++;
                arr[topOfQueue] = value;
                Console.WriteLine("Successfully inserted "+value+ " in the queue");
            }
        }

        public void deQueue(){
            if(isEmpty()){
                Console.WriteLine("The Queue is empty");
            }else{
                int result;
                
            }
        }
    }
}