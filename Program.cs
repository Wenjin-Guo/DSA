﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using DSA;
class Hello{
    static void Main(string[] args){
        
        /* int[] myArray = {84,85,86,87,85,90,85,83,23,45,84,1,2,0};    
        foreach(var item in UseArray.findTopTwoScores(myArray)){
            Console.Write(item + ", ");
        }; */

        /* ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Insert(0,9);
        arrayList.Add(4);
        foreach (var item in arrayList)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine(arrayList[2]);
        Console.WriteLine(arrayList.Count); */

       /*  int[] myArray = {1,2,3,4,6};
        DSA.UseArray.findMissingNumberInArray(myArray);

        Console.Write(3^1^1); */

        /* int[] arr = {1, 1, 2, 2, 3, 4, 5};
        int[] duplicatArray = DSA.UseArray.removeDuplicates(arr);
        foreach(int item in duplicatArray){
            Console.Write(item + ", ");
        } */

        /* SinglyLinkedList sll = new SinglyLinkedList();
        sll.createSinglyLinkedList(6);
        Console.Write("head: "+sll.head.value+" tail: "+sll.tail.value); */

        /* int[] prices = {7, 8, 5, 3, 6, 4,8,10,12,5};
        Console.WriteLine( DSA.UseArray.maxProfit(prices)); */

        int[] nums = {2,7,11,15};
        int target = 9;
        foreach(int i in DSA.UseArray.twoSum(nums,target)){
            Console.Write(i +", ");
        }
        
    }
        
}