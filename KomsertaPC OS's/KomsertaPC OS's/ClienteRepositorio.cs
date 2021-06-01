using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace KomsertaPC_OS_s
{
    static class ClienteRepositorio
    {
        public static List<Cliente> clientes = new List<Cliente>();

        public static void Adicionar(Cliente item)
        {
            clientes.Add(item);
        }
        public static Boolean Remover(String cpf)
        {
            if(Achar(cpf) == null)
            {
                return false;
            }
            return clientes.Remove(Achar(cpf));
        }
        private static Cliente Achar(String cpf)
        {
            foreach(Cliente cliente in clientes)
            {
                if (cliente.Cpf.Equals(cpf))
                return cliente;
            }
            return null;
        }

    }
}
