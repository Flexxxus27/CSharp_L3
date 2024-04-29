namespace CSharp_L3
{
    internal class Program
    {

         

        static void Main(string[] args)
        {
            
            int a = 3, b;
            Class cl = new Class();
            cl.Method3(ref a, out b);
            Console.WriteLine(b);
            Console.WriteLine(a);
            cl.Asd2 = "asd";
            Console.WriteLine(cl.Asd2);
        }
    }
}
