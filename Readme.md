 __Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.__

 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
 Для решения данной задачи нам понадобиться 3 метода и вывод самого массива в виде результата в консоль!

 **Первый метод**
 
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


Указываем разменрность массива, и вводим значения для массива типа стринг обозначая что значения могут быть равны NULL
для этого к переменным добавим операторы "?" заметки и оператор ! прощения null к выражению, чтобы принудить состояние к значению not-null

**Второй метод**

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

Второй метод необходим для вычисления значений введённых пользователем, при условии указаных в техническом задании!

**Третий метод**

    void PrintArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

Третий метод служит для вывода результата в консоль!

**Итог**

Для вывода конечного результата вычисления необходимо вызвать методы ссылаясь на них в коде программы:

    string[] trash = SecondArrayWithIF(CreateArray(size));
    PrintArray(trash);