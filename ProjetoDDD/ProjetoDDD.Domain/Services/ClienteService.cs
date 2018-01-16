﻿using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Reposiories;
using ProjetoDDD.Domain.Interfaces.Services;


namespace ProjetoDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base (clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
