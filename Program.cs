await Brojac();
Console.WriteLine("Pozvao prvi");
Brojac();
Console.WriteLine("Pozvao drugi");
Brojac();
Console.WriteLine("Pozvao ih sve");

async Task Brojac()
{
    int broj = 10;
    Random r = new();
    while (broj > 0)
    {
        await Task.Delay(r.Next(2000));
        Console.WriteLine(broj);
        broj--;
    }
    Console.WriteLine("======FIN========");
}