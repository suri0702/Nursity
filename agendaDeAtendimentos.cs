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

    public partial class agendaDeAtendimentos : Form
    {
        int secretaria_id;
        public agendaDeAtendimentos(int id)
        {
            InitializeComponent();
            secretaria_id = id;
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void atualizaLista(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT conta_id, conta_nome, conta_tipo FROM Conta WHERE conta_tipo = 2 AND (conta_nome LIKE @query OR conta_CPF LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");

            con.Open();

            listBox1.Items.Clear();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(new conta(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2))); //conta_id, conta_nome e conta_tipo

            }

            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void agendaDeAtendimentos_Load(object sender, EventArgs e)
        {
            atualizaLista("");
            atualizaSlots();
            dateTimePicker1.MinDate = DateTime.Today;

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            atualizaLista(textBox26.Text);
        }

        private void atualizaSlots()
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT appointment_visita_slot,appointment_condicao_especial, appointment_prioridade,appointment_convenio,appointment_plano,appointment_medico_nome, appointment_especialidade, appointment_tipo_atendimento,appointment_retorno, appointment_comentarios FROM Appointment WHERE appointment_visita_data = @data";
            command.Parameters.AddWithValue("@data", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> slots = utilities.getSlots();
            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
                textBox1.Text = reader.GetString(1);
                if (reader.GetInt32(2) == 0)
                    comboBox2.SelectedItem = "Vermelho";
                else if (reader.GetInt32(2) == 1)
                    comboBox2.SelectedItem = "Amarelo";
                else if (reader.GetInt32(2) == 2)
                    comboBox2.SelectedItem = "Verde";
                else
                    comboBox2.SelectedItem = "Azul";

                textBox2.Text = reader.GetString(3);
                textBox3.Text = reader.GetString(4);
                textBox4.Text = reader.GetString(5);

                if (reader.GetInt32(6) == 0)
                    comboBox3.SelectedItem = "Vermelho";
                else if (reader.GetInt32(6) == 1)
                    comboBox3.SelectedItem = "Acupuntura";
                else if (reader.GetInt32(6) == 2)
                    comboBox3.SelectedItem = "Alergia e Imunologia";
                else if (reader.GetInt32(6) == 3)
                    comboBox3.SelectedItem = "Anestesiologista";
                else if (reader.GetInt32(6) == 4)
                    comboBox3.SelectedItem = "Angiologia";
                else if (reader.GetInt32(6) == 5)
                    comboBox3.SelectedItem = "Cardiologia";
                else if (reader.GetInt32(6) == 6)
                    comboBox3.SelectedItem = "Cirurgia Cardiovascular";
                else if (reader.GetInt32(6) == 7)
                    comboBox3.SelectedItem = "Cirurgia da Mão";
                else if (reader.GetInt32(6) == 8)
                    comboBox3.SelectedItem = "Cirurgia de Cabeça e Pescoço";
                else if (reader.GetInt32(6) == 9)
                    comboBox3.SelectedItem = "Cirurgia do Aparelho Digestivo";
                else if (reader.GetInt32(6) == 10)
                    comboBox3.SelectedItem = "Cirurgia Geral";
                else if (reader.GetInt32(6) == 11)
                    comboBox3.SelectedItem = "Cirurgia Oncológica";
                else if (reader.GetInt32(6) == 12)
                    comboBox3.SelectedItem = "Cirurgia Pediátrica";
                else if (reader.GetInt32(6) == 13)
                    comboBox3.SelectedItem = "Cirurgia Plástica";
                else if (reader.GetInt32(6) == 14)
                    comboBox3.SelectedItem = "Cirurgia Torácica";
                else if (reader.GetInt32(6) == 15)
                    comboBox3.SelectedItem = "Cirurgia Vascular";
                else if (reader.GetInt32(6) == 16)
                    comboBox3.SelectedItem = "Clínica Médica";
                else if (reader.GetInt32(6) == 17)
                    comboBox3.SelectedItem = "Coloproctologia";
                else if (reader.GetInt32(6) == 18)
                    comboBox3.SelectedItem = "Dermatologia";
                else if (reader.GetInt32(6) == 19)
                    comboBox3.SelectedItem = "Endocrinologia e Metabologia";
                else if (reader.GetInt32(6) == 20)
                    comboBox3.SelectedItem = "Endoscopia";
                else if (reader.GetInt32(6) == 21)
                    comboBox3.SelectedItem = "Gastroenterologia";
                else if (reader.GetInt32(6) == 22)
                    comboBox3.SelectedItem = "Genética Médica";
                else if (reader.GetInt32(6) == 23)
                    comboBox3.SelectedItem = "Geriatria";
                else if (reader.GetInt32(6) == 24)
                    comboBox3.SelectedItem = "Ginecologia e Obstetrícia";
                else if (reader.GetInt32(6) == 25)
                    comboBox3.SelectedItem = "Hematologia e Hemoterapia";
                else if (reader.GetInt32(6) == 26)
                    comboBox3.SelectedItem = "Homeopatia";
                else if (reader.GetInt32(6) == 27)
                    comboBox3.SelectedItem = "Infectologia";
                else if (reader.GetInt32(6) == 28)
                    comboBox3.SelectedItem = "Mastologia";
                else if (reader.GetInt32(6) == 29)
                    comboBox3.SelectedItem = "Medicina de Emergência";
                else if (reader.GetInt32(6) == 30)
                    comboBox3.SelectedItem = "Medicina de Família e Comunidade";
                else if (reader.GetInt32(6) == 31)
                    comboBox3.SelectedItem = "Medicina do Trabalho";
                else if (reader.GetInt32(6) == 32)
                    comboBox3.SelectedItem = "Medicina de Tráfego";
                else if (reader.GetInt32(6) == 33)
                    comboBox3.SelectedItem = "Medicina Esportiva";
                else if (reader.GetInt32(6) == 34)
                    comboBox3.SelectedItem = "Medicina Física e Reabilitação";
                else if (reader.GetInt32(6) == 35)
                    comboBox3.SelectedItem = "Medicina Intensiva";
                else if (reader.GetInt32(6) == 36)
                    comboBox3.SelectedItem = "Medicina Legal e Perícia Médica";
                else if (reader.GetInt32(6) == 37)
                    comboBox3.SelectedItem = "Medicina Nuclear";
                else if (reader.GetInt32(6) == 38)
                    comboBox3.SelectedItem = "Medicina Preventiva e Social";
                else if (reader.GetInt32(6) == 39)
                    comboBox3.SelectedItem = "Nefrologia";
                else if (reader.GetInt32(6) == 40)
                    comboBox3.SelectedItem = "Neurocirurgia";
                else if (reader.GetInt32(6) == 41)
                    comboBox3.SelectedItem = "Neurologia";
                else if (reader.GetInt32(6) == 42)
                    comboBox3.SelectedItem = "Nutrologia";
                else if (reader.GetInt32(6) == 43)
                    comboBox3.SelectedItem = "Oftalmologia";
                else if (reader.GetInt32(6) == 44)
                    comboBox3.SelectedItem = "Oncologia Clínica";
                else if (reader.GetInt32(6) == 45)
                    comboBox3.SelectedItem = "Oncologia Clínica";
                else if (reader.GetInt32(6) == 46)
                    comboBox3.SelectedItem = "Ortopedia e Traumatologia";
                else if (reader.GetInt32(6) == 47)
                    comboBox3.SelectedItem = "Otorrinolaringologia";
                else if (reader.GetInt32(6) == 48)
                    comboBox3.SelectedItem = "Patologia";
                else if (reader.GetInt32(6) == 49)
                    comboBox3.SelectedItem = "Patologia Clínica/Medicina Laboratorial";
                else if (reader.GetInt32(6) == 50)
                    comboBox3.SelectedItem = "Pediatria";
                else if (reader.GetInt32(6) == 51)
                    comboBox3.SelectedItem = "Pneumologia";
                else if (reader.GetInt32(6) == 52)
                    comboBox3.SelectedItem = "Psiquiatria";
                else if (reader.GetInt32(6) == 53)
                    comboBox3.SelectedItem = "Radiologia e Diagnóstico por Imagem";
                else if (reader.GetInt32(6) == 54)
                    comboBox3.SelectedItem = "Radioterapia";
                else if (reader.GetInt32(6) == 55)
                    comboBox3.SelectedItem = "Reumatologia";
                else
                    comboBox3.SelectedItem = "Urologia";

                if (reader.GetInt32(7) == 0)
                    comboBox4.SelectedItem = "Urgência";
                else if (reader.GetInt32(7) == 1)
                    comboBox4.SelectedItem = "Emergência";
                else
                    comboBox4.SelectedItem = "Consulta Eletiva";

                if (reader.GetInt32(8) == 1)
                    comboBox6.SelectedItem = "Sim";
                else
                    comboBox6.SelectedItem = "Não";

                textBox5.Text = reader.GetString(9);

            }

            comboBox1.Items.Clear();
            foreach (object slot in slots.ToArray())
                comboBox1.Items.Add(slot);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
            con.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            atualizaSlots();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Por favor, selecione um paciente!");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecione um slot de atendimento!");
            }

            int paciente_id = ((conta)listBox1.SelectedItem).getId();
            int slot = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;

            command = con.CreateCommand();
            command.CommandText = "INSERT INTO Appointment (appointment_secretaria_id, appointment_paciente_id, appointment_visita_data, appointment_visita_slot, appointment_data,appointment_condicao_especial, appointment_prioridade,appointment_convenio,appointment_plano,appointment_medico_nome, appointment_especialidade, appointment_tipo_atendimento,appointment_retorno, appointment_comentarios) VALUES (@secretaria_id, @paciente_id, @visita_data, @visita_slot, @data, @condicao_especial, @prioridade, @convenio,@plano, @nome_medico, @especialidade, @tipo_atendimento, @retorno, @observacao)";
            command.Parameters.AddWithValue("@secretaria_id", secretaria_id);
            command.Parameters.AddWithValue("@paciente_id", paciente_id);
            command.Parameters.AddWithValue("@visita_data", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@visita_slot", slot);
            command.Parameters.AddWithValue("@data", DateTime.Now);
            command.Parameters.AddWithValue("@con", paciente_id);
            command.Parameters.AddWithValue("@condicao_especial", textBox1.Text);
            command.Parameters.AddWithValue("@prioridade", comboBox2.SelectedIndex);
            command.Parameters.AddWithValue("@convenio", textBox2.Text);
            command.Parameters.AddWithValue("@plano", textBox3.Text);
            command.Parameters.AddWithValue("@nome_medico", textBox4.Text);
            command.Parameters.AddWithValue("@especialidade", comboBox3.SelectedIndex);
            command.Parameters.AddWithValue("@tipo_atendimento", comboBox4.SelectedIndex);
            command.Parameters.AddWithValue("@retorno", comboBox6.SelectedIndex);
            command.Parameters.AddWithValue("@observacao", textBox5.Text);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT appointment_id FROM Appointment WHERE appointment_visita_data = @visita_data AND appointment_visita_slot = @visita_slot";
                int appointment_id = (int)command.ExecuteScalar();

                MessageBox.Show("O atendimento foi agendado com sucesso!");
                MessageBox.Show("ID do atendimento:" + appointment_id.ToString());
            }
            else
                MessageBox.Show("Erro ao fazer a reserva do atendimento!");

            con.Close();

            atualizaSlots();


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
