using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    [Serializable]
    class Student1
    {
        int rollno;
        string name;
        public Student1(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"F:\ReadWrite\Demo15.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s.rollno);
            Console.WriteLine("Name: " + s.name);

            stream.Close();
            Console.Read();
        }
    }
}
