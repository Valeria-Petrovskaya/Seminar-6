Console.Clear();
Console.WriteLine("Первая прямая  y1 = k1 * x + b1, k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первая прямая  y1 = k1 * x + b1, b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая прямая  y2 = k2 * x + b2, k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая прямая  y2 = k2 * x + b2, b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

    if (k1 == k2 && b1 ==b2)
    {
        Console.WriteLine("Это не разные прямые");
    } else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    } else{
       // Console.WriteLine("b2-b1 = " + (b2-b1));
        //Console.WriteLine("k1-k2 = " + (k1-k2));
        int coef1 = b2-b1;
        int coef2 = k1-k2;
        //Console.WriteLine("coef1 = " + coef1);
       // Console.WriteLine("coef2 = " + coef2);
        float xcoord = coef1/coef2;
        //float xcoord = (-4 / 40)*10000;
       // Console.WriteLine("x = " + xcoord);
        int ycoord = (k1*coef1)/coef2 + b1;
        Console.WriteLine($"Точка пересечения: x={xcoord}, y={ycoord}");
    }