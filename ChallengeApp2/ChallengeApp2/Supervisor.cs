

namespace ChallengeApp2
{
    public class Supervisor : IEmployee
    {

        public Supervisor(string name, string surname) 
        {
           
        }

        private List<float> Grades = new List<float>();
        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public void AddGrade(float grade)
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

        //wyzw 21dni, dzien 15
        public void AddGrade(string grade)
        {

            switch (grade)
            {
                case "6": AddGrade(100); break;
                case "6-":
                case "-6": AddGrade(95); break;

                case "5+":
                case "+5":
                    AddGrade(85); break;
                case "5":
                    AddGrade(80); break;
                case "5-":
                case "-5":   
                    AddGrade(75); break;

                case "4+":
                case "+4":
                    AddGrade(65); break;
                case "4":
                    AddGrade(60); break;
                case "4-":
                case "-4":
                    AddGrade(55); break;

                case "3+":
                case "+3":
                    AddGrade(45); break;
                case "3":
                    AddGrade(40); break;
                case "3-":
                case "-3":
                    AddGrade(40); break;

                case "2+":
                case "+2":
                    AddGrade(25); break;
                case "2":
                    AddGrade(20); break;
                case "2-":
                case "-2":
                    AddGrade(15); break;

                default:

                    if (float.TryParse(grade, out float result))
                    {
                        AddGrade(result);
                    }
                    else
                    {
                        //Console.WriteLine("string conversion impossible");
                        throw new Exception("string conversion impossible");
                    }
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
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
        //  6=> 100
        //  5=> 80
        //  4=> 60 
        //  3=> 40
        //  2=> 20
        //  1=> 0
        // + dodaje 5 punktow do oceny 
        // - odejmuje 5 punktow od oceny 

        //step 1 check if string contains + or - 
        //step 2 check what number is hidden 
        //step 3 




    }

    }
