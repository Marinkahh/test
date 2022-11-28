void Main()
{
    Console.Clear();
    Console.WriteLine("Ведите размер массива:");
    int s = int.Parse(Console.ReadLine());
    string[] array1 = new string[s];
    for(int i=0; i<s; i++)
    {
        Console.WriteLine("Ведите значение элемента номер" +(i+1) +"  :");
        array1[i]=Console.ReadLine();
    }
    string[] array2 = new string[array1.Length];
    СhoiceOfString(array1, array2);
    PrintArray(array1);
    PrintArray(array2);

}
 void СhoiceOfString(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Main();

