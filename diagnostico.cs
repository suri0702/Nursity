using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nursityy
{
    public partial class diagnostico : Form
    {
        int conta_id, paciente_id, appointment_id;
        public diagnostico(int conta_id, int paciente_id, int appointment_id)
        {
            InitializeComponent();
            this.conta_id = conta_id;
            this.paciente_id = paciente_id;
            this.appointment_id = appointment_id;

            command = con.CreateCommand();

            command.CommandText = "SELECT atendimento_id FROM Atendimento WHERE atendimento_appointment_id = @appointment_id";
            command.Parameters.AddWithValue("@appointment_id", appointment_id);

            con.Open();

            var resultado = command.ExecuteScalar();

            if (resultado == null)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }


            con.Close();

            atualizaLista();
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void atualizaLista()
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT atendimento_id, paciente.conta_id, paciente.conta_nome, secretaria.conta_id, secretaria.conta_nome,medico.conta_id, medico.conta_nome, atendimento_data, atendimento_hip_versao_diagnostico, atendimento_hip_cid_principal, atendimento_hip_cid_causas_associadas, atendimento_hip_tempo_doenca, atendimento_hip_status, atendimento_hip_gravidade, atendimento_hip_principais_sinais_sintomas, atendimento_hip_diagnostico_inicial, atendimento_hip_obs_adicionais, atendimento_hip_versao_diagnostico_secundario, atendimento_hip_cid_secundario, atendimento_hip_diagnostico_secundario, atendimento_hip_obs_adicionais_secundarias FROM Atendimento, Appointment, Conta as paciente, Conta as secretaria, Conta as medico WHERE atendimento_appointment_id = @appointment_id AND atendimento_paciente_id = paciente.conta_id AND atendimento_secretaria_id = secretaria.conta_id AND atendimento_medico_id = medico.conta_id AND paciente.conta_id = @paciente_id";
            command.Parameters.AddWithValue("@paciente_id", paciente_id);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();

            while (reader.Read())
            {
                int atendimento_id = reader.GetInt32(0);
                int paciente_id = reader.GetInt32(1);
                string paciente_nome = reader.GetString(2);
                int secretaria_id = reader.GetInt32(3);
                string secretaria_nome = reader.GetString(4);
                int medico_id = reader.GetInt32(5);
                string medico_nome = reader.GetString(6);
                DateTime atendimento_data = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out atendimento_data);
                string atendimento_hip_versao_diagnostico = reader.GetString(8);
                string atendimento_hip_cid_principal = reader.GetString(9);
                string atendimento_hip_cid_causas_associadas = reader.GetString(10);
                string atendimento_hip_tempo_doenca = reader.GetString(11);
                string atendimento_hip_status = reader.GetString(12);
                string atendimento_hip_gravidade = reader.GetString(13);
                string atendimento_hip_principais_sinais_sintomas = reader.GetString(14);
                string atendimento_hip_diagnostico_inicial = reader.GetString(15);
                string atendimento_hip_obs_adicionais = reader.GetString(16);
                string atendimento_hip_versao_diagnostico_secundario = reader.GetString(17);
                string atendimento_hip_cid_secundario = reader.GetString(18);
                string atendimento_hip_diagnostico_secundario = reader.GetString(19);
                string atendimento_hip_obs_adicionais_secundarias = reader.GetString(20);

                listBox1.Items.Add(new visita(atendimento_id, paciente_id, paciente_nome, secretaria_id, secretaria_nome, medico_id, medico_nome, atendimento_data, atendimento_hip_versao_diagnostico, atendimento_hip_cid_principal, atendimento_hip_cid_causas_associadas, atendimento_hip_tempo_doenca, atendimento_hip_status, atendimento_hip_gravidade, atendimento_hip_principais_sinais_sintomas, atendimento_hip_diagnostico_inicial, atendimento_hip_obs_adicionais, atendimento_hip_versao_diagnostico_secundario, atendimento_hip_cid_secundario, atendimento_hip_diagnostico_secundario, atendimento_hip_obs_adicionais_secundarias));








            }

            con.Close();


        }

        private void diagnostico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Por favor, selecione um atendimento!");
                return;
            }
            visita v = (visita)listBox1.SelectedItem;
            textBox28.Text = v.atendimento_id.ToString();
            textBox29.Text = v.paciente.ToString();
            textBox7.Text = v.atendimento_hip_versao_diagnostico;
            textBox8.Text = v.atendimento_hip_cid_principal;
            textBox6.Text = v.atendimento_hip_cid_causas_associadas;
            textBox9.Text = v.atendimento_hip_tempo_doenca;
            textBox10.Text = v.atendimento_hip_status;
            textBox13.Text = v.atendimento_hip_gravidade;
            textBox2.Text = v.atendimento_hip_principais_sinais_sintomas;
            textBox1.Text = v.atendimento_hip_diagnostico_inicial;
            textBox4.Text = v.atendimento_hip_obs_adicionais;
            textBox11.Text = v.atendimento_hip_versao_diagnostico_secundario;
            textBox12.Text = v.atendimento_hip_cid_secundario;
            textBox5.Text = v.atendimento_hip_diagnostico_secundario;
            textBox3.Text = v.atendimento_hip_obs_adicionais_secundarias;



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "" || textBox16.Text == "" || textBox18.Text == "" || textBox21.Text == "" || textBox15.Text == "" || textBox14.Text == "" || textBox22.Text == "" || textBox20.Text == "" || textBox24.Text == "" || textBox23.Text == "" || textBox27.Text == "")
            {
                MessageBox.Show("Por favor, complete todos os campos!");
                return;
            }

            command = con.CreateCommand();

            con.Open();

            command.CommandText = "INSERT INTO Appointment (atendimento_appointment_id, atendimento_data,atendimento_hip_versao_diagnostico, atendimento_hip_cid_principal, atendimento_hip_cid_causas_associadas, atendimento_hip_tempo_doenca, atendimento_hip_status, atendimento_hip_gravidade, atendimento_hip_principais_sinais_sintomas, atendimento_hip_diagnostico_inicial, atendimento_hip_obs_adicionais, atendimento_hip_versao_diagnostico_secundario, atendimento_hip_cid_secundario, atendimento_hip_diagnostico_secundario, atendimento_hip_obs_adicionais_secundarias VALUES (@id, @data,@versao_diagnostico, @cid_principal, @cid_causas_associadas, @tempo_doenca, @status, @gravidade, @principais_sinais_sintomas, @diagnostico_inicial, @obs_adicionais, @versao_diagnostico_secundario, @cid_secundario, @diagnostico_secundario, @obs_adicionais_secundarias))";
            command.Parameters.AddWithValue("@id", appointment_id);
            command.Parameters.AddWithValue("@versao_diagnostico", textBox7.Text);
            command.Parameters.AddWithValue("@cid_principal", textBox8.Text);
            command.Parameters.AddWithValue("@cid_causas_associadas", textBox6.Text);
            command.Parameters.AddWithValue("@tempo_doenca", textBox9.Text);
            command.Parameters.AddWithValue("@status", textBox10.Text);
            command.Parameters.AddWithValue("@gravidade", textBox13.Text);
            command.Parameters.AddWithValue("@principais_sinais_sintomas", textBox2.Text);
            command.Parameters.AddWithValue("@diagnostico_inicial", textBox1.Text);
            command.Parameters.AddWithValue("@obs_adicionais", textBox4.Text);
            command.Parameters.AddWithValue("@versao_diagnostico_secundario", textBox11.Text);
            command.Parameters.AddWithValue("@cid_secundario", textBox12.Text);
            command.Parameters.AddWithValue("@diagnostico_secundario", textBox5.Text);
            command.Parameters.AddWithValue("@obs_adicionais_secundarias", textBox3.Text);

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("O diagnóstico foi salvo!");
            }
            else
                MessageBox.Show("Falha ao salvar o diagnóstico!");


            con.Close();

            atualizaLista();

            groupBox5.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Por favor, completar os campos 'Versão do Diagnóstico Secundário','CID Secundário' e 'Diagnóstico Secundário'.");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "UPDATE Appointment SET atendimento_hip_versao_diagnostico_secundario = @versao_diagnostico_secundario, atendimento_hip_cid_secundario = @cid_secundario, atendimento_hip_diagnostico_secundario = @diagnostico_secundario WHERE atendimento_id = @id";
            command.Parameters.AddWithValue("@versao_diagnostico_secundario", textBox11.Text);
            command.Parameters.AddWithValue("@cid_secundario", textBox12.Text);
            command.Parameters.AddWithValue("@diagnostico_secundario", textBox5.Text);
            command.Parameters.AddWithValue("@id", textBox28.Text);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Diagnóstico foi atualizado com sucesso!");
            else
                MessageBox.Show("Falha ao atualizar o diagnóstico!");

            con.Close();

            atualizaLista();

        }
    }
}
