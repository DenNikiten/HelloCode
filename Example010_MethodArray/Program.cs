int[] array = {1, 20, 315, 689, 4, 52, 689, 714, 8};

int n = array.Length;
int find = 689;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
        index++;
}
