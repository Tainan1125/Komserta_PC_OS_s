using System;
using System.Collections.Generic;
using System.Text;

namespace KomsertaPC_OS_s
{
    static class OSRepositorio
    {
        public static List<Ordem_Serviço> ordens = new List<Ordem_Serviço>();

        public static int id = 0;


        public static void Adicionar(Ordem_Serviço item)
        {
            item.Id = id;
            ordens.Add(item);
            id++;
        }
        public static Boolean Remover(int id)
        {
            if (Achar(id) == null)
            {
                return false;
            }
            return ordens.Remove(Achar(id));
        }
        private static Ordem_Serviço Achar(int id)
        {
            foreach (Ordem_Serviço ordem in ordens)
            {
                if (ordem.Id.Equals(id))
                    return ordem;
            }
            return null;
        }
    }
}
