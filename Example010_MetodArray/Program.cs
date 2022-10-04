int[] array = {1,21,3,45,5,21,7,45};
int n = array.Length;
int find =21;
int index =0;
while (index<n)
{
    if (array[index] ==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}