using System;



    class Item
{
    private string nome;
    private int valor;
    private Rotulo rotulo;

    public Item(string nome, int quantia, Rotulo rotulo)
    {
        this.nome = nome;
        if (quantia > 0) this.valor = quantia;
        this.rotulo = rotulo;
    }

    public void SetQuantia(int quantia)
    {
        if (quantia > 0) this.valor = quantia;
    }
    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome() { return this.nome; }
    public int GetQuantia() { return this.valor ;}

    public override string ToString()
    {
        return $"{nome} {valor}R$ {rotulo}";
    }
}

