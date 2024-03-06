using System.Security.Cryptography.X509Certificates;

namespace aula3;

public class Estoque
{
    public Produto[] Produtos = new Produto[0];


    public void Adicionar(Produto Produto)
    {
        Produto[] novoVetor = new Produto[Produtos.Length + 1];
        for (int pos = 0; pos < Produtos.Length; pos++)
        {
            Produto item = Produtos[pos];
            novoVetor[pos] = item;
        }
        novoVetor[novoVetor.Length - 1] = Produto;
        Produtos = novoVetor;

    }
    public void Listar()
    {
        int cont = 1;
        foreach (Produto item in Produtos)
        {
                string precoFormatado = item.Preco.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
        
            Console.WriteLine($"{cont}. {item.Nome} | Preço: {precoFormatado } | Medidas: A {item.Altura}  x L {item.Largura } x C {item.Comprimento} | {item.Estoque}  no estoque");
            cont++;
        }



    }

    public void Entrada(int pos, int qtd)
    {
        Produto Produto = Produtos[pos - 1];
        Produto.Estoque += qtd;

    }



    public void Saida(int pos, int qtd)
    {
        Produto Produto = Produtos[pos - 1];
        Produto.Estoque -= qtd;


        
    }




   public void Remover(Produto produto)
{
    // Verifica se o produto a ser removido está presente no vetor
    int pos = Array.IndexOf(Produtos, produto);
    if (pos != -1)
    {
        Produto[] novoVetor = new Produto[Produtos.Length - 1];
        int novoIndice = 0;
        
        // Copia os produtos para o novo vetor, exceto o produto a ser removido
        for (int i = 0; i < Produtos.Length; i++)
        {
            if (i != pos)
            {
                novoVetor[novoIndice] = Produtos[i];
                novoIndice++;
            }
        }
        Produtos = novoVetor;
        Console.WriteLine("Produto removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Produto não encontrado!");
    }
}



}