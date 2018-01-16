using ProjetoDDD.Domain.Entities;
using System.Collections.Generic;


namespace ProjetoDDD.Domain.Interfaces.Reposiories
{
   public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
        
    }
}
