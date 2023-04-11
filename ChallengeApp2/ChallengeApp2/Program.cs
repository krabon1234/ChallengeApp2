// See https://aka.ms/new-console-template for more information
/*
 Potrzebujemy elektronicznego systemu oceny naszych pracowników,
aby odczytac wyniki poszczególnych osób, a następnie obliczyć statystyki z 
wyników. Oceny są wprowadzane jako liczby zmiennoprzecinkowe od 0 do 100, 
a te statystyki powinny pokazywac nam ocenę najwyższą, najniższą i średnią
 */

string imie = "Aneta";
string sex = "K";
int wiek = 25;


if (sex == "K" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "M" && wiek < 18)
{
    Console.WriteLine("Niepelnoletni mezczyna");
}
    


