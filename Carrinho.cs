using System.Collections.Generic;
using System;

namespace Aula26_Interface
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List <Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto _produtoalterado)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = _produtoalterado.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _produtoalterado.Preco;
            
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Listar()
        {
           foreach(Produto item in carrinho){
               System.Console.WriteLine($"R$ {item.Preco,2} - {item.Nome}");
           }
        }

        public void mostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Valor total da compra: R$ {ValorTotal}");
        Console.ResetColor();
        }
    }
}