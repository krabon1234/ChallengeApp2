﻿

namespace ChallengeApp2
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
            
        }

        private List<float> Grades = new List<float>();

        public override void SayHello()
        {
            Console.WriteLine("Hi!!!");
            base.SayHello();
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                Grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid range number");
                //Console.WriteLine("invalid range number");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                //Console.WriteLine("string conversion impossible");
                throw new Exception("string conversion impossible");
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100); break;
                case 'B':
                case 'b':
                    this.AddGrade(80); break;
                case 'C':
                case 'c':
                    this.AddGrade(60); break;
                case 'D':
                case 'd':
                    this.AddGrade(40); break;
                case 'E':
                case 'e':
                    this.AddGrade(20); break;
                default:
                    this.AddGrade(0);
                    //Console.WriteLine("Wrong letter"); 
                    throw new Exception("Wrong letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.Grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.Grades.Count;

            //switch z warunkami
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;


            }


            //Console.WriteLine($"Wartosc minimalna: {statistics.Min}     ");
            //Console.WriteLine($"Wartosc maksymalna: {statistics.Max}    ");
            //Console.WriteLine($"Wartosc srednia: {statistics.Average:N2}   ");
            //Console.WriteLine(statistics.AverageLetter);
            return statistics;
        }
    }
}
