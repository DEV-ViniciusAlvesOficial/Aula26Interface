using System;

namespace Aula26_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Carrinho carrinho = new Carrinho();
        
           Produto p1 = new Produto(12345, "Mortal Kombat", 199.0f);
           Produto p2 = new Produto(27567, "Dont Starve Together", 37.99f);
           Produto p3 = new Produto(56783, "Splinter Cell Blacklist", 26.07f);
           Produto p4 = new Produto(44567, "Sniper Elite 4", 98.90f);
        

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Cadastrar(p4);

            carrinho.Deletar(p3);

            Produto ProdutoAlterado = new Produto(44568, "Terraria", 14.99f);
            carrinho.Alterar(44567, ProdutoAlterado);

            carrinho.Listar();

            Console.ForegroundColor = ConsoleColor.Cyan;

            carrinho.mostrarTotal();

            Console.ResetColor();


        }
    }
}
