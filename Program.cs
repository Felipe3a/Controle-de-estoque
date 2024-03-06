using System.Runtime.InteropServices;

namespace aula3;

class Program
{
    static void Main(string[] args)

    {
        Produto[] Produtos = new Produto[2];
        Estoque estoque = new Estoque();

        int menu = 0;
        do
        {

            Console.WriteLine("\n  CONTROLE DE ESTOQUE-LOJA DE AQUARIAMO\n\n       ****Peace Aquariums****");
            Console.WriteLine("\n_______Escolha a opção desejada________\n\n");
            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada estoque");
            Console.WriteLine("[5] Saída estoque");
            Console.WriteLine("[0] Sair\n");


            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {

                Produto novoProduto = new Produto();

                Console.WriteLine("Nome do Produto:");
                novoProduto.Nome = Console.ReadLine();

                Console.WriteLine("Informe o preço: ");
                novoProduto.Preco = Convert.ToDouble(Console.ReadLine());




                Console.WriteLine("Largura: ");
                novoProduto.Largura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Altura");
                novoProduto.Altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Comprimento: ");
                novoProduto.Comprimento = Convert.ToDouble(Console.ReadLine());

                estoque.Adicionar(novoProduto);

            }




            else if (menu == 2)
            {
                Console.WriteLine("\n*Itens no Estoque*\n");
                estoque.Listar(); 
            } 
              
       else if (menu == 3)
            {
                Console.WriteLine("Posição do produto a ser removido:");
                int posicaoProduto = Convert.ToInt32(Console.ReadLine());
                Produto produtoARemover = estoque.Produtos[posicaoProduto - 1];
                 estoque.Remover(produtoARemover);
            }


            else if (menu == 4)
            {

                Console.WriteLine("\n*Itens no Estoque*\n");
                estoque.Listar();

                Console.WriteLine("Posição do produto");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de Entrada");
                int qtd = Convert.ToInt32(Console.ReadLine());
                estoque.Entrada(pos, qtd);
            }




            else if (menu == 5)
            {
                Console.WriteLine("\n*Itens no Estoque*\n");
                estoque.Listar();

                Console.WriteLine("Posição do produto");
                int pos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Quantidade de Saída");
                int qtd = Convert.ToInt32(Console.ReadLine());
                estoque.Saida(pos, qtd);
            }

         

        }
        while (menu != 0);



























        //         Produto P1 = new Produto();

        //         P1.Nome = "Aquário";
        //         P1.Preco = 100.5;
        //         P1.Estoque = 10;
        //         P1.Altura = 60;
        //         P1.Largura = 50;
        //         P1.Comprimento = 100;



        //         Produto P2 = new Produto();

        //         P2.Nome = "Aquário";
        //         P2.Preco = 50.25;
        //         P2.Estoque = 10;
        //         P2.Altura = 30;
        //         P2.Largura = 25;
        //         P2.Comprimento = 50;



        // Produto[] Produtos = new Produto[2];
        // Produtos[0] = P1;
        // Produtos[1] = P2;

        // Console.WriteLine(p2);
    }
}
