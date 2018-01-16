using ProjetoDDD.Application.Interface;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService

    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
