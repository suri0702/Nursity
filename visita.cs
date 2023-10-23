using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursityy
{
    public class visita
    {
        public int atendimento_id;
        public string atendimento_hip_versao_diagnostico, atendimento_hip_cid_principal, atendimento_hip_cid_causas_associadas, atendimento_hip_tempo_doenca, atendimento_hip_status, atendimento_hip_gravidade, atendimento_hip_principais_sinais_sintomas, atendimento_hip_diagnostico_inicial, atendimento_hip_obs_adicionais, atendimento_hip_versao_diagnostico_secundario, atendimento_hip_cid_secundario, atendimento_hip_diagnostico_secundario, atendimento_hip_obs_adicionais_secundarias;
        public KeyValuePair<int, string> paciente, secretaria;
        public DateTime data;


        public visita(int atendimento_id, DateTime data,string atendimento_hip_cid_principal, string atendimento_hip_cid_causas_associadas, string atendimento_hip_tempo_doenca, string atendimento_hip_status, string atendimento_hip_gravidade, string atendimento_hip_principais_sinais_sintomas, string atendimento_hip_diagnostico_inicial, string atendimento_hip_obs_adicionais,string atendimento_hip_versao_diagnostico_secundario,string atendimento_hip_cid_secundario,string atendimento_hip_diagnostico_secundario,string atendimento_hip_obs_adicionais_secundarias, int secretaria_id, string secretaria_nome, int paciente_id, string paciente_nome) 
        {
            this.atendimento_id = atendimento_id;
            this.data = data;
            this.atendimento_hip_obs_adicionais = atendimento_hip_obs_adicionais;
            this.atendimento_hip_cid_principal = atendimento_hip_cid_principal;
            this.atendimento_hip_cid_causas_associadas = atendimento_hip_cid_causas_associadas;
            this.atendimento_hip_tempo_doenca = atendimento_hip_tempo_doenca;
            this.atendimento_hip_status = atendimento_hip_status;
            this.atendimento_hip_gravidade = atendimento_hip_gravidade;
            this.atendimento_hip_principais_sinais_sintomas = atendimento_hip_principais_sinais_sintomas;
            this.atendimento_hip_diagnostico_inicial = atendimento_hip_diagnostico_inicial;
            this.atendimento_hip_versao_diagnostico_secundario = atendimento_hip_versao_diagnostico_secundario;
            this.atendimento_hip_cid_secundario = atendimento_hip_cid_secundario;
            this.atendimento_hip_diagnostico_secundario = atendimento_hip_diagnostico_secundario;
            this.atendimento_hip_obs_adicionais_secundarias = atendimento_hip_obs_adicionais_secundarias;
            secretaria = new KeyValuePair<int, string>(secretaria_id, secretaria_nome);
            paciente = new KeyValuePair<int, string>(paciente_id, paciente_nome);
            

        }

        public override string ToString()
        {
            return atendimento_id.ToString() + " - " + paciente.Value + " => " + data.ToString("yyyy-MM-dd"); //vai mostrar  na listbox
        }



    }
}
