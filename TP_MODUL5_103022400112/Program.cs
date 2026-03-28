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
    }
}

