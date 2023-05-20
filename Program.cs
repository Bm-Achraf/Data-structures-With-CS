namespace DataStructer;


class Program{

    public static void Main(string[] args){
 
         hashTable hash = new hashTable(10, 4, 5, 74, 10);

         hash.Add(500);
         hash.Add(15899);
         hash.Add(15871);
         hash.Add(139);
         hash.Add(1);
         hash.Add(50);
         hash.Add(10);
         hash.Add(10);

         hash.Display(); 
         hash.Delete(10);
         hash.Display();

    } 

}