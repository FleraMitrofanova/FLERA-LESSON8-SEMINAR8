int[,,] Create3dArray(int rows, int columns, int edge, int min, int max)
{
int[,,] newArray = new int[rows,columns,edge];

int size=rows*columns*edge;
int[] tmpArray = new int[size];
int n=0;

while(n<size)
{
    int randRes=new Random().Next(min,max);
    for(int j=n;j>=0;--j)
    {
        if(tmpArray[j]== randRes) break;
        else if (j==0) 
        {
        tmpArray[n]=randRes;
        ++n;
        }
    }
}
// Отладка того, что эелементы во вспомогательном массиве уникальный
//Console.WriteLine("[{0}]", string.Join(", ", tmpArray));


int rotate=0;
for(int i=0; i < rows; i++)
{
    for(int j=0; j < columns; j++ )
    {
        for(int k = 0; k < edge; k++)
        {
                newArray[i,j,k]=tmpArray[rotate];
                rotate++;
        }
    }
}
return newArray;
}

void Show3dArray(int[,,] array)
{
    for(int i=0; i < array.GetLength(0); i++)
    {
        //Console.WriteLine(" Индекс i "+ i+" ");
        for (int j=0; j< array.GetLength(1); j++)
        {
        Console.Write("Индекс i "+i+ " Индекс j "+ j+" ");
          for (int k = 0; k < array.GetLength(2);k++)
          {
            Console.Write(" Индекс k "+ k+" ");
            Console.Write(" Значение элемента: "+array[i,j,k]+" ");
          }      
            Console.WriteLine();
        }           
        Console.WriteLine();
    }
}


Console.Write("Введите число столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте число строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введте число строк ребер");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальную границу для элементов массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную границу для элементов массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] array = Create3dArray(m,n,k,min,max);
Show3dArray(array);
Console.WriteLine();
