using System;



class Program
{
    public static void Main(string[] args)
    {
        Rotulo item01_rot = new Rotulo(39241000, 30, "PC");

        Item item01 = new Item("Copo", 20, item01_rot);

        Cliente x = new Cliente("Analice Lima", item01);

        Compra comprador = new Compra(x);

        comprador.SetItem(item01.GetQuantia());

        double testes = comprador.GetItem();

        comprador.RealizarVenda(testes);

        Console.WriteLine(comprador.ToString());

        Rotulo item02_rot = new Rotulo(39232190, 100, "FD");

        Item item02 = new Item("Sacola", 6, item02_rot);

        x.SetItem(item02);

        comprador.SetItem(item02.GetQuantia());

        double testes_2 = comprador.GetItem();

        comprador.RealizarVenda(testes_2);

        Console.WriteLine(comprador.ToString());

        x.InserirEnum(item01);
        x.InserirEnum(item02);

        foreach(Item a in x.Enumerar())
        {
            Console.WriteLine(a);
        }


    }
}

