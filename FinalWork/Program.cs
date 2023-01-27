string[]NewArrayString (string[]arrString)
{
    int lengthArray = arrString.Length;
    int lengthElement;
    int count = 0;
   
    for(int i = 0; i < lengthArray; i++)
    {
        lengthElement = arrString[i].Length;
        if(lengthElement < 4) count++;
    }

    string [] result = new string [count];
    int j = 0;

    for(int i = 0; i < lengthArray; i++)
    {   
        lengthElement = arrString[i].Length;
        if(lengthElement < 4)
        {
            result[j] = arrString[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string [] array)
{
    //int count = array.Length;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine();
string [] arrString = {"text", "oh", "cat", "mouse", "ex", "mom5", "wow", "cool"};
PrintArray (arrString);
Console.WriteLine();
string [] newArrString = NewArrayString(arrString);
PrintArray (newArrString);
Console.WriteLine();
