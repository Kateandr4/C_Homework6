// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] matr )
{
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = i+j;
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

Console.WriteLine("Введите n");
int n= int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m= int.Parse(Console.ReadLine());
int[,] mass = new int[n,m];

FillArray(mass);
PrintArrye(mass);

