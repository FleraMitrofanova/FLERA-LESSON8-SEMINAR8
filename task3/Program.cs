int[,] Create2dArray(int rows, int columns, int min, int max)
{
int[,] newArray = new int[rows,columns];

for(int i=0; i < rows; i++)
{
    for(int j=0; j < columns; j++ )
    {
        newArray[i,j] = new Random().Next(min,max);
    }
}
return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }           
        Console.WriteLine();
    }
}


int[,] multiplicationArray(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0),array1.GetLength(1)];

    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j =0; j< array.GetLength(1);j++)
        {
           array[i,j]=array1[i,j]*array2[i,j];
        }
    }
return array;
}


Console.Write("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте число строк");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальную границу для элементов массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную границу для элементов массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2dArray(m,n,min,max);
int[,] array2 = Create2dArray(m,n,min,max);
Console.WriteLine("Первый перемножаемый массив: ");
Show2dArray(array1);
Console.WriteLine("Второй перемножаемый массив: ");
Show2dArray(array2);
int[,] newArray = multiplicationArray(array1,array2);
Console.WriteLine("Результирующий массив: "); 
Show2dArray(newArray);