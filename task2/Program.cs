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



int[,] FindLargeSum(int[,] array)
{
    int result =0;
    int tmp = 0;
    int sum = 0;

    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j =0; j< array.GetLength(1);j++)
        {
            sum += array[i,j];
        }
        //Console.WriteLine(sum);
        if(sum>tmp)
        {
        tmp=sum;
        sum=0;
        result=i+1;
        }
        //Console.WriteLine();
    }
    Console.WriteLine("Самая большая сумма элементов расположена в строке массива :" + result);
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

int[,] array = Create2dArray(m,n,min,max);
Show2dArray(array);
int[,] newArray = FindLargeSum(array);