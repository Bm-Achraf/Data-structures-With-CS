namespace DataStructer;

class stack<T>{
    Node<T>? nodes = null;

    public bool isEmpty(){
        return nodes==null;
    }

    public void Push(T val){

        Node<T> traker = nodes!;
        nodes = new Node<T>(){value=val, next=traker};

    }

    public Node<T> Pop(){

        Node<T> popedNode = new Node<T>(){next=null};
        if(nodes!=null)
          popedNode.value = nodes.value;
        else
           popedNode = null!;

        nodes = nodes?.next;
        
        return popedNode;
    }

    public void display(){
        Node<T> traker = new Node<T>();
        traker = nodes!;
        while(traker != null){
            System.Console.WriteLine(traker.value);
            traker = traker?.next!;
        }
    }
}