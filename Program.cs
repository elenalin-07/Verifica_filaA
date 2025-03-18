Random r = new Random();
void popolaVendite(int[,] vm)
{
    for (int i = 0; i < vm.GetLength(1); i++)
    {
        vm[0, i] = r.Next(100, 1001);  
    }
}

int[,] vm = new int[2,12];
popolaVendite(vm);