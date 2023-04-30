void InputArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"Введите {i + 1} элемент массива: ");
		array[i] = Console.ReadLine()!;
	}
}
int FindShortSymbol(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
			count++;
	}
	return count;
}
string[] ArrayShortSymbol(string[] array, int count)
{
	string[] rezult = new string[count];
	count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			rezult[count] = array[i];
			count++;
		}
	}
	return rezult;
}
void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
		Console.Write($"{array[i]}, ");
	Console.WriteLine($"{array[array.Length - 1]}]");
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
PrintArray(array);
int count = FindShortSymbol(array); 
if (count == 0) 
Console.WriteLine("Конечный массив: []\nВ массиве нет элементов, длина которых меньше, либо равна 3");
else
{
	string [] rezultArray = ArrayShortSymbol(array, count);
	Console.Write("Конечный массив: ");
	PrintArray(rezultArray);
}
