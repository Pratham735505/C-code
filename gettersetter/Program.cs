using System.Xml.Serialization;

namespace Fn
{
    public class Student
    {
        private int _id;
        //private string? _name;
        //private int _passMark=35;
        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(">0");
                }
                _id = value;
            }
            get
            {
                return _id;
            }
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
                s.Id = 1;
            Console.WriteLine("Student id={0}",s.Id);
        }
    }
}