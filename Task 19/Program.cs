// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number > 9999 && number < 100000)
{
bool palindrome = Palindrome(number);
string result = palindrome == true
            ? "Да, число является палиндромом"
            : "Нет, число не является палиндромом";

Console.WriteLine(result);
}

else
{
   Console.WriteLine("Введено некорректное число"); 
}

bool Palindrome(int num)
{
    int number1 = num / 10000;
    int number2 = num / 1000 % 10;
    int number3 = num / 10 % 10;
    int number4 = num % 10;

    if (number1 == number4 && number2 == number3) return true;
    return false;
}