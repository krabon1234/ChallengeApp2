using System.Threading.Tasks.Sources;

namespace ChallengeApp2
{
    public class Employee
    {
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
           
        }

        public List<int> score = new List<int>();

        public string Name { get; private set; }
        public string Surname { get; private set;}
        public int Age { get; private set;}


        public void AddPoints(int point)
        {
            score.Add(point);
        }

        public int Result 
        {
            get
            {
                return score.Sum();
            }
        }
    }



}
