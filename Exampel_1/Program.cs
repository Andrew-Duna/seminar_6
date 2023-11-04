// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Считать число сконсоли 
int Prompt(string mes)
{
    System.Console.WriteLine(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
// Ввод массива
int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Ввеедие {i + 1}-й элемент:");
    }
    return array;
}
//Вывод массива
void PrintArray(int[] array)
{
    foreach (int item in array)// находим каждый элемент в массиве.
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
// Функция подсчета и положительных и отрицательных
int CountPositiveSign(int[] array, int sign = 1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * sign > 0)
        {
            count++;
        }
    }
    return count;
}
int[] array = InputArray(Prompt("Введите количество элимеентов: "));
System.Console.WriteLine($"Количесво чисеел >0: {CountPositiveSign(array)}");