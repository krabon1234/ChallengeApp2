
namespace ChallengeApp2
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }



        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadsGradesFromFile();
            var result =this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadsGradesFromFile()
        { 
         var grades = new List<float>();

            if (File.Exists(fileName))
            {
                //var grades = new List<float>();
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }     
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> list)
        {
            var statistics = new Statistics();

            statistics.Max      =  float.MinValue;
            statistics.Min      =  float.MaxValue;
            statistics.Average  =  0; 
            

            foreach(var grade in list)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;    

            }
             statistics.Average /= list.Count;  

            return statistics;
        }

    }
}
