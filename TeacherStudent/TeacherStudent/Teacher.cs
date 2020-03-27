using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Teacher
    {
        public List<string> TaskResults { get; private set; }
        public Teacher()
        {
            TaskResults = new List<string>();
        }
        public void AcceptTheWork(Student student, string answer)
        {
            TaskResults.Add(student.Name + " " + student.Surname + " " + answer);

            if (TaskResults.Count == 10)
            {
                PrintAllResults();
            }
        }

        /// <summary>
        /// in method StudenDone event handler is added
        /// </summary>
        public void StudentDone(Student student)
        {
            student.HomeworkDone += AcceptTheWork;
        }

        /// <summary>
        /// method PrintAllResults print data from list
        /// </summary>
        public void PrintAllResults()
        {
            foreach (var line in TaskResults)
            {
                Console.WriteLine(line);
            }
        }
    }
}
