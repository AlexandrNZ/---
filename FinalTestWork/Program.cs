string[] array = new string[] { "Hello", "World", "My", "Name", "Is", "Alexandr" };
Console.WriteLine("Исходный массив:");
foreach (string s in array)
    Console.Write(s + " ");
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
        count++;

string[] resultArray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) 
        resultArray[j++] = array[i]; 
Console.WriteLine("\n\nРезультирующий массив:");    
foreach (string s in resultArray)
    Console.Write(s + " ");

