// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Xml.Serialization;
namespace Contacts
{
    class Class1
    {
        static Int64[] num = new Int64[100];
        static String[] name = new string[100];
        static int c = 0;
        public static void Main()
        {
        
            int choice;
            do
            {
                Console.WriteLine("Enter choice:\n1.Add contact\n2.Update Contact\n3.Remove Contact\n4.Search\n5.Exit:");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        update();
                        break;
                    case 3:
                        remove();
                        break;
                    case 4:
                        search();
                        break;
                    case 5:
                        Console.WriteLine("Exited");
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
            }while(choice!=5);
        }

        public static void add()
        {
            if (c < 100)
            {
                Console.WriteLine("Enter name");
                name[c]=Convert.ToString(Console.ReadLine()!);
                Console.WriteLine("Enter number");
                do
                {
                    num[c]= Convert.ToInt64(Console.ReadLine() !);
                    if(num[c] >= 1000000000 && num[c] <= 9999999999)
                    {
                        Console.WriteLine("Saved");
                        break;
                    }
                } while (true);
                c++;
            }
            else
            {
                Console.WriteLine("Contact full");
            }
        }
        public static void search()
        {
            
            int choice;
            do
            {
                Console.WriteLine("1.Search by name\n2.Search by number\n3.Exit");
                choice = Convert.ToInt32(Console.ReadLine()!);
                switch (choice)
                {
                    case 2:
                        Console.WriteLine("Enter number:");
                        int flag = 1;
                        Int64 n = Convert.ToInt64(Console.ReadLine()!);
                        for (int i = 0; i < c; i++)
                        {
                            if (num[i] == n)
                            {
                                Console.WriteLine("Number found" + " " + name[i] + " " + num[i]);
                                flag = 0;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    case 1:
                        Console.WriteLine("Enter name:");
                        int f = 1;
                        string n1 = Convert.ToString(Console.ReadLine()!);
                        for (int i = 0; i < c; i++)
                        {
                            if (name[i] == n1)
                            {
                                Console.WriteLine("Name found " + name[i] + " " + num[i]);
                                f = 0;
                            }

                        }
                        if (f == 1)
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 3);
        }


        public static void update() {
            Console.WriteLine("1.Name updation\n2.Number\n3.Exit");
            int choice;
            do
            {
                choice = Convert.ToInt32(Console.ReadLine()!);
                switch (choice)
                {
                    case 2:
                        Console.WriteLine("Enter number:");
                        
                        int flag = 1;
                        Int64 n = Convert.ToInt64(Console.ReadLine()!);
                        for (int i = 0; i < c; i++)
                        {
                            if (num[i] == n)
                            {
                                Console.WriteLine("Enter new number:");
                                num[i]=Convert.ToInt64(Console.ReadLine()!);
                                flag = 0;
                                break;
                            }
                        }
                        if (flag == 1)
                        {
                            Console.WriteLine("Not found");
                        }
                        break;
                    case 1:
                        Console.WriteLine("Enter name:");
                        int f = 1;
                        string n1 = Convert.ToString(Console.ReadLine()!);
                        for (int i = 0; i < c; i++)
                        {
                            if (name[i] == n1)
                            {
                                Console.WriteLine("Name found " + name[i] + " " + num[i]);
                                f = 0;
                            }

                        }
                        if (f == 1)
                        {
                            Console.WriteLine("Not found");
                        }
                        else
                        {
                            Console.WriteLine("Enter number whose name you want to update?");
                            int fg = 1;
                            Int64 n3 = Convert.ToInt64(Console.ReadLine()!);
                            for (int i = 0; i < c; i++)
                            {
                                if (num[i] == n3)
                                {
                                    Console.WriteLine("Enter new name:");
                                    name[i] = Convert.ToString(Console.ReadLine()!);
                                    fg = 0;
                                    break;
                                }
                            }
                            if (fg == 1)
                            {
                                Console.WriteLine("Not found");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 3);
        }
        public static void remove()
        {
            if (c != 0)
            {
                Console.WriteLine("Enter number you want to remove");
                Int64 n = Convert.ToInt64(Console.ReadLine()!);
                int flag = 1;
                int d = 0;
                for (int i = 0; i < c; i++)
                {
                    if (n == num[i])
                    {
                        d = i;
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    for (int i = d; i < c; i++)
                    {
                        num[i] = num[i + 1];
                        name[i] = name[i + 1];

                    }
                    c--;
                    Console.WriteLine("Deleted");
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
        
    }
}