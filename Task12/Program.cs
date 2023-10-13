// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string line = Console.ReadLine();
    int number;
    number = int.Parse(line);
    return number;
}
int Day = ReadInt("Введите цифру от 1 до 7 => ");
if(Day >= 1 & Day <= 5)
{
    Console.WriteLine($"Этот день НЕ является выходным");

}
    
if(Day == 6 || Day == 7)
{
    Console.WriteLine($"Этот день является выходным");
}
if(Day < 1 || Day >= 8)
{
    Console.WriteLine($"Введена некорректная цифра");
}