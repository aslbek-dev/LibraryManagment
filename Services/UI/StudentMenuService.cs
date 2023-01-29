using LibraryManagment.Models;

namespace LibraryManagment.Services
{
    public class StudentMenuService : IStudentMenuService
    {
        private void Back()
        {
            Console.WriteLine("\n\norqaga qaytish - 0...");
            Console.WriteLine("\nChiqish -1...");
            int.TryParse(Console.ReadLine(), out int option);
            switch(option)
            {
                case 0:
                    LoadStudentMenu(); break;
                case 1:
                    Environment.Exit(0); break;
            }

        }
        private readonly IStudentService studentService;
        public StudentMenuService()
        {
            this.studentService = new StudentService();
            var temproryStudent = new User()
            {
                Name = "Amir",
                UserId = 100,
                UserType = UserType.Student,
                Birthday = DateTime.Now,
                Gender = Gender.Male
            };
            this.studentService.AddStudent(temproryStudent);
        }
        private void DisplayStudent()
        {   
            var students = 
                this.studentService.RetrieveStudents();
            for(int i = 0; i < students.Count; i++)
                Console.WriteLine($"{i + 1}. {students[i]}");
            Back();
        }
        private void SearchStudent()
        {
            Console.Write("Student IDni kiriting: ");
            int.TryParse(Console.ReadLine(), out int studentId);
            var findedStudent = this.studentService.RetrieveStudent(studentId);
            Console.WriteLine(findedStudent);
            Back();
        }
        private void PushStudent()
        {
            User student = new User();
            Console.Write("Ism: ");
            student.Name = Console.ReadLine();

            Console.Write("Tugilgan kun: ");
            student.Birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Gender(Male or Female): ");
            student.Gender = Enum.Parse<Gender>(Console.ReadLine());

            student.UserType = UserType.Student;
            student.UserId = 1;  
            this.studentService.AddStudent(student);
            Console.WriteLine(student);
            Back();

        }
        private void ChangeStudent()
        {
            Console.Write("Id: ");
            int studentId = int.Parse(Console.ReadLine());
            var student = this.studentService.RetrieveStudent(studentId);
            Console.WriteLine(student);
            Console.Write("Ism: ");
            student.Name = Console.ReadLine();

            Console.Write("Tugilgan kun: ");
            student.Birthday = DateTime.Parse(Console.ReadLine());

            Console.Write("Gender(Male or Female): ");
            student.Gender = Enum.Parse<Gender>(Console.ReadLine());

            student.UserType = UserType.Student;
            student.UserId = student.UserId;
            Console.WriteLine(student);
            this.studentService.ModifyStudent(studentId, student);
            Back();
        }
        private void DeleteStudent()
        {
            Console.Write("ID...");
            int.TryParse(Console.ReadLine(), out int studentId);
            this.studentService.RemoveStudent(studentId);
            Back();
        }
        public void LoadStudentMenu()
        {
            Console.Clear();
            var homeService = new HomeService();
            string menu = "1.Ro'yxat\n"+
                          "2.Qidirish\n"+
                          "3.Qo'shish\n"+
                          "4.Yangilash\n"+
                          "5.O'chirish\n"+
                          "6.Orqaga\n";
            Console.WriteLine("<====Talabalar Menyu====>");
            Console.WriteLine(menu);
            Console.Write("menyuni tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);
            Console.Clear();
            switch(option)
            {
                case 1:
                    DisplayStudent(); break;
                case 2:
                    SearchStudent(); break;
                case 3:
                    PushStudent(); break;
                case 4:
                    ChangeStudent(); break;
                case 5:
                    DeleteStudent(); break;
                case 6:
                    homeService.LoadExistingMenus(); break;
            }
        }
    }
}