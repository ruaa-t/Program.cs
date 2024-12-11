using System;

namespace consoleApp_28
{
 

using System;
using System.Collections.Generic;

class Program
    {
        
        struct Student
        {
            public int Id;                 
            public string Name;           
            public double Exam1Score;       
            public double Exam2Score;       
            public double AverageScore;     
            public string Grade;           

            
            public void CalculateAverageAndGrade()
            {
                
                AverageScore = (Exam1Score + Exam2Score) / 2;

              
                if (AverageScore < 60)
                    Grade = "راسب";
                else if (AverageScore < 75)
                    Grade = "جيد";
                else if (AverageScore < 90)
                    Grade = "جيد جدا";
                else
                    Grade = "ممتاز";
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); 
            int numberOfStudents;

            Console.Write("أدخل عدد الطلاب: ");
            numberOfStudents = int.Parse(Console.ReadLine()); 

            
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student(); 

                Console.Write($"أدخل رقم الطالب {i + 1}: ");
                student.Id = int.Parse(Console.ReadLine()); 

                Console.Write($"أدخل اسم الطالب {i + 1}: ");
                student.Name = Console.ReadLine(); 

                Console.Write($"أدخل علامة الاختبار الأول للطالب {i + 1}: ");
                student.Exam1Score = double.Parse(Console.ReadLine()); 

                Console.Write($"أدخل علامة الاختبار الثاني للطالب {i + 1}: ");
                student.Exam2Score = double.Parse(Console.ReadLine()); 

                
                student.CalculateAverageAndGrade();

                
                students.Add(student);
            }

           
            students.Sort((s1, s2) => s1.AverageScore.CompareTo(s2.AverageScore));

           
            Console.WriteLine("\nبيانات الطلاب بعد الفرز:");
            Console.WriteLine("رقم\tاسم\tعلامة اختبار أول\tعلامة اختبار ثاني\tمحصلة\tتقدير");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Exam1Score}\t{student.Exam2Score}\t{student.AverageScore:F2}\t{student.Grade}");
            }
        }
    }



}
