using System;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            gclass<anur> x = new gclass<anur>();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class anur
    {
        public int i { get; set; }
    }

    class gclass<T> {
        public T ttype ;
        public gclass()
        {
            
        var t= typeof(T).GetMembers();
            foreach (var item in t)
            {
                Console.WriteLine(item.Name); 
            }
            Console.WriteLine(t);
        }
}

}
