namespace DataStructer;




public class BinaryTree{

      TreeNode<int>? treeNode;

      public BinaryTree(){}

      public BinaryTree(int value){
        treeNode = new TreeNode<int>(){value=value, Left=null, Right=null};
      }

      //Add-----------------------------------------------------------------------------
      public void Add(int value){
        
        if(treeNode==null){
            treeNode = new TreeNode<int>(){value=value, Left=null, Right=null};
            return;
        }
        Add(treeNode, value);

      }

     void Add(TreeNode<int> traker, int value){
        if(value < traker!.value && traker!.Left!=null){
            Add(traker.Left, value);
            return;
        }

        if(value > traker!.value && traker!.Right!=null){
            Add(traker.Right, value);
            return;
        }

        if(value < traker!.value && traker.Left==null){
            traker.Left = new TreeNode<int>(){value=value, Left=null, Right=null};
            return;
        }

        if(value > traker!.value && traker.Right==null){
            traker.Right = new TreeNode<int>(){value=value, Left=null, Right=null};
            return;
        }
     } 

     //Remove------------------------------------------------------------------------
     TreeNode<int>? RegenrateTreePart(TreeNode<int> PartTree){

         TreeNode<int>? RightPartTree = PartTree.Right;
         TreeNode<int>? LeftPartTree = PartTree.Left;
         TreeNode<int> Root = PartTree;

         
         if(RightPartTree!=null){
             
             TreeNode<int>? LeftTraker = RightPartTree;
             while(LeftTraker.Left != null){
                LeftTraker = LeftTraker.Left;
             } 

             Root.Left = null;
             Root.Right = null;

             if(LeftPartTree != null){
                LeftTraker.Left = LeftPartTree;
             }

             return RightPartTree;
         }

         if(LeftPartTree != null)
           return LeftPartTree;

         return null;
     }

     void Delete(TreeNode<int> traker, int value){ 
         
         TreeNode<int> preTraker = traker;

         while(preTraker.value != value){

                if(preTraker.Left!=null && preTraker.Left.value == value ||
                   preTraker.Right!=null && preTraker.Right.value == value){
                    break;
                }

                if(preTraker.value < value && preTraker.Right != null){
                    preTraker = preTraker.Right;
                }else if(preTraker.value > value && preTraker.Left != null){
                    preTraker = preTraker.Left;
                }
         }

         if(preTraker.Left!=null && preTraker.value > value){
            preTraker.Left = RegenrateTreePart(preTraker.Left);
         }

         if(preTraker.Right!=null && preTraker.value < value){
            preTraker.Right = RegenrateTreePart(preTraker.Right);
         }
         
     }

     public void Delete(int value){
         Delete(treeNode!, value);
     }


     //Display-----------------------------------------------------------------------
     void Display(TreeNode<int> Pretracker, string target){
         
        if(Pretracker == null){
            return;
        } 

        if(Pretracker.Left != null){
            Display(Pretracker.Left, "Left");
        }

        if(target=="Root"){
           System.Console.WriteLine();  
           System.Console.WriteLine($"Root : {Pretracker.value}");
        }else{
            System.Console.Write($"{Pretracker.value} ");
        }

        if(Pretracker.Right != null){
            Display(Pretracker.Right, "Right");
        }
 
        return;
      }

      void DisplayLevels(TreeNode<int> treeNode){

        queue<TreeNode<int>> trakerQueue = new queue<TreeNode<int>>();
        trakerQueue.EnQueue(treeNode);

        while(!trakerQueue.isEmpty()){
        
            TreeNode<int> traker = trakerQueue.DeQueue().value!;

            if(traker.Left != null){
                trakerQueue.EnQueue(traker.Left);
            }

            if(traker.Right != null){
                trakerQueue.EnQueue(traker.Right);
            }

            System.Console.WriteLine($"{traker.value} ");    
        }

      }

      public void Display(){
         if(treeNode != null) {
            Display(treeNode, "Root");
            System.Console.WriteLine();
         }
         else{
            throw new Exception("Tree is null");
         }
         
      }

      public void DisplayLevels(){
        
        if(treeNode!=null){
            DisplayLevels(treeNode);
        }
        else{
            throw new Exception("Tree is null");
        }


      }

}