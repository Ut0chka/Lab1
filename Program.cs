Console.Write("Введите положительное целое число: ");

int value1 = 0;
try
{
    value1 = Convert.ToInt32(Console.ReadLine());
    
    if (value1 > 0)
    {
        
        Console.WriteLine($"Размерность массива: {value1}");
    }
    else
    {
        Console.WriteLine("Число не положительное!");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

int[] massive = new int[value1];
Random rand = new Random();
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = rand.Next(-100,100);
    Console.Write($"{massive[i]} \t");
}