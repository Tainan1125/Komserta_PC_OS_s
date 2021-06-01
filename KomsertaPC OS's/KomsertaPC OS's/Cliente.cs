using System;
using System.Collections.Generic;
using System.Text;

namespace KomsertaPC_OS_s
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return nome + ";" + cpf + ";" + telefone;
        }
    }
}
