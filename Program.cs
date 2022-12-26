/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length < 5 || numberText.Length > 5)
{
    Console.WriteLine("Неверное число, необходимо ввести ПЯТИЗНАЧНОЕ");
}

else if (numberText[0] == numberText[4] || numberText[1] == numberText[3])
{
    Console.WriteLine($"Ваше число: {number} - палиндром.");
}
else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

System.Console.Write("Введите коррдинату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коррдинату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите коордианту z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt((x1 - x2) * (x1 - x2) 
                         + (y1 - y2) * (y1 - y2) 
                         + (z1 - z2) * (z1 - z2));
System.Console.WriteLine($"Расстояние между двумя точками: {result}");






