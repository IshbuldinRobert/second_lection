void FillArr(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArr(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 666;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] arr = new int[10];// создай массив с 10-ю элементаами

FillArr(arr);

// arr[4] = 4;
//arr[5] = 4;

PrintArr(arr);
Console.WriteLine();

int pos = IndexOf(arr, 4);
Console.WriteLine(pos);