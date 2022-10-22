// В двумерном массиве заменить элементы, у которых 
//оба индекса чётные на их квадраты
void FillArray(int[,] matr )
{
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = new Random().Next(-10,10);
     }
    }

}
 void PrintArrye(int[,] matr)
 {
    for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
        Console.Write($"{matr[i, j]} ");
     }
     Console.WriteLine();
 }
 }

void ChengeElement(int[,] matr)
{
    for(int i = 0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)

        if(i%2 == 0 && j%2==0)
        {
            matr[i, j] = matr[i, j]*matr[i, j];
        }
    }
}

Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m= int.Parse(Console.ReadLine());
int[,] mass = new int[n,m];

FillArray(mass);
PrintArrye(mass);
Console.WriteLine("");
ChengeElement(mass);
PrintArrye(mass);

