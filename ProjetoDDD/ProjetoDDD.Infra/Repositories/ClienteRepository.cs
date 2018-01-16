using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Domain.Interfaces.Reposiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Repositories
{
   public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

    }
}
