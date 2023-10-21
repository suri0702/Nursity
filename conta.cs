using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursityy
{
    public class conta
    {
        int id, tipo;
        string nome;

        public conta(int id,string nome, int tipo)
        {
            this.id = id;
            this.tipo = tipo;
            this.nome = nome;
        }

        public override string ToString()
        {
            string conta_tipo;
            if (tipo == 0)
            {
                conta_tipo = "Secretaria";
            } 
            else if (tipo == 1)
            {
                conta_tipo = "Medico";
            }
            else 
                conta_tipo = "Paciente";

            return conta_tipo + ":" + id.ToString() + " - " + nome;
        }

        public int getId() { return id; }
    }
}
