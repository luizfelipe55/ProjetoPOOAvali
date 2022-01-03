using System;



class Estoque
{
    private int[] lista_ncm = { 39241000 , 39232190 , 39239000 , 76152000 , 04029900 , 39259090 , 59061000 , 48195000 , 82159100 , 40151900};
    private int novo_estoque;
    private int[] lista_produtos_dispon = { 50, 40, 70, 25, 30, 44, 19, 76, 14, 37 };

    private Compra compra;

    public Estoque(Compra compra)
    {
        this.compra = compra;
    }

    public int MudarEstoque(int entrada, int entrada_2)
    {
        foreach (int n in lista_ncm)
        {
            if (n == entrada)
            {
                novo_estoque = lista_produtos_dispon[n] - entrada_2;
                if (novo_estoque < 0) novo_estoque = 0;
                return novo_estoque;
            }
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{novo_estoque}";
    }
}

