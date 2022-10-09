int b = 1;
while (b == 1)
{
    Console.Clear();
    tekst();
    Console.Write("Выберите октаву: ");
    ConsoleKeyInfo a = Console.ReadKey();
    Console.Clear();
    if (a.Key == ConsoleKey.F2)
    {
        octavavtoraya();
    }
    if (a.Key == ConsoleKey.F3)
    {
        octavatretya();
    }
}
static void c2()
{
    Console.Beep(65, 100);
}
static void c21()
{
    Console.Beep(69, 100);
}
static void d2()
{
    Console.Beep(73, 100);
}
static void eb2()
{
    Console.Beep(77, 100);
}
static void e2()
{
    Console.Beep(82, 100);
}
static void f2()
{
    Console.Beep(87, 100);
}
static void f21()
{
    Console.Beep(92, 100);
}
static void g2()
{
    Console.Beep(98, 100);
}
static void g21()
{
    Console.Beep(103, 100);
}
static void a2()
{
    Console.Beep(110, 100);
}
static void bb2()
{
    Console.Beep(116, 100);
}
static void b2()
{
    Console.Beep(130, 100);
}
static void c3()
{
    Console.Beep(138, 100);
}
static void c31()
{
    Console.Beep(146, 100);
}
static void d3()
{
    Console.Beep(73, 100);
}
static void eb3()
{
    Console.Beep(155, 100);
}
static void e3()
{
    Console.Beep(164, 100);
}
static void f3()
{
    Console.Beep(174, 100);
}
static void f31()
{
    Console.Beep(185, 100);
}
static void g3()
{
    Console.Beep(196, 100);
}
static void g31()
{
    Console.Beep(207, 100);
}
static void a3()
{
    Console.Beep(220, 100);
}
static void bb3()
{
    Console.Beep(233, 100);
}
static void b3()
{
    Console.Beep(246, 100);
}
static void octavavtoraya()
{
    int ocenka = 5;
    while (ocenka == 5)
    {
        Console.Clear();
        Console.WriteLine("Вводите буквы, для того чтобы играть на пианино");
        ConsoleKeyInfo simvol = Console.ReadKey();
        int[] octava2 = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        if ((simvol.Key == ConsoleKey.Q) || (simvol.Key == ConsoleKey.W))
        {
            c2();
        }
        if ((simvol.Key == ConsoleKey.E) || (simvol.Key == ConsoleKey.R))
        {
            c21();
        }
        if ((simvol.Key == ConsoleKey.T) || (simvol.Key == ConsoleKey.Y))
        {
            d2();
        }
        if ((simvol.Key == ConsoleKey.U) || (simvol.Key == ConsoleKey.I))
        {
            eb2();
        }
        if ((simvol.Key == ConsoleKey.O) || (simvol.Key == ConsoleKey.P))
        {
            e2();
        }
        if ((simvol.Key == ConsoleKey.A) || (simvol.Key == ConsoleKey.S))
        {
            f2();
        }
        if ((simvol.Key == ConsoleKey.D) || (simvol.Key == ConsoleKey.F))
        {
            f21();
        }
        if ((simvol.Key == ConsoleKey.G) || (simvol.Key == ConsoleKey.H))
        {
            g2();
        }
        if ((simvol.Key == ConsoleKey.J) || (simvol.Key == ConsoleKey.K))
        {
            g21();
        }
        if ((simvol.Key == ConsoleKey.L) || (simvol.Key == ConsoleKey.Z))
        {
            a2();
        }
        if ((simvol.Key == ConsoleKey.X) || (simvol.Key == ConsoleKey.C))
        {
            bb2();
        }
        if ((simvol.Key == ConsoleKey.C) || (simvol.Key == ConsoleKey.V))
        {
            b2();
        }
        if (simvol.Key == ConsoleKey.Tab)
        {
            break;
        }
        if (simvol.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
}
static void octavatretya()
{
    int ocenka = 5;
    while (ocenka == 5)
    {
        Console.Clear();
        Console.WriteLine("Вводите буквы, для того чтобы играть на пианино");
        ConsoleKeyInfo simvol = Console.ReadKey();
        int[] octava3 = { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
        if ((simvol.Key == ConsoleKey.Q) || (simvol.Key == ConsoleKey.W))
        {
            c3();
        }
        if ((simvol.Key == ConsoleKey.E) || (simvol.Key == ConsoleKey.R))
        {
            c31();
        }
        if ((simvol.Key == ConsoleKey.T) || (simvol.Key == ConsoleKey.Y))
        {
            d3();
        }
        if ((simvol.Key == ConsoleKey.U) || (simvol.Key == ConsoleKey.I))
        {
            eb3();
        }
        if ((simvol.Key == ConsoleKey.O) || (simvol.Key == ConsoleKey.P))
        {
            e3();
        }
        if ((simvol.Key == ConsoleKey.A) || (simvol.Key == ConsoleKey.S))
        {
            f3();
        }
        if ((simvol.Key == ConsoleKey.D) || (simvol.Key == ConsoleKey.F))
        {
            f31();
        }
        if ((simvol.Key == ConsoleKey.G) || (simvol.Key == ConsoleKey.H))
        {
            g3();
        }
        if ((simvol.Key == ConsoleKey.J) || (simvol.Key == ConsoleKey.K))
        {
            g31();
        }
        if ((simvol.Key == ConsoleKey.L) || (simvol.Key == ConsoleKey.Z))
        {
            a3();
        }
        if ((simvol.Key == ConsoleKey.X) || (simvol.Key == ConsoleKey.C))
        {
            bb3();
        }
        if ((simvol.Key == ConsoleKey.C) || (simvol.Key == ConsoleKey.V))
        {
            b3();
        }
        if (simvol.Key == ConsoleKey.Tab)
        {
            break;
        }
        if (simvol.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
}
static void tekst()
{
    Console.WriteLine("F2 - 2 октава");
    Console.WriteLine("F3 - 3 октава");
/*  Console.WriteLine("F4 - 4 октава");
    Console.WriteLine("F5 - 5 октава");
    Console.WriteLine("F6 - 6 октава");
    Console.WriteLine("F7 - 7 октава");
    Console.WriteLine("F8 - 8 октава");*/
}