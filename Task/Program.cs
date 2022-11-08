using static System.Console;

WriteLine("Введите слова через пробел");
string[] words = ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
