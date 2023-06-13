using System;

namespace SoalNo3
{
    class ValueType
    {
        static void Enroll(bool enrollmentStatus)
        {
            // This will not change any value outside the method.
            enrollmentStatus = true;
        }

        static void Main1()
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(student.Enrolled);
            // student.Enrolled still equals false.
        }
    }

    public class Student {
        public string Name {get;set;}
        public bool Enrolled {get;set;}
    }
}