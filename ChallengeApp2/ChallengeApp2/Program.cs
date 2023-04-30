// See http+-s://aka.ms/new-console-template for more information+--+
/*
 Potrzebujemy elektronicznego systemu oceny naszych pracowników,
aby odczytac wyniki poszczególnych osób, a następnie obliczyć statystyki z 
wyników. Oceny są wprowadzane jako liczby zmiennoprzecinkowe od 0 do 100, 
a te statystyki powinny pokazywac nam ocenę najwyższą, najniższą i średnią
 */

/*
 1. Stwórz klase Employee, w której przechowasz imie,
nazwisko, wiek, oraz punkty pracownika w postaci liczb 
całkowitych

2. Stwórz 3 pracowników i kaźdemu przydziel po 5 ocen z 
zakresu od 1 do 10

3. Napisz program, kóry wyszuka pracownika z najwyższą 
liczbą ocen a nastepnie wyswietli jego dane oraz wynik 
 */

using ChallengeApp2;
using System.Threading.Tasks.Sources;




Console.WriteLine("Witamy w programie XYZ do oceny pracownikow ");
Console.WriteLine("###########################################");
Console.WriteLine();

var employee = new Employee();

string input;

do
{
    Console.WriteLine("Podaj ocene pracownika: ");
    input = Console.ReadLine();
    employee.AddGrade(input);
}
while(input != "q");

//var input = Console.ReadLine();

var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min} Max: {statistics.Max} , Average: {statistics.Average}");


//static void Main(string[] args)
//{
//}














