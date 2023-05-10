using System.Collections;

namespace DataStructer;



public class linkedList<T>{
     
     Node<T>? nodes;



    public linkedList(params T[] values){

        Node<T> Head = new Node<T>(){value=values[0], next=null};

        for(int i=1; i<values.Length; i++){

            Node<T> traker = Head;

            while(traker.next != null){
                traker = traker.next;
            }
            traker.next = new Node<T>(){value=values[i], next=null};

        }

        nodes = Head;
    }

    public void Insert(T val){

         Node<T> traker = nodes!;
         while(traker.next != null){
            traker=traker.next;
         }
         traker.next = new Node<T>(){value=val, next=null};

    }

    public void deleteFirst(){
        
        nodes = nodes?.next!;

    }
    public void deleteLast(){
        Node<T> preTraker = nodes!;
        Node<T> traker = nodes?.next!;


        while(traker.next != null){
            preTraker = preTraker.next!;
            traker = traker.next;
        }

        preTraker.next = null;
    }

    public void display(){
        Node<T> traker = new Node<T>();

        traker = nodes!;
        while(traker != null){
            System.Console.WriteLine(traker.value);

            traker = traker.next!;
        }
    }

   

 
}


/*
class Node{

    public int variable{get; set;}
    public Node? NextNode{get; set;}

    public static Node CreateList(params int[] variables){

        Node Head = new Node(){variable=variables[0], NextNode=null};

        for(int i=1; i<variables.Length; i++){
            Node tracker = Head;

            while(tracker.NextNode!=null) tracker = tracker.NextNode;

            tracker.NextNode = new Node(){variable=variables[i], NextNode=null};
        }

        return Head;

    }

    public static Node deleteNode(Node List, int value){
        Node? traker = List;
        Node? sekTracker = List.NextNode != null ? List.NextNode : null;

        if(traker.variable==value){
            return sekTracker;
        }


        while(sekTracker?.variable != value){
            sekTracker = sekTracker?.NextNode;
            traker = traker.NextNode;
        }

        if(sekTracker.variable!=value)return new Node(){variable=-404, NextNode=null};

        if(sekTracker.NextNode != null){
            traker.NextNode = sekTracker.NextNode;
            sekTracker.NextNode=null;
        }else{
            traker.NextNode = null;
        }

        return List;
    }

}
*/


        /*
           Node Head = new Node(){variable=1};
           
           
           Node current = Head;
           while(current.NextNode != null){
              current = current.NextNode;
           }  
           Node newNode = new Node(){variable=3,NextNode=null};
           current.NextNode = newNode;

           while(current.NextNode != null){
              current = current.NextNode;
           }
           Node newNode2 = new Node(){variable=3,NextNode=null};
           current.NextNode = newNode2;

           return Head;

        */