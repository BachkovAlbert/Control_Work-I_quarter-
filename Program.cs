Console.Clear();

string[] CreateStringArray(int size)
{
    string[] elements = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        elements[i] = Console.ReadLine();
    }
    return elements;
}

string[] ThreeSymbolsAndLess(string[] array)
{
    string[] result = new string[array.Length];
    
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= 3) result[i] = array[i];
        else result[i] = string.Empty; 
        
    return result;
}

void ShowArray(string[] array)
{
    Console.Write("[");

    for(int i = 0; i < array.Length; i++)
        if(array[i] == string.Empty) Console.Write(array[i]);
        else  Console.Write($"\"{array[i]}\" ");
        
    Console.Write("]");
}

Console.Write("Input the number of array elements(integer positive number): ");
int size = Convert.ToInt32(Console.ReadLine());

string[] ArrayElements = CreateStringArray(size);

ShowArray(ThreeSymbolsAndLess(ArrayElements));