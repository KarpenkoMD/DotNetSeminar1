// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

do {
Console.WriteLine("Для выходы нажмите q");
Console.Write("Введите число: ");
string s = Console.ReadLine();
if (s =="q") break; 
int N = Convert.ToInt32(s);

if (N <= 1 ) {
    Console.WriteLine("Вы ввели число меньше либо равно 1");
    break; 
}
else {
    Console.Write("Четные числа от 1 до "+N+": ");
    for (int i = 2; i <= N; i++)
         if ( (i%2) != 0 ) 
             Console.Write(N+", ");
}
} while ( s !="q" );