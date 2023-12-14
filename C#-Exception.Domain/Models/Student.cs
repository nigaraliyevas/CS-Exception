namespace C__Exception.Domain.Models
{
    public class Student:IComparable<Student>
    {
        public int Id { get;}
        private static int _id { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point {
            get
            {
                return _point;
            }
            set {
                if (value < 1 && value > 100) return;
                _point = value;
            }
        }
        private int _point { get; set; }
        public Student(string name,string surname,int point)
        {
            Name=name;
            Surname=surname;
            Point=point;
        }
        public override string ToString()
        {
            return $"Name:{Name},Surname:{Surname},Point:{Point}";
        }
        //Show Info Method
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname:{Surname}, Point{Point}");
        }
        //Comparing For Point
        public int CompareTo(Student? student)
        {
            return student.Point.CompareTo(Point);
        }

        //Operator Overloadings
        public static bool operator <(Student student1, Student student2)
        {
            return student1.Point < student2.Point;
        }
        public static bool operator >(Student student1, Student student2)
        {
            return (student1.Point > student2.Point);
        }
    }
}
