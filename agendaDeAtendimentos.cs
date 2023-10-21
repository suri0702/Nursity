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

        public agendaDeAtendimentos()
        {
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void atualizaLista(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT conta_id, conta_nome, conta_tipo,appointment_condicao_especial, appointment_prioridade,appointment_convenio,appointment_plano,appointment_medico_nome, appointment_especialidade, appointment_tipo_atendimento, appointment_visita,appointment_retorno, appointment_comentarios FROM [Conta], Appointment WHERE conta_tipo = 2 AND (conta_nome LIKE @query OR conta_CPF LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");

            con.Open();

            listBox1.Items.Clear();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(new conta(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2))); //conta_id, conta_nome e conta_tipo
                textBox1.Text = reader.GetString(3);
                comboBox2.SelectedItem = reader.GetString(4);
                textBox2.Text = reader.GetString(5);
                textBox3.Text = reader.GetString(6);
                textBox4.Text = reader.GetString(7);
                comboBox3.SelectedItem = reader.GetString(8);
                comboBox4.SelectedItem = reader.GetString(9);
                comboBox5.SelectedItem = reader.GetString(10);
                comboBox6.SelectedItem = reader.GetString(11);
                textBox5.Text = reader.GetString(12);
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
            atualizaLista(textBox1.Text);
        }

        private void atualizaSlots()
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT appointment_visita_slot FROM Appointment WHERE appointment_visita_data = @data";
            command.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            Dictionary<int, string> slots = utilities.getSlots();
            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
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
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count  )
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
            command.CommandText = "INSERT INTO Appointment (appointment_secretaria_id, appointment_paciente_id, appointment_visita_data, appointment_visita_slot, appointment_data) VALUES (@secretaria_id, @paciente_id, @visita_data, @visita_slot, @data)";
            command.Parameters.AddWithValue("@secretaria_id", secretaria_id);
            command.Parameters.AddWithValue("@paciente_id", paciente_id);
            command.Parameters.AddWithValue("@visita_data", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@visita_slot", slot);
            command.Parameters.AddWithValue("@data", DateTime.Now);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT appointment_id FROM Appointment WHERE appointment_visita_data = @visita_data AND appointment_visita_slot = @visita_slot";
                int appointment_id = (int) command.ExecuteScalar();

                MessageBox.Show("O atendimento foi agendado com sucesso!");
                MessageBox.Show("ID do atendimento:" + appointment_id.ToString());
            }
            else
                MessageBox.Show("Erro ao fazer a reserva do atendimento!");

            con.Close();

            atualizaSlots();


        }
    }
}
