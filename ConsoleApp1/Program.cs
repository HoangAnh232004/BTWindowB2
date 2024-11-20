using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{

    internal class Program
    {
        static void PrintAllStudents(List<Student> students)
        {
            Console.WriteLine("Danh sach toan bo hoc sinh");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();
        }
        static void PrintStudentsByAgeRange(List<Student> students, int minAge, int maxAge)
        {
            Console.WriteLine($"Hoc sinh co tuoi tu {minAge} den {maxAge}:");
            var filteredStudents = students.Where(s => s.Age >= minAge && s.Age <= maxAge).ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();
        }
        static void PrintStudentsByNameStartWith(List<Student> students, string startWith)
        {
            Console.WriteLine($"Hoc sinh co chu bat dau bang '{startWith}':");
            var filteredStudents = students.Where(s => s.Name.StartsWith(startWith, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();
        }
        static void PrintTotalAge(List<Student> students)
        {
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"Tong so tuoi cua tat ca hoc sinh: {totalAge}");
            Console.WriteLine();
        }
        static void PrintOldestStudent(List<Student> students)
        {
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine("Hoc sinh co tuoi lon nhat:");
                Console.WriteLine($"Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            }
            Console.WriteLine();
        }
        static void PrintStudentsSortedByAge(List<Student> students)
        {
            Console.WriteLine("Danh sach hoc sinh sau khi sap xep tuoi tang dan:");
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
            Console.WriteLine();
        }


        static void Main(string[] args) {
         List<Student> students = new List<Student>
        {
            new Student { Name = "Anh", Age = 20 },
            new Student { Name = "Bao", Age = 16 },
            new Student { Name = "An", Age = 18 },
            new Student { Name = "Cuong", Age = 14 },
            new Student { Name = "Duong", Age = 19 }
        };

        PrintAllStudents(students);                
        PrintStudentsByAgeRange(students, 15, 18); 
        PrintStudentsByNameStartWith(students, "A");
        PrintTotalAge(students);                  
        PrintOldestStudent(students);             
        PrintStudentsSortedByAge(students);       
    }
}

    }


