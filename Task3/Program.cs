// на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
string s="q";
do {
Console.Clear();
Console.WriteLine("Для выхода нажмите q");
Console.Write("Введите число: ");
s = Console.ReadLine();
if (s =="q") break; 
int a = Convert.ToInt32(s);

if ( (a%2) == 0 ) 
    Console.WriteLine("Число "+a+" четное");
else 
    Console.WriteLine("Число "+a+" нечетное");
    
s = Console.ReadLine();
} while ( s !="q" );