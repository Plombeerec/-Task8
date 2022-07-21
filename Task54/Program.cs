//  Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandomArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i <rows; i++)
    {
        for(int j = 0; j <columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max+1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}


int[,] SortArrayInstring(int[,] array)
{
    
    int a = 0;
    int b = 0;
    
    for(int i = 0; i < array.GetLength(0); i++ )
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(b = 0; b<array.GetLength(1);b++)
            {
                if(array[i,j] < array[i,b])
                {
                    int temp= array[i,b];
                    array[i,b] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++ )
    { 
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(a = 0; a < array.GetLength(0); a++)
            {    
                if(array[i,j] < array[a,j])
                {
                    int temp= array[a,j];
                    array[a,j] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        for( int j = 0; j < array.GetLength(1); j++)
        {
            for(b = array.GetLength(1)-1; b >=0 ; b--)
            {    
                for(a = 0; a < array.GetLength(0); a++)
                {   if(array[a,j] > array[i,b])
                    {
                        int temp= array[i,b];
                        array[i,b] = array[a,j];
                        array[a,j] = temp;
                    }
                }
            }
        }
    }
    
    
    return array;   
}
Console.WriteLine("input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of columns");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandomArray(m , n, 1, 9);

Show2dArray(myArray);
Console.WriteLine();
SortArrayInstring(myArray);
Show2dArray(myArray);




