/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length < 5 || numberText.Length > 5){
  Console.WriteLine("Неверное число, необходимо ввести ПЯТИЗНАЧНОЕ");
}

else if (numberText[0]==numberText[4] || numberText[1]==numberText[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");




