/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Задайте координату B1 для определения первой прямой :");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координату K1 для определения первой прямой :");
int K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координату B2 для определения второй прямой :");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координату K2 для определения второй прямой :");
int K2 = Convert.ToInt32(Console.ReadLine());

void printArray(double[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

double[] getCooordinte(int B1, int K1, int B2, int K2)
{
    double[] Result = new double[2];
    Result[0] = (B2 - B1) / (K1 - K2);
    Console.WriteLine(Result[0]);
    Result[1] = K1 * Result[0]+ B1;
    return Result; 
}

double[] Coordinat = getCooordinte(B1,K1,B2,K2);
printArray(Coordinat);