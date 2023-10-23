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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nursityy
{
    public partial class atendimentosAgendados : Form
    {
        int conta_id, conta_tipo;
        public atendimentosAgendados(int id)
        {
            InitializeComponent();
            conta_id = id;
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void atualizaLista()
        {
            command = con.CreateCommand();

            if (radioButton1.Checked)//busca apenas por data de consulta
                command.CommandText = "SELECT appointment_id, appointment_paciente_id,paciente.conta_nome, paciente.conta_nome_social, appointment_secretaria_id,secretaria.conta_nome,appointment_visita_data,appointment_visita_slot, appointment_data FROM Appointment, Conta as paciente, Conta as secretaria WHERE appointment_paciente_id = paciente.conta_id AND appointment_secretaria_id = secretaria.conta_id AND appointment_visita_data = @data";
            else if (radioButton2.Checked)
                command.CommandText = "SELECT appointment_id, appointment_paciente_id,paciente.conta_nome,appointment_secretaria_id,secretaria.conta_nome,appointment_visita_data,appointment_visita_slot,appointment_data FROM Appointment, Conta as paciente, Conta as secretaria WHERE appointment_paciente_id = paciente.conta_id AND appointment_secretaria_id = secretaria.conta_id AND (paciente.conta_nome LIKE @query OR paciente.conta_CPF LIKE @query OR appointment_id LIKE @query)";
            else
                command.CommandText = "SELECT appointment_id, appointment_paciente_id,paciente.conta_nome,appointment_secretaria_id,secretaria.conta_nome,appointment_visita_data,appointment_visita_slot,appointment_data FROM Appointment, Conta as paciente, Conta as secretaria WHERE appointment_paciente_id = paciente.conta_id AND appointment_secretaria_id = secretaria.conta_id AND (paciente.conta_nome LIKE @query OR paciente.conta_CPF LIKE @query OR appointment_id LIKE @query AND appointment_visita_data = @data)";

            command.Parameters.AddWithValue("@data", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@query", textBox26.Text + "%");
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int paciente_id = reader.GetInt32(1);
                string paciente_nome = reader.GetString(2);
                int secretaria_id = reader.GetInt32(3);
                string secretaria_nome = reader.GetString(4);
                DateTime visita_data = new DateTime();
                DateTime.TryParse(reader.GetValue(5).ToString(), out visita_data);
                int slot = reader.GetInt32(6);
                DateTime data = new DateTime();
                DateTime.TryParse(reader.GetValue(7).ToString(), out data);

                listBox1.Items.Add(new appointment(id, visita_data, slot, secretaria_id, secretaria_nome, paciente_id, paciente_nome, data));

            }

            con.Close();
        }


        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void atendimentosAgendados_Load(object sender, EventArgs e)
        {
            atualizaLista();
            command = con.CreateCommand();
            command.CommandText = "SELECT conta_tipo FROM Conta WHERE conta_id = @id";
            command.Parameters.AddWithValue("@id", conta_id);
            con.Open();

            conta_tipo = (int)command.ExecuteScalar();

            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizaForm();
        }

        private void atualizaForm()
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Por favor, selecione uma reserva de atendimento!");
                return;

            }

            appointment app = (appointment)listBox1.SelectedItem;
            textBox27.Text = app.id.ToString();
            textBox28.Text = app.visita_data.Date.ToString();
            textBox5.Text = utilities.getSlots()[app.slot];
            textBox6.Text = app.secretaria.ToString();
            textBox1.Text = app.paciente.ToString();
            textBox7.Text = app.data.ToString();

            if (conta_tipo == 0 && app.visita_data >= DateTime.Today)
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;

            if (conta_tipo == 1)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Por favor, selecione uma reserva de atendimento!");
                return;
            }

            appointment app = (appointment)listBox1.SelectedItem;

            Hide();
            editarReservaAtendimento editarReservaAtendimento = new editarReservaAtendimento(app);
            editarReservaAtendimento.ShowDialog();
            atualizaLista();
            Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
        }

        private void label38_Click(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                MessageBox.Show("Por favor, selecione uma reserva de atendimento!");
                return;
            }

            appointment app = (appointment)listBox1.SelectedItem;

            Hide();
            diagnostico diagnostico = new diagnostico(conta_id, app.paciente.Key, app.id);
            diagnostico.ShowDialog();
            Show();
        }
    }
}
