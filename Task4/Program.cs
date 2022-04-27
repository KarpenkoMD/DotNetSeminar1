// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
string s="q";

do {
Console.Clear();
Console.WriteLine("Для выхода нажмите q");
Console.Write("Введите число N: ");
s = Console.ReadLine();
if (s =="q") break; 
int N = Convert.ToInt32(s);

if (N <= 1 ) {
    Console.WriteLine("Вы ввели число меньше либо равно 1");
    break; 
}
else {
    Console.Write("Четные числа от 1 до "+N+": ");
    for (int i = 2; i <= N; i+=2)
        // if ( (i%2) == 0 ) 
             Console.Write(i+", ");
}
s = Console.ReadLine();
} while ( s !="q" );