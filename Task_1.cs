//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Ввудите число a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввудите число b = ");
double b = Convert.ToDouble(Console.ReadLine());
if (a > b){
    Console.WriteLine("\nMax = " + a);
}
else{
    if (b > a){
        Console.WriteLine("\nMax = " + b);
    }
    else{
    if (a == b){
        Console.WriteLine("\nЧисла равны");
    }
}
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Ввудите число a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввудите число b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввудите число c = ");
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if (b > max){
    max = b;
}
if (c > max){
    max = c;
}
Console.Write("Max = " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число a = ");
double a = Convert.ToDouble(Console.ReadLine());
if ((a % 2) == 0){
    Console.WriteLine("\nЧётное");
}
else{
    Console.WriteLine("\nНечётное");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целочисленное значение переменной N = ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < (N + 1)){
    if ((i % 2) == 0){
        Console.Write(i + "   ");
    }
    i++;
}
