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
//using System.Threading.Tasks.Sources;




Console.WriteLine("Witamy w programie XYZ do oceny pracownikow ");
Console.WriteLine("###########################################");


var EmpInFile = new EmployeeInFile("Franek", "Gorczynski");

EmpInFile.AddGrade(10);
EmpInFile.AddGrade(20);
EmpInFile.AddGrade(30);


var statistics = EmpInFile.GetStatistics();
Console.WriteLine($"Wartosc minimalna:  { statistics.Min}      ");
Console.WriteLine($"Wartosc maksymalna: { statistics.Max}      ");
Console.WriteLine($"Wartosc srednia:    { statistics.Average}  ");

//try
//{
//    Employee emp = null;
//    var name = emp.Name;
//}
//catch(Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}
//finally
//{
//    Console.WriteLine("Finally here");
//}



//EmployeeInMemory empx = new EmployeeInMemory("franek", "górczyński");
//empx.SayHello();


//string input;

//do
//{
//    Console.writeline("podaj ocene pracownika: ");
//    input = Console.ReadLine();

   
//    try
//    {
//        employeesupervisor.addgrade(input);
//    }
//    catch(exception exc)
//    {
//        console.writeline(exc.message);
//    }

//}
//while(input != "q");


//var statistics = employeesupervisor.getstatistics();
//console.writeline($"min: {statistics.min} max: {statistics.max} , average: {statistics.average}");


//static void Main(string[] args)
//{
//}














