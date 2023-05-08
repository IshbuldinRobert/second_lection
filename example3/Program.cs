int[] array = {1, 3, 45, 46, 56, 23, 56};

int n = array.Length;
int find = 56;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}