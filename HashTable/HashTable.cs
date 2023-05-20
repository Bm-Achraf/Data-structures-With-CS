namespace DataStructer;

public class hashTable{

    Node<int>[]? HT;

    public hashTable(params int[] indexs){
        HT = new Node<int>[indexs.Length];

        for(int i=0; i<indexs.Length; i++)
           HT[i] = new Node<int>(){value=indexs[i], next=null};
    }


    public void Add(int value){
        
        int index = value.GetHashCode() % HT!.Length;
        
        if(HT![index] == null){
            HT[index] = new Node<int>();
            HT[index].value = value;
            HT[index].next = null;
            return;
        }

        Node<int> traker = HT[index];
        HT[index] = new Node<int>(){value=value, next=traker};
        return;
    }

    Node<int>? reGenerateList(Node<int> list, int value){
        Node<int>? traker = list;
        Node<int>? seQtraker = list.next;

        if(traker.value == value){
            if(seQtraker!=null){
                return seQtraker;
            }
            return null;
        }

        while(seQtraker!=null){
            if(seQtraker.value==value)break;
            
            traker = seQtraker;
            seQtraker = seQtraker.next;
        }

        if(seQtraker!.next != null){
            traker.next = seQtraker.next;
            seQtraker = null;
            return list;
        }

        traker.next = null;
        return list; 


    }
    public void Delete(int value){

          Node<int>? traker = new Node<int>();
          for(int i=0; i<HT.Length; i++){
              traker = HT[i];
              while(traker!=null && traker.value!=value){
                  traker = traker.next;
              }

              if(traker!=null && traker.value == value){
                HT[i] = reGenerateList(HT[i], value)!;
                return;
              }
          }
          
          System.Console.WriteLine("value does not exist");

    }

    public void Display(){

        for(int i=0; i<HT!.Length; i++){
            if(HT[i]==null){
                System.Console.Write(-1);
            }else{
                
                Node<int>? traker = HT[i];
                while(traker!=null){
                    System.Console.Write($"{traker.value} ");
                    traker = traker.next;
                }

            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine();

    }

}