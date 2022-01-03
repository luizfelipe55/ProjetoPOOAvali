using System;



class Compra
{
    private Cliente nome;
    private double preco;
    private double valor_compra = 0;

    public Compra(Cliente nome)
    {
        this.nome = nome;
    }

    public void SetItem(double preco)
    {
        this.preco = preco;
    }

    public double GetItem()
    {
        return preco;
    }
    public double GetValTotal()
    {
        return valor_compra;
    }
    public double RealizarVenda(double valor_teste)
    {
        valor_compra = valor_compra + valor_teste;
        return valor_compra;
    }

    public override string ToString()
    {
        return $"Comprador: {nome} valor da compra: {valor_compra}";
    }
}

