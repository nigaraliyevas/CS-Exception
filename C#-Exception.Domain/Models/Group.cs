namespace C__Exception.Domain.Models
{
    public class Group
    {
        public int Id { get; }
        private static int _id;
        public int No { get; }
        private static int _groupNo = 100;
        public string GroupNo;
        private List<Student> StudentList = new();
        public Group()
        {
            Id = ++_id;
            No = ++_groupNo;
            GroupNo = $"AP{No}";
        }
        public Student AddStudent(Student student)
        {
            StudentList.Add(student);
            return student;
        }
        public void GetAllStudents()
        {
            if (StudentList.Count <= 0)
            {
                throw new Exception("Empty List...");
            }
            else
            {
                foreach (var student in StudentList)
                {
                    Console.WriteLine($"Name:{student.Name}, Surname:{student.Surname}, Point{student.Point}");
                }
            }

        }
        public void Sort()
        {
            var newListStudents = StudentList;
            newListStudents.Sort();
            newListStudents.Reverse();
            /*foreach (var student in newListStudents)
            {
                Console.WriteLine(student);
            }*/
        }
    }
}