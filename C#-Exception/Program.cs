using C__Exception.Domain.Models;
Student student1 = new Student("Stu1","Surname1",85);
Student student2 = new Student("Stu2","Surname2",75);
Student student3 = new Student("Stu3","Surname3",96);
Student student4 = new Student("Stu4","Surname4",65);
Group gr = new();
gr.AddStudent(student1);
gr.AddStudent(student2);
gr.AddStudent(student3);
gr.AddStudent(student4);
gr.GetAllStudents();

Console.WriteLine("==>operator overloading<==");
Console.WriteLine(student1 > student2);
Console.WriteLine("==>Sorted Students<==\n");
gr.Sort();
Console.WriteLine("==>checking groupNO<==\n");
Group group = new Group();
Console.WriteLine(gr.GroupNo);
Console.WriteLine(group.GroupNo);

