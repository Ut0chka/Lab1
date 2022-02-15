Random rand = new Random();
Console.Write("Введите целое число: ");

try
{
    var value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{value1}*2 = {value1 * 2}");
    Console.WriteLine($"{value1}-20 = {value1 - 20}");
    if (value1 < 0)
        value1 = Math.Abs(value1);

    Console.WriteLine($"Массив с размерностью {value1}:");
    var massive = new int[value1];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = rand.Next(-100,100);
        Console.Write($"{massive[i]} \t");
    }
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

