// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int[] numberN = {1,6,5,7,1};
string A = string.Join("",numberN);
Console.WriteLine($"Задано число: {A}");

if (numberN[0] == numberN[4] && numberN[1] == numberN[3])
{
    Console.WriteLine($"Заданное число {A} является палиндромом");
}
else
{
    Console.WriteLine($"Заданное число -> {A} - не является палиндромом");
}


//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
int[] pointA = new int[] {4,3,4};
int[] pointB = new int[] {2,8,3};


Console.WriteLine($"Квадрат разности Х => {Math.Pow(pointA[0] - pointB[0], 2)}");

Console.WriteLine($"Квадрат разности Y => {Math.Pow(pointA[1] - pointB[1], 2)}");

Console.WriteLine($"Квадрат разности Z => {Math.Pow(pointA[2] - pointB[2], 2)}");

Console.WriteLine($"Сумма квадратов X,Y,Z => {Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2)}");

Console.WriteLine($"Расстояние между точками А и В = {Math.Sqrt((Math.Pow(pointA[0] - pointB[0], 2)) + (Math.Pow(pointA[1] - pointB[1], 2)) + (Math.Pow(pointA[2] - pointB[2], 2)))}");
*/


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125

/*
Random rand = new Random();
int number = rand.Next(1,10);
int step = 1;
Console.WriteLine($"Задано число: {number}");
while (step <= number)
{
    Console.WriteLine($"{step} в кубе => {Math.Pow(step, 3)}");
    step ++;
}
*/
