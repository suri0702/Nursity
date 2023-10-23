using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursityy
{
    public class appointment
    {
        public int id, slot;
        public KeyValuePair<int, string> paciente,secretaria;
        public DateTime visita_data,data;

        public appointment(int id, DateTime visita_data,int slot, int secretaria_id, string secretaria_nome, int paciente_id, string paciente_nome,DateTime data )
        {
            this.id = id;
            this.visita_data = visita_data;
            this.slot = slot;
            secretaria = new KeyValuePair<int, string>(secretaria_id, secretaria_nome);
            paciente = new KeyValuePair<int, string>(paciente_id, paciente_nome);
            this.visita_data = data;
            
        }

        public override string ToString()
        {
            return id.ToString() + " : " + paciente.Value + ": " + visita_data.Date.ToString() + " => " + utilities.getSlots()[slot];
        }
    }
}
