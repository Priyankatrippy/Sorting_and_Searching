using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class FileManager
   
    {
        private const string FilePath = "D:/mphasis/Student.txt";

        public static List<Student> ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();

            try
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(',');
                    students.Add(new Student { Name = data[0].Trim(), Class = data[1].Trim() });
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please make sure the file " +
                    "s'Student.txt' exists.");
            }

            return students;
        }

        public static void WriteStudentsToFile(List<Student> students)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine("{student.Name}, {student.Class}");
                }
            }
        }
    }

}

