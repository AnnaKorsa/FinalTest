void InputArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"Введите {i + 1} элемент массива: ");
		array[i] = Console.ReadLine()!;
	}
}
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 0)
{
	Console.Write("Вы ошиблись!\nВведите количество элементов массива больше 0: ");
	n = Convert.ToInt32(Console.ReadLine());
}
string[] array = new string[n];
InputArray(array);
Console.WriteLine();
Console.Write($"Первоначальный массив: ");