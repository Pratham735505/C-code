// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace B
{
    class Parent
    {

        public int Id()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            return c;
        }
    }

    class Child : Parent{
        public int Id1() {
            return 1;
        }
    }
    class M
    {
        public static void Main(string[] args)
        {
            /*Child child = new Child();
            Console.WriteLine(child.Id() + child.Id1());
            switch (child.Id())
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("3");
                    break;
            }
            unsafe
            {
                int x = 100;
                int* ptr = &x;
                Console.WriteLine(*ptr);
                Console.WriteLine(&x);
            }*/
            /*
            int[] n = new int[5];
            int[] a = { 1, 2, 3 };
            int[] b = new int[] { 1, 2, 3 };

            int[,] d = new int[5, 6];
            int[][] e = new int[5][];
            e[0] = new int[7] { 1,2,6,9,4,8,9};
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            for(int i = 0;i < d.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(d[i,j]);
                }
            }*/


            struct Temperature
        {
            public double celsius;

            public double Celsius
            {
                get { return celsius; }
                set { celsius = value; }
            }

            public double Fahrenheit
            {
                get { return celsius * 9 / 5 + 32; }
                set { celsius = (value - 32) * 5 / 9; }
            }
        }

        Temperature t1 = new Temperature { Celsius=6.8};
        t1.Celsius
        
    }

        
    }
}