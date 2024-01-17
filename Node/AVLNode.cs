using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class AVLNode
    {
        public int value{get;set;}
        public int height{get;set;}
        public AVLTree left{get;set;}
        public AVLTree right{get;set;}
    }
}