using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLM_linq
{
    public class CollectionUtils
    {
        public static List<Student> _students = new List<Student>()
        {
                new Student("Alice", "Mathematics", 85),
                new Student("Bob", "Physics", 78),
                new Student("Charlie", "Chemistry", 92),
                new Student("David", "Biology", 88),
                new Student("Eve", "Computer Science", 95)
        };
        public static List<Product> _products = new List<Product>()
        {
            new Product("Mobiles", 10000, 20),
            new Product("TV", 23330, 20),
            new Product("PC", 25000, 20),
            new Product("Ac", 70000, 20),
            new Product("Cooler", 50000, 20),
            new Product("Mobiles", 901555, 20),
            new Product("Mobiles", 10000, 20),
        };


        //this create a new obj every time
        //public List<Student> GetStudents()
        //{
        //    List<Student> students = new List<Student>();
        //    students.Add(new Student(1001, "Alice", "Mathematics", 85));
        //    students.Add(new Student(1002, "Bob", "Physics", 78));
        //    students.Add(new Student(1003, "Charlie", "Chemistry", 92));
        //    students.Add(new Student(1004, "David", "Biology", 88));
        //    students.Add(new Student(1005, "Eve", "Computer Science", 95));
        //    return students;
        //}

        public CollectionUtils()
        {
        }
        //encapsulation
        public static List<Student> Student
        {
            get { return _students; }
        }
        public static List<Product> Product
        {
            get { return _products; }
        }


    }

}
