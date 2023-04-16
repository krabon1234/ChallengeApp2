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


using  ChallengeApp2;



Employee emp1 = new Employee("Klaudia", "Iksinska");
emp1.AddPoints(10);
emp1.AddPoints(2);
emp1.AddPoints(3);
emp1.AddPoints(6);
emp1.AddPoints(3);

Employee emp2 = new Employee("Franek", "Nowak");
emp2.AddPoints(5);
emp2.AddPoints(6);
emp2.AddPoints(6);
emp2.AddPoints(6);
emp2.AddPoints(6);


Employee emp3 = new Employee("Zofia", "Kowalska");

emp3.AddPoints(3);
emp3.AddPoints(8);
emp3.AddPoints(7);
emp3.AddPoints(1);
emp3.AddPoints(4);

var highestGrades = emp1.Result;

if (emp2.Result > highestGrades) highestGrades= emp2.Result;
if (emp3.Result > highestGrades) highestGrades= emp3.Result;



List<Employee> emps = new List<Employee>()
{
    emp1, emp2, emp3 // wpisanie do kontenera listy 
};

int highestGrade = -1;
Employee bestEmployee = null;

foreach(var emp in emps)
{
    if (emp.Result > highestGrade)
    {
        highestGrade = emp.Result;
        bestEmployee = emp;
    } 
}
Console.WriteLine("Najwyzsza suma ocen nalezy do \n" );
Console.WriteLine("Imie: " + bestEmployee.Name + "\n" +"Nazwisko:"+ bestEmployee.Surname + "\n");
Console.WriteLine("i wynosi: " + highestGrade);












