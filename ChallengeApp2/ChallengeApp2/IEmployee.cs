
namespace ChallengeApp2
{

    //kontrakt - klasa która implementuje interfejs
    //musi zdefiniować kazdy element 
    // interfejs zawiera listę elementów jakie muszą być zaimplementowane 
    //przez klasę
    public interface IEmployee
    {
         string Name { get; }
        string Surname { get; }

        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(char grade);
    }
}
