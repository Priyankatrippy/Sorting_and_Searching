using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            students = FileManager.ReadStudentsFromFile();
        }

        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Class: {student.Class}");
            }
        }

        public void SortStudentsByName()
        {
            students = students.OrderBy(s => s.Name).ToList();
        }

        public void SearchStudentByName(string name)
        {
            var searchResults = students
                .Where(s => s.Name.ToLower().Contains(name.ToLower()))
                .ToList();

            if (searchResults.Any())
            {
                Console.WriteLine("Search Results:");
                foreach (var result in searchResults)
                {
                    Console.WriteLine($"Name: {result.Name}, Class: {result.Class}");
                }
            }
            else
            {
                Console.WriteLine("No matching students found.");
            }
        }

        public void UpdateAndSaveChanges()
        {
            FileManager.WriteStudentsToFile(students);
        }
    }
}

