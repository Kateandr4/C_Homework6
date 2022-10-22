// Показать двумерный массив размером m×n 
//заполненный вещественными числами
void FillArray(double[,] matr )
{
    Random random = new Random();
 for ( int i=0; i<matr.GetLength(0); i++)
 {
     for ( int j=0; j<matr.GetLength(1); j++)
     {
       matr[i, j] = random.NextDouble() * (40 - 20);
     }
    }

}
 void PrintArrye(double[,] matr)
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
double[,] mass = new double[n,m];

FillArray(mass);
PrintArrye(mass);

