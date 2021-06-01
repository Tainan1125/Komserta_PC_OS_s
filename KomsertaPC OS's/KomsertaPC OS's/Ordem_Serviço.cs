using System;
using System.Collections.Generic;
using System.Text;

namespace KomsertaPC_OS_s
{
    class Ordem_Serviço
    {   
        private Cliente cliente;
        private int id;
        private string item;
        private string descrição;
        private DateTime entrada;
        private DateTime saída;
        private float valor;
        private bool pago;

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Saída { get => saída; set => saída = value; }
        public float Valor { get => valor; set => valor = value; }
        public bool Pago { get => pago; set => pago = value; }

        public Ordem_Serviço()
        {

        }
        public Ordem_Serviço(int id, string item, string descrição, DateTime entrada, DateTime saída, float valor, bool pago)
        {
            Id = id;
            Item = item;
            Descrição = descrição;
            Entrada = entrada;
            Saída = saída;
            Valor = valor;
            Pago = pago;
        }
    }
}
