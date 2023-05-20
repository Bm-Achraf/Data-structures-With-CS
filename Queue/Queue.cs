namespace DataStructer;

class queue<T>{

    Node<T> nodes = null!;

    public bool isEmpty(){
        return nodes == null;
    } 

    public void EnQueue(T val){

        nodes = new Node<T>(){value=val, next=nodes};

    }

    public Node<T> DeQueue(){

            Node<T> node = new Node<T>();
        
            if(nodes.next == null){

                node.value = nodes.value;
                node.next = null;

                nodes = null!;
                return node;
            }
            

            Node<T> traker = nodes;
            Node<T> seqTraker = nodes.next!;
            //nodes = nodes.next;

            while(seqTraker.next!=null){
                seqTraker = seqTraker.next;
                traker = traker.next!;
            }

            
            traker.next = null;

            node.value = seqTraker.value;
            node.next = null;

            return node;
            
        


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