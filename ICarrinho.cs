namespace Aula26_Interface
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int _codigo, Produto _produtoalterado);
         void Deletar(Produto produto);
    }
}