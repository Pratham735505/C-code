using AssDbmslib;

namespace Test
{
    internal class Program
    {
        static Login l = new Login();
        static void Main(string[] args)
        {
            string s = l.ValidateLogin("pg123", "1256")+"";
            Console.WriteLine(s);
            Console.WriteLine("Hello, World!");
        }
    }
}
