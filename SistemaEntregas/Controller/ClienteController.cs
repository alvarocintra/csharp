﻿using Modelos; //usando modelos
using System.Collections.Generic;
using System.Linq;

namespace Controller
{
    public class ClienteController
    {
        static List<Cliente> MeusClientes = new List<Cliente>();

        public void SalvarCliente(Cliente cliente)
        {
            // TODO: Persistir os dados do cliente
            MeusClientes.Add(cliente);
        }

        public Cliente PesquisarPorNome(string nome)
        {
            var c = from x in MeusClientes
                    where x.Nome.Equals(nome)
                    select x;
            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }
    }
}
