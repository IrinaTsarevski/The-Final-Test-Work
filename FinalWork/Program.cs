string[]NewArrayString (string[]arrString)
{
    int count = 0;
   
    for(int i = 0; i < arrString.Length; i++)
        if(arrString[i].Length < 4) count++;
    
    string [] result = new string [count];

    for(int i = 0, j = 0; i < arrString.Length; i++)
        if(arrString[i].Length < 4)
        {
            result[j] = arrString[i];
            j++;
        }
    return result;
}

void PrintArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}  ");
    Console.WriteLine();
    Console.WriteLine();
}

Console.WriteLine();
string [] arrString = {"text", "dog", "Deutschland", "oh*", "cat", "mouse", "ex", "mom5", "wow", "cool"};
PrintArray (arrString);
string [] newArrString = NewArrayString(arrString);
PrintArray (newArrString);