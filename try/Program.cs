// See https://aka.ms/new-console-template for more information
using System;
namespace Ab
{
    class A
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string? s=Console.ReadLine();

            
            string o = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]=='a'|| s[i]=='e'|| s[i]=='i' || s[i] == 'o' || s[i] =='u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                {
                    o += Convert.ToChar(s[i] + 1);
                }
                else
                {
                    o += s[i];
                }
            }
            /*for(int i=0; i<s.Length; i++)
            {
                if (s[i] != 32)
                {
                    if (s[i] >= 97 && s[i]<=122)
                    {
                        o += Convert.ToChar(s[i] - 32);
                    }
                    else if(s[i] >= 'a' && s[i]<='z')
                    {
                        o += Convert.ToChar(s[i] + 32);
                    }
                }
                else
                {
                    o += " ";
                }
            }*/
            Console.WriteLine(o);
            /*char[] arr=(s.ToUpper()).ToCharArray();
            for(int i = 0;arr.Length > i; i++)
            {
                if (arr[i]!=32)
                arr[i]=Convert.ToChar(arr[i]+ 2);
            }
            s = new string(arr);
            Console.WriteLine(s);
            */
            //arr(s.ToUpper());
        }

        public static void arr(string s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = i+1; j < arr.Length; j++) 
                {
                    if (arr[i] > arr[j])
                    {
                        char temp= arr[i];
                        arr[i]=arr[j];
                        arr[j] = temp;         
                    }    
                }
            }
            string? s2 = new string(arr);
            Console.WriteLine(s2);
        }
    }
}