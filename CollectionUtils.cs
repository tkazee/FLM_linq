using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLM_linq
{
    public class CollectionUtils
    {
        public static List<Student> _students = new List<Student>();
        public static List<Product> _products = new List<Product>();


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
            _students.Add(new Student("Alice", "Mathematics", 85));
            _students.Add(new Student("Bob", "Physics", 78));

            _products.Add(new Product("Mobiles", 10000, 20));
            _products.Add(new Product("TV", 23330, 20));
            _products.Add(new Product("PC", 25000, 20));
            _products.Add(new Product("Ac", 70000, 20));
            _products.Add(new Product("Cooler", 50000, 20));
            _products.Add(new Product("Mobiles", 901555, 20));
            _products.Add(new Product("Mobiles", 10000, 20));


        }
        //encapsulation
        public List<Student> Student
        {
            get { return _students; }
        }
        public List<Product> Product
        {
            get { return _products; }
        }


    }

}
