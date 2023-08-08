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



