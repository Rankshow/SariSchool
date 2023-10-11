using System.IO;
namespace SariSchool;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        bool check = true;

        while(check)
        {
            const string path = @"C:\Bank\Student.txt";
            Student firstStudent = new Student();

            Console.WriteLine("Provide us your Name?");
            firstStudent.Name = Console.ReadLine();

            Console.WriteLine("Provide us your Email?");
            firstStudent.Email = Console.ReadLine();

            Console.WriteLine("Provide us your Age?");
            firstStudent.Age = Console.ReadLine();

            // Console.WriteLine("Tell us your score!");
            // int scores = Console.ReadLine();
            // students(firstStude)
            bool courseOffer = true;

            while(courseOffer)
            {
                Console.WriteLine("What course did you offer");
                string? course = Console.ReadLine();
                Console.WriteLine("what did you score in that course?");
                string? result = Console.ReadLine();

                Console.WriteLine("Do you have more subject? true/false");
                courseOffer = Convert.ToBoolean(Console.ReadLine());
            }
                students.Add(firstStudent);
                File.AppendAllText(path, students + Environment.NewLine);
                // Console.WriteLine(students);
                
                Console.WriteLine("Do you want to continue?");
                check = Convert.ToBoolean(Console.ReadLine());
        }
    }
}
