using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class TreeNode
    {
        public String data{get;set;}

        public List<TreeNode> children{get;set;}
        

        public TreeNode(String data){
            this.data = data;
            children = new List<TreeNode>();
        }

        public String print(int level){
            String ret;
            ret=new string(' ',level*3)+data+"\n";
            foreach(TreeNode a in children){
                ret+=a.print(level+1);
            }
            return ret;
        }

        public void PrintTree(TreeNode tree, String indent, bool last)
        {
            Console.WriteLine(indent + "+- " + tree.data);
            indent += last ? "   " : "|  ";

            for (int i = 0; i < tree.children.Count; i++)
            {
                PrintTree(tree.children[i], indent, i == tree.children.Count - 1);
            }
        }
    }
}