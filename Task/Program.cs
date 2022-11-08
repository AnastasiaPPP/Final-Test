using static System.Console;

WriteLine("Введите слова через пробел");
string[] words = ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int length = NewArrayLength(words);


int NewArrayLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        string str = arr[i];
        int length = str.Length;
        if (length <= 3) count++;
    }
    return count;
}
