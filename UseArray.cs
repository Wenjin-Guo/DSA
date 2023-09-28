using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class UseArray
    {
        /* int[,] arr; 
        int[,] arr = new int[2,2];
        int[,] arr= {{1,2},{3,4}};
        for(int row=0;row<arr.GetLength(0);row++){
            for(int col=0; col<arr.GetLength(1);col++){
                Console.Write(arr[row,col]);
            }
        } */

        /* int[] arr = new int[5];
        int[] arr = {1, 2, 3, 4, 5};
        for(int row=0;row<arr.Length;row++){
            Console.Write(arr[row]);
        } */

        public static int[] findTopTwoScores(int[] array){
            /* Given an array, write a function to get first, second best scores from the array and return it in new array.
Array may contain duplicates. */
            //Example: myArray = {84,85,86,87,85,90,85,83,23,45,84,1,2,0}
            //return: firstSecond(myArray) // {90, 87}
            int firstScore = int.MinValue;
            int secondScore = int.MinValue;

            foreach(int i in array){
                if(i>firstScore){
                    secondScore = firstScore;
                    firstScore = i;
                }else if(i>secondScore && i<firstScore){
                    secondScore = i;
                }
            }
            return new int[]{firstScore,secondScore};
        }
        
        

        public static int findMissingNumberInArray(int[] arr){
            //Write Java function called findMissingNumberInArray that takes an integer array containing n-1 unique elements from a range of 1 to n, with one missing number, and returns the missing number.
            //myArray = {1,2,3,4,6}
            //findMissingNumberInArray(myArray, 6) // 5
            // Hint: Use the formula (n * (n + 1)) / 2 which  calculates the sum of the first n natural numbers.
            int n = arr.Length +1;
            int expectedSum = (n*(n+1))/2;
            int actualSum = 0;
    
            foreach(int i in arr){
                actualSum +=i;
            }
            Console.WriteLine("The missing number is " +(expectedSum-actualSum)+".");
            return expectedSum-actualSum;
        }   

        public static int[] removeDuplicates(int[] arr){
            //Write a function which takes integer array as a parameter and returns a new integer array with unique elements. (remove duplicates)
            // example: removeDuplicates({1, 1, 2, 2, 3, 4, 5})
            // output: [1, 2, 3, 4, 5]
            int[] duplicateNum = arr;
            int count = 0;
            for(int i=0;i<arr.Length;i++){
                for(int j=i+1;j<arr.Length;j++){
                    if(arr[i]==arr[j]){
                        duplicateNum[j]=int.MinValue;
                    }
                }
            }
            foreach(int i in duplicateNum){
                if(i!=int.MinValue){
                    count++;
                }
            }
            int[] sortedArray = new int[count];
            int indices = 0;
            foreach(int i in duplicateNum){
                if(i!=int.MinValue){
                    sortedArray[indices] = i;
                    indices++;
                }
            }
            return sortedArray;
        } 

        public int removeDuplicates(int[] nums){
            //Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length. Do not allocate extra space for another array; you must do this by modifying the input array in-place with O(1) extra memory.
            //Example: Input: nums = [1, 1, 2] 
            //output: Output: 2
            int count=0;
            for(int i=0;i<nums.Length;i++){
                for(int j=i+1;j<nums.Length;j++){
                    if(nums[i]!=nums[j]){
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
