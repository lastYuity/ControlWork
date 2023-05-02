Console.Write("Укажите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());


string[] CreateArray(int size)
{
    string[] array1 = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите значения для массива: ");
        string? pos = Console.ReadLine();
        array1[i] = pos!;
    }
          return array1;
}
string[] SecondArrayWithIF(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//SecondArrayWithIF(CreateArray(size));
string[] trash = SecondArrayWithIF(CreateArray(size));
PrintArray(trash);

