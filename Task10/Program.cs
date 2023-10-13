// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string line = Console.ReadLine();
    int number;
    number = int.Parse(line);
    return number;
}
int InputNumber = ReadInt("Введите трёхзначное число => ");
if (InputNumber > 99 && InputNumber < 1000)
{
int temp = InputNumber / 10;
int Digital = temp % 10 ;
Console.WriteLine($"Вторая цифра вашего числа {Digital}");

}
else
{
    Console.WriteLine ($"Вы ввели некорректное число: {InputNumber} не является трёхзначным числом");
}
