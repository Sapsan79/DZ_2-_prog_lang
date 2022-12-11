/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

//Console.WriteLine("Введите число не менее трёхзначного: ");
//string NumberText = Console.ReadLine();
//if (NumberText.Length > 2)
//{
//    Console.WriteLine("третья цифра: " + NumberText[2]);
//    }
//else
//{
//    Console.WriteLine("третьей цифры нет");
//}
Console.Write("Введите значение: ");
int i = int.Parse(Console.ReadLine());
if (Math.Abs(i) <= 99)//Значение по модулю
{
    Console.WriteLine("нет третьего символа: ");
}
else
{
    string s1 = i.ToString();

    if (i > 0)
        Console.WriteLine(s1[2]);

    else
        Console.WriteLine(s1[3]);

}