using System;



class Rotulo
{
    private int ncm;
    private int quantidade;
    private string grand;


    public Rotulo(int ncm, int quantidade, string grand)
    {
        if (ncm > 0) this.ncm = ncm;
        if (quantidade > 0) this.quantidade = quantidade;
        this.grand = grand;
    }

    public void SetNcm(int ncm)
    {
        if (ncm > 0) this.ncm = ncm;
    }
    public void SetQuantidade(int quantidade)
    {
            if (quantidade > 0) this.quantidade = quantidade;
    }

    public void SetGrand(string grand)
    {
            this.grand = grand;
    }
    public int GetNcm()
    {
            return ncm;
    }
    public int GetQuantidade()
    {
        return quantidade;
    }
    public string GetGrand()
    {
        return grand;
    }
    public override string ToString()
    {
        return $"NCM:{ncm} Quantidade:{quantidade} Tipo:{grand}";
    }
}

