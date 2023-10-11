using System.Text;

namespace SariSchool
{
    public class Student
    {
        public Student()
        {
            StudentId = Guid.NewGuid();
        }
        public Guid StudentId { get; private set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Age { get; set; }
        Dictionary<int, string> student = new Dictionary<int, string>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name : { Name }");
            sb.Append($"Email : { Email }");
            sb.Append($"Age : { Age }");

            return sb.ToString();
        }
    }
}