//  принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>=b) {
    if (c > a)
        Console.WriteLine("Самое большое число "+ c);
    else
        Console.WriteLine("Самое большое число "+ a); 
}
else {
    if (c > b)
        Console.WriteLine("Самое большое число "+ c);
    else
        Console.WriteLine("Самое большое число "+ b); 
}
