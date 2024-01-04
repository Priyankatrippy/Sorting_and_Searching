using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
   class Program
    { 
            static void Main()
            {
                StudentManager studentManager = new StudentManager();

                Console.WriteLine("Original Student Data:");
                studentManager.DisplayStudents();

                studentManager.SortStudentsByName();
                Console.WriteLine("\nSorted Student Data by Name:");
                studentManager.DisplayStudents();

                Console.Write("\nEnter a name to search: ");
                string searchName = Console.ReadLine();
                studentManager.SearchStudentByName(searchName);

                studentManager.UpdateAndSaveChanges();
            }
        }

    }

