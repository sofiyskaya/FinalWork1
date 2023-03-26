// method searches the strings in the array, that are equal to or less than 3 symbols
void SymArr(string [] FirstArr, string [] FinalArr, int count)
{
    int result = 0;
    for(int i = 0; i < FirstArr.Length; i++)
    {
        if(FirstArr[i].Length <= count)
        {
            FinalArr[result] = FirstArr[i];
            result++;
        }
    }
}

// method prints 1D array into console
void Print1DArr(string[] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

string [] FirstArr = new string[5] {"Hi", "456", "element", ":)", "FinalWork"};
string [] FinalArr = new string[FirstArr.Length];

SymArr(FirstArr, FinalArr, 3);
Print1DArr(FinalArr);