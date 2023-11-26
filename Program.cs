//school database
nameSpace SchoolDatabase
{
    class Menu 
    {
        private SchoolDatabase schoolDb;

        public Menu(SchoolDatabase schoolDb)
        {
            this.schoolDb = schoolDb;
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1.Add Student Details");
            Console.WriteLine("2.Display Student");
            Console.WriteLine("3.Exit");
        }

        public void HandleChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudentDetails();
                    break;
                case 2:
                    schoolDb.DisplayStudents();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        private void AddStudentDetails()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter student email: ");
            string email = Console.ReadLine();

            Console.Write("Enter student address: ");
            string address = Console.ReadLine();

            Student student = new Student(name, age, email, address);
            schoolDb.AddStudent(student);

            Console.WriteLine("Student details added successfully.");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Student(string name,int age,string email,string address)
        {
            Name = name;
            Age = age;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nEmail: {Email}\nAddress: {Address}\n";
        }
    }

    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Teacher(string name,int age,string email,string address)
        {
            Name = name;
            Age = age;
            Email = email;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nEmail: {Email}\nAddress: {Address}\n";
        }
    }

    class SchoolDatabase
    {
        private string[] students;
        private string[] teachers;

        public SchoolDatabase()
        {
            students = new string[0];
            teachers = new string[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1] = student.ToString();
        }

        public void AddTeacher(Teacher teacher)
        {
            Array.Resize(ref teachers, teachers.Length + 1);
            teachers[teachers.Length-1] = teacher.ToString();
        }

        public void DisplayStudents()
        {
            Console.WriteLine("Students: ");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void DisplayTeachers()
        {
            Console.WriteLine("Teachers: ");
            foreach (string teacher in teachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}

using SchoolDatabase;

SchoolDatabase schoolDb = new SchoolDatabase();
Menu menu = new Menu(schoolDb);
Console.WriteLine("Welcome to the school database!");
while(true)
{
    menu.DisplayMainMenu();
    menu.HandleChoice();
}






































