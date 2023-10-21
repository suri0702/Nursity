using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursityy
{
    public class appointment
    {
        public int id, slot, visita, retorno;
        public KeyValuePair<int, string> paciente,secretaria;
        public DateTime visita_data;

        public appointment(int id, int paciente_id, string paciente_nome, string paciente_nome_social,int paciente_prioridade, int retorno, int visita ,int secretaria_id, string secretaria_nome, int slot, DateTime visita_data)
        {
            this.id = id;
            paciente = new KeyValuePair<int, string>(paciente_id,paciente_nome);
            paciente = new KeyValuePair<int, string>(paciente_prioridade,paciente_nome_social);
            secretaria = new KeyValuePair<int, string>(secretaria_id, secretaria_nome);
            this.visita_data = visita_data;
            this.retorno = retorno;
            this.visita = visita;
            this.slot = slot;
        }

        public override string ToString()
        {
            return id.ToString() + ":" + paciente.Value + ":" + visita_data.Date.ToString() + "=>" + utilities.getSlots()[slot];
        }
    }
}
