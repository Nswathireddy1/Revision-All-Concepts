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
    class Student
    {
       public int rollno;
       public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream(@"F:\ReadWrite\Demo15.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student s = new Student(101, "sonoo");
            formatter.Serialize(stream, s);

            stream.Close();
        }
    }
}

