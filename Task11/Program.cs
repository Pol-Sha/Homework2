// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string line = Console.ReadLine();
    int number;
    number = int.Parse(line);
    return number;
}
int InputNumber = ReadInt("Введите число => ");
if (InputNumber > 0 && InputNumber < 100)
{
    Console.WriteLine($"У введенного числа {InputNumber} третьей цифры нет");
}

else if (InputNumber > 99 && InputNumber < 1000)
{
    int Digital = InputNumber % 10;
    Console.WriteLine($"Число {InputNumber} имеет третью цифру = {Digital}");
}
 else if (InputNumber > 999 && InputNumber < 10000)
{
 int temp = InputNumber / 10;
 int Digital = temp % 10;
Console.WriteLine($"Число {InputNumber} имеет третью цифру = {Digital}");

 }


