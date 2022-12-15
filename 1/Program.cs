Console.Clear();
int cont = 1;
int biggerthanzero = 0;
while (cont == 1)
{
    Console.WriteLine("Введите числа");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        biggerthanzero= biggerthanzero + 1;
    }
    Console.WriteLine("Ещё одно? Да = 1, Нет = 0");
    cont = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Чисел больше 0: {biggerthanzero}");