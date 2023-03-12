namespace SimpleTree
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("My simple tree");
            
            var tree = new TreeMap();

            Console.WriteLine("Add node:");
            var newNode = Console.Read();
            tree.Add(newNode);


        }
    }
}