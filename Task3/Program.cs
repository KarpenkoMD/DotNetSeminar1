// на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

do {
Console.WriteLine("Для выходы нажмите q");
Console.Write("Введите число: ");
string s = Console.ReadLine();
if (s =="q") break; 
int a = Convert.ToInt32(s);

if ( (a%2) != 0 ) 
    Console.WriteLine("Число "+a+" четное");
else 
    Console.WriteLine("Число "+a+" нечетное");

} while ( s !="q" );