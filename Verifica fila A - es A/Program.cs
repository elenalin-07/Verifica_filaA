Random r = new Random();
void popolaVendite(int[,] vm)
{
    for (int i = 0; i < vm.GetLength (1); i++)
    {
        vm[0, i] = r.Next(100,1001);
    }
}

void stampa(int[,] vm)
{
    for(int i = 0;i < vm.GetLength(0); i++)
    {
        for(int j = 0;j < vm.GetLength(1); j++)
        {
            Console.Write($"\t{vm[i, j]}");
        }
        Console.WriteLine();
    }
}

void totali_cumulativi(int[,] vm)
{
    vm[1, 0] = vm[0, 0];
    for (int i = 1; i < vm.GetLength(1); i++)
    {
            vm[1, i] = vm[1, i - 1] + vm[0, i];
    }
}

int trovaMese(int[,] vm, int v)
{
    for(int i = 0; i < vm.GetLength(1); i++)
    {
        if(vm[1, i] >= v)
        {
            return i + 1;
        }
    }
    return 0;
}
// es A
Console.WriteLine("es A");
int[,] vm = new int[2, 12];
popolaVendite(vm);
stampa(vm);
Console.WriteLine();

// es B
Console.WriteLine("es B");
totali_cumulativi(vm);
stampa(vm);

Console.WriteLine("inserisci un valore di vendite");
int v = Int32.Parse(Console.ReadLine());
Console.WriteLine($"mese: {trovaMese(vm, v)}");