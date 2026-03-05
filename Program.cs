
namespace FLM_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = CollectionUtils.Student;
            Console.WriteLine("----All students----");
            foreach (Student stud in students) Console.WriteLine(stud);
            Console.WriteLine("================================");
            //Native Sql : Select * from Student where marks>70

            //LINQ : from stud in students  where stud.Marks>70

            /*
                Traditional model of filtering collections using foreach
            foreach(var student in students)
            {
                if(student.Marks>=70)
                {
                    Console.WriteLine(student);
                }
            }
            */

            /*
            var filteredList1 = (from student in students
                                                         where student.Marks >= 70
                                                         select student).ToList();
            var newList2 = students.Where(stud => stud.Marks >= 70);
            foreach (var stud in newList2)
            {
                Console.WriteLine(stud);    
            }
            Console.WriteLine("-------------------------");
            foreach(var stud in filteredList1)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("-------------------------");
            //return name
            var name = from stud in students where stud.Marks >= 70 select stud.Name;
            foreach(var stud in name)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("-------------------------");
            var nameExtentionModel = (students.Where(stud => stud.Marks >= 70).Select(stud => stud.Name)).ToList();
            */

            //Sorting
            Console.WriteLine("\n---Ascending order query ----\n");
            var sortedList = from stud in students orderby stud.Marks select stud;
            foreach (var stud in sortedList)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("\n---Ascending order extension method----\n");

            var sortedList2 = students.OrderBy(stud => stud.Marks);
            foreach (var stuedent in sortedList2)
            {
                Console.WriteLine(stuedent);

            }

            Console.WriteLine("\n---------Group By Course-----------\n");
            var groupByCourse = from stud in students group stud by stud.Course;
            var groupByCourse2 = students.GroupBy(stud => stud.Course);
            foreach (var stud in groupByCourse2)
            {
                Console.WriteLine(stud.Key);
            foreach (var student in stud) Console.WriteLine(student);
            }
            
        }
    }
}
