using System;



class Cliente
{
    private int i;
    private Item[] enumerado;
    private string cpf, ident;
    private Item item;
    public Cliente(string cpf, string ident, Item item)
    {
        this.cpf = cpf;
        this.ident = ident;
        this.item = item;
    }
    public Cliente (string ident, Item item)
    {
        this.ident = ident;
        this.item = item;
        enumerado = new Item[10];
    }
    public void InserirEnum(Item item)
    {
        if (i < 5)
        {
            enumerado[i] = item;
            i++;
        }
    }

    public Item[] Enumerar()
    {
        Item[] enem = new Item[i];
        Array.Copy(enumerado, enem, i);
        return enem;
    }

    public void SetItem(Item item)
        { this.item = item; }

    public Item GetItem() { return item; }

    public override string ToString()
    {
        if (this.cpf == null)
        {
            return $"{ident} {item}";
        }
        else return $"{cpf}  {ident}  {item}";
    }
}

