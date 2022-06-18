// Заполнение массива с клавиатуры.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; // n - элементов (можно цифру указать);

for (int i = 0; i < array.Length; i++) // ввод массива с клавиатуры;
{
    Console.Write($"Введите элемент с индексом {i} -> ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++) // вывод массива;
{                                      // array.Length = n;
    Console.Write(array[i] + " ");
}