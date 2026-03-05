
namespace FLM_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = CollectionUtils.Student;
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


        }
    }
}
