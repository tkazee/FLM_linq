using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLM_linq
{
    public class Student
    {
        private static int _id = 1001;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }

        public Student(string name, string course, int marks)
        {
            Id = _id++;
            Name = name;
            Course = course;
            Marks = marks;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Course: {Course}, Marks: {Marks}";
        }

    }
}
