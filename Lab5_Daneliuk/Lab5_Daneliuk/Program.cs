using Lab5_Daneliuk.task_1;
using Lab5_Daneliuk.task_2;
using Lab5_Daneliuk.task_3;
    struct Student
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public string Address;
        public string Group;
        public double Rating;

        public Student(string name, string surname, string patronymic, string address, string group, double rating)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Address = address;
            Group = group;
            Rating = rating;
        }
    }
    record Student3(string Name, string Surname, string Patronymic, string Address, string Group, double Rating);

    internal class Program {
        static void Main(string[] args)
        {
            ChooseTask();
        }

        static void task1() 
        {
            Test test = new Test("C# Testing", new DateTime(2025, 5, 10));
            Exam exam = new Exam("Semester Exam", new DateTime(2025, 6, 15), "Programming");
            FinalExam finalExam = new FinalExam("State Exam", new DateTime(2025, 7, 1), "Computer Science", true);
            Trial trial = new Trial("Physical Trial", new DateTime(2025, 4, 20), "100m Sprint");

            test.Show();
            exam.Show();
            finalExam.Show();
            trial.Show();
        }

        static void task2()
        {
            Test1 test = new Test1("C# Testing", new DateTime(2025, 5, 10));
            Exam1 exam = new Exam1("Semester Exam", new DateTime(2025, 6, 15), "Programming");
            FinalExam1 finalExam = new FinalExam1("State Exam", new DateTime(2025, 7, 1), "Computer Science", true);
            Trial1 trial = new Trial1("Physical Trial", new DateTime(2025, 4, 20), "100m Sprint");

            test.Show();
            exam.Show();
            finalExam.Show();
            trial.Show();
        }

        static void task3()
        {
            Product[] products = new Product[]
            {
                new Toy("Toy Car", 15.99m, "ToyFactory", "Plastic", 3),
                new Book("C# Programming", 29.99m, "John Doe", "TechPress", 14),
                new SportsEquipment("Football", 19.99m, "SportCo", 6),
            };

            Console.WriteLine("Product Information:");
            foreach (var product in products)
            {
                product.ShowInfo();
                Console.WriteLine();
            }

            string searchType = "book";
            Console.WriteLine($"Searching for {searchType}s:");
            foreach (var product in products)
            {
                if (product.IsOfType(searchType))
                {
                    product.ShowInfo();
                }
            }
        }
        static void task4() 
        {
            Student[] students = new Student[]
            {
                new Student("John", "Doe", "Smith", "123 Main St", "A1", 4.5),
                new Student("Jane", "Doe", "Brown", "456 Oak St", "A2", 3.0),
                new Student("Bob", "Johnson", "Williams", "789 Pine St", "A1", 4.0)
            };

            double minRating = 3.5; 
            students = students.Where(s => s.Rating >= minRating).ToArray();
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = new Student("Alice", "Smith", "Johnson", "101 Maple St", "A3", 4.8);

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name} {student.Surname} {student.Patronymic}, Group: {student.Group}, Rating: {student.Rating}");
            }

            //
            //
            //

            var students1 = new (string Name, string Surname, string Patronymic, string Address, string Group, double Rating)[]
            {
                ("John", "Doe", "Smith", "123 Main St", "A1", 4.5),
                ("Jane", "Doe", "Brown", "456 Oak St", "A2", 3.0),
                ("Bob", "Johnson", "Williams", "789 Pine St", "A1", 4.0)
            };

            double minRating1 = 3.5; 
            students1 = students1.Where(s => s.Rating >= minRating1).ToArray(); 

            Array.Resize(ref students1, students1.Length + 1);
            students1[students1.Length - 1] = ("Alice", "Smith", "Johnson", "101 Maple St", "A3", 4.8);

            foreach (var student in students1)
            {
                Console.WriteLine($"Name: {student.Name} {student.Surname} {student.Patronymic}, Group: {student.Group}, Rating: {student.Rating}");
            }

        //
        //
        //
            var students3 = new Student3[]
            {
                    new Student3("John", "Doe", "Smith", "123 Main St", "A1", 4.5),
                    new Student3("Jane", "Doe", "Brown", "456 Oak St", "A2", 3.0),
                    new Student3("Bob", "Johnson", "Williams", "789 Pine St", "A1", 4.0)
            };

            double minRating3 = 3.5; 
            students3 = students3.Where(s => s.Rating >= minRating3).ToArray(); 

            students3 = students3.Append(new Student3("Alice", "Smith", "Johnson", "101 Maple St", "A3", 4.8)).ToArray();

            foreach (var student in students3)
            {
                Console.WriteLine($"Name: {student.Name} {student.Surname} {student.Patronymic}, Group: {student.Group}, Rating: {student.Rating}");
            }
        }
        static void ChooseTask() 
        {
            Console.WriteLine("1 - task1");
            Console.WriteLine("2 - task2");
            Console.WriteLine("3 - task3");
            Console.WriteLine("4 - task4");
            Console.WriteLine("0 - exit");
            Console.WriteLine("Choose task number: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
                
            switch (taskNumber) {

                case 1:
                    Console.WriteLine("Task #1");
                    task1();
                    ChooseTask();
                    break;
                case 2:
                    Console.WriteLine("Task #2");
                    task2();
                    ChooseTask();
                    break;
                case 3:
                    Console.WriteLine("Task #3");
                    task3();
                    ChooseTask();
                    break;
                case 4:
                    Console.WriteLine("Task #4");
                    task4();
                    ChooseTask();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
            }
        }
}

