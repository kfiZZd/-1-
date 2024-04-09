namespace ЛабораторнаяРаб1_Синявин_Ворфоломеев
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[,] m = new int[5, 5];
           bool Simentrichnost = false;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Введите элемент матрицы - a[" + i + "," + j + "]:");
                    m[i, j] = int.Parse(Console.ReadLine());

                    if (m[i, j] == m[j, i])
                        Simentrichnost = true;
                    else
                        Simentrichnost = false;
                }


                    if (Simentrichnost == true)
                        Console.WriteLine("Симметрична");
                    else
                        Console.WriteLine("Не симметрична");
                
        }
    }
}
