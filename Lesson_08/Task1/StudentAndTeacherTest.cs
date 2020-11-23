using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_08.Task_01
{
    public class StudentAndTeacherTest
    {
        public void Main()
        {
            Person person = new Person();
            person.Say("Hello!!");

            Student student = new Student();
            student.SetAge(20);
            student.Say("Greeting!");
            student.GoToClasses();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Say("Hello");
            teacher.Explain();

            Console.ReadLine();
        }
    }
}