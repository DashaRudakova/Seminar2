// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Ввод данных
Console.Write("Введите число:   ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);

// Вывод ответа на экран
if (anyNumberText.Length > 2)
{
  Console.WriteLine("Третья цифра введенного числа: " + anyNumberText[2]);
}
else
{
  Console.WriteLine("Упс, третьей цифры в введенном числе НЕТ");
}