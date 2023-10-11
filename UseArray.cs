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
        int[,] arr = new int[2,2]; //2d integer array with 2 rows and 2 columns
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

        public static int removeDuplicatesSecond(int[] nums){
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

        public static int maxProfit(int[] prices){
            //You are given an array prices where prices[i] is the price of a given stock on the ith day. You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock. Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
            //Example: Input: prices = [7, 1, 5, 3, 6, 4] 
            //Output: Output: 5 
            //explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            int length = prices.Length;
            List<List<int>> priceDayPair = new List<List<int>>();
            for(int i=0;i<length;i++){
                for(int j=i+1;j<length;j++){
                    if(prices[j]>prices[i]){
                        priceDayPair.Add(new List<int>{prices[j]-prices[i],j-i});
                    }
                }
            }
            int maxP = priceDayPair[0][0];;
            for(int i=0;i<priceDayPair.Count-1;i++){
                if(priceDayPair[i+1][0]>maxP){
                    maxP = priceDayPair[i+1][0];
                }
            }
            return maxP;
            /* int minPrice = int.MaxValue;
            int maxProfit = 0;
            foreach(int price in prices){
                if(price<minPrice){
                    minPrice = price;
                }else if(price-minPrice>maxProfit){
                    maxProfit = price - minPrice;
                }
            }
            return maxProfit; */
        }

        public static int[] twoSum(int[] nums, int target){
            //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. You may assume that each input would have exactly one solution, and you may not use the same element twice.
            //Example: Input: nums = [2,7,11,15], target = 9
            //output: [0,1]    Because nums[0] + nums[1] == 9, we return [0, 1]
            //Input: nums = [3,2,4], target = 6
            //Output: [1,2]
            int size = nums.Length;
            for(int i=0;i<size;i++){
                for(int j=i+1;j<size;j++){
                    if(nums[i]+nums[j]==target){
                        return new int[]{i,j};
                    }
                }
            }
            return new int[2];
        }

        public static bool permutation(int[] array1, int[] array2){
            //Your are given two integer arrays. Write a program to check if they are permutation of each other.
            //Example: int[] array1 = {1,2,3,4,5}; int[] array2 = {5,1,2,3,4};
            //permutation(array1, array2) // true
            /* bool permutation = false;
            if(array1.Length!=array2.Length){
                return false;
            }
            for(int i=0;i<array1.Length;i++){
                permutation = false;
                for(int j=0;j<array2.Length;j++){
                    if(array1[i]==array2[j]){
                        permutation = true;
                    }
                }
                if(permutation == false){
                    return permutation;
                }
            }
            return true; */
            if(array1.Length!=array2.Length){
                return false;
            }
            int sum1=0, sum2=0;
            int mul1 = 1, mul2 = 1;
            for(int i=0;i<array1.Length;i++){
                sum1+=array1[i];
                sum2+=array2[i];
                mul1*=array1[i];
                mul2*=array2[i];
            }
            
            if(mul1==mul2 && sum1==sum2){
                return true;
            }else{
                return false;
            }

        }

        public static void rotateMatrix(int[][] matrix){
            //Given an image represented by an NxN matrix write a method to rotate the image by 90 degrees. 
            //public boolean rotateMatrix(int[][] matrix) { if (matrix.length == 0 || matrix.length != matrix[0].length) 
            //return false; int n = matrix.length; for (int layer = 0; layer < n/2; layer++) { int first = layer; int last = n - 1 - layer; for (int i=first; i
            //leetcode48
            int size = matrix.Length;
            for(int i=0;i<size;i++){
                for(int j=0;j<size;j++){
                    matrix[i][j]=matrix[i][j]^matrix[j][i];
                    matrix[j][i]=matrix[i][j]^matrix[j][i];
                    matrix[i][j]=matrix[i][j]^matrix[j][i];
                }
            }
            /* for(int i=0;i<size/2;i++){
                int[] temp = matrix[i];
                matrix[i] = matrix[size-1-i];
                matrix[size-1-i] = temp;
            } */
        }


    }
}
