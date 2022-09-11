int[,] Create2dArray(int rows, int columns, int min, int max)
{
int[,] newArray = new int[rows,columns];

int stepY = 0;
int size = 0;

for(int i=stepY; i < rows; i++)
{
    size=columns-stepY-1;
    for(int j=0; j <= size; j++ )
    {
        if(newArray[stepY,j]==0)
        newArray[stepY,j] = new Random().Next(min,max);
    }
    for(int j=0;j<size;j++)
    {
        if(newArray[j,stepY]==0)
        newArray[j,size] = new Random().Next(min,max);    
    }
    for(int j=size;j>=0;j--)
    {
        if(newArray[size,j]==0)
        newArray[size,j] = new Random().Next(min,max);    
    }
    for(int j=size;j>=0;j--)
    {
        if(newArray[j,stepY]==0)
        newArray[j,stepY] = new Random().Next(min,max);    
    }
    stepY++;
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

Console.Write("Введите число столбцов для квадратного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте число строк для квадратного массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальную границу для элементов массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную границу для элементов массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2dArray(m,n,min,max);
Show2dArray(array);
//int[,] newArray = FindLargeElement(array);
//Show2dArray(newArray);