namespace DataStructer;

class Node<T>{

     public T? value {get; set;}
     public Node<T>? next {get; set;} 

}

class TreeNode<T>{
     public T? value {get; set;}
     public TreeNode<T>? Left { get; set; }
     public TreeNode<T>? Right { get; set; }
}