// See http+-s://aka.ms/new-console-template for more information+--+
/*
 Potrzebujemy elektronicznego systemu oceny naszych pracowników,
aby odczytac wyniki poszczególnych osób, a następnie obliczyć statystyki z 
wyników. Oceny są wprowadzane jako liczby zmiennoprzecinkowe od 0 do 100, 
a te statystyki powinny pokazywac nam ocenę najwyższą, najniższą i średnią
 */

int number = 289320 ;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int[] sum = new int[10];

    foreach(char c in letters)
    {
        if (c == '0')   sum[0]++;
        if (c == '1')   sum[1]++;
        if (c == '2')   sum[2]++;
        if (c == '3')   sum[3]++;
        if (c == '4')   sum[4]++;
        if (c == '5')   sum[5]++;
        if (c == '6')   sum[6]++;
        if (c == '7')   sum[7]++;
        if (c == '8')   sum[8]++;
        if (c == '9')   sum[9]++;


        //char ctemp =Convert.ToCha(i);
        //if (c == ctemp) sum[i]++; 
    }

for(int i=0 ;i<sum.Length; i++)
{
    Console.WriteLine(i + "=>"+ sum[i]);
}
    
