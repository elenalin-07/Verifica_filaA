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
int[,] vm = new int[2, 12];
popolaVendite(vm);
stampa(vm);

