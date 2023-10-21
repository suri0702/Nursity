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
using System.Security.Cryptography.Xml;

namespace Nursityy
{
    public partial class editarReservaAtendimento : Form
    {
        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;


        public editarReservaAtendimento(appointment app)
        {
            InitializeComponent();

            dateTimePicker1.Value = app.visita_data;

            textBox27.Text = app.id.ToString();
            textBox6.Text = app.secretaria.ToString();
            textBox1.Text = app.paciente.ToString();
            textBox4.Text = app.paciente.ToString();
            textBox2.Text = app.paciente.ToString();
            textBox3.Text = app.retorno.ToString();
            textBox7.Text = app.visita.ToString();

            dateTimePicker1.MinDate = DateTime.Today;

            atualizaCombo(app.slot);


        }

        private void atualizaCombo(int visita_slot)
        {
            Dictionary<int, string> slots = utilities.getSlots();

            command = con.CreateCommand();
            command.CommandText = "SELECT appointment_visita_slot FROM Appointment WHERE appointment_visita_data = @data AND appointment_id <> @id";
            command.Parameters.AddWithValue("@data", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@id", textBox27.Text);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                slots.Remove(reader.GetInt32(0));
            }

            comboBox1.Items.Clear();

            foreach (KeyValuePair<int, string> slot in slots)
            {
                comboBox1.Items.Add(slot);

                if (slot.Key == visita_slot)
                {
                    comboBox1.SelectedItem = slot;
                }
            }
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "UPDATE Appointment SET appointment_visita_data = @visita_data, appointment_visita_slot = @visita_slot WHERE appointment_id = @id";
            command.Parameters.AddWithValue("@id", textBox27.Text);
            command.Parameters.AddWithValue("@visita_data", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@visita_slot", ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("A reserva do atendimento foi atualizada com sucesso!");
            else
                MessageBox.Show("Erro ao atualizar a reserva do atendimento!");

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "DELETE FROM Appointment WHERE appointment_id = @id";
            command.Parameters.AddWithValue("@id", textBox27.Text);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("A reserva do atendimento foi deletada com sucesso!");
            else
                MessageBox.Show("Erro ao deletar a reserva do atendimento!");

            con.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            atualizaCombo(1);
        }
    }
}
