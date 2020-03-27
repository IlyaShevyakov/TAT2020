using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Student : ITaskPerfomer
    {
        private string _name;
        private string _surname;

        public delegate void StudentTask(Student student, string answer);
        public event StudentTask HomeworkDone;
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public static Random random = new Random((int)DateTime.Now.Ticks);
        
        public void DoTask()
        {
            int answerLength = random.Next(1, 10);
            string answer = String.Empty;
            for (int i = 0; i < answerLength; i++)
            {
                answer += $"{(char)random.Next(65, 90)}";
            }
            HomeworkDone?.Invoke(this, answer);
        }

        string ITaskPerfomer.DoTask()
        {
            throw new NotImplementedException();
        }
    }
}
