class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
    }
    
}

class main
{
    public static void Main(string[] args)
    {
        HaloGeneric haloGen = new HaloGeneric();
        haloGen.SapaUser<string>("Filbert");

        DataGeneric<string> dataGen = new DataGeneric<string>("103022400112");
        dataGen.printData();
    }
}

class DataGeneric<T>
{
    public T Data { get; set; }
    
    public DataGeneric(T data)
    {
        Data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}

