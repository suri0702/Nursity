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
    public partial class EditarConta : Form
    {
        int conta_id;

        public EditarConta(int conta_id)
        {
            InitializeComponent();
            this.conta_id = conta_id;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Por favor inserir um nome!");
                return;
            }

            SqlCommand command = con.CreateCommand();
            command.CommandText = "UPDATE conta SET conta_nome=@nome, conta_aniversario=@aniversario, conta_comentarios=@comentarios, conta_celular=@celular WHERE conta_id = @conta_id ";
            command.Parameters.AddWithValue("@nome", textBox3.Text);
            command.Parameters.AddWithValue("@aniversario", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@celular", textBox4.Text);
            command.Parameters.AddWithValue("@comentarios", textBox6.Text);
            command.Parameters.AddWithValue("@conta_id", conta_id);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("A conta foi editada com sucesso!");
            else
                MessageBox.Show("A conta não foi editada!");

            con.Close();
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);

        private void EditarConta_Load(object sender, EventArgs e)
        {
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_nome,conta_nome, conta_aniversario, conta_celular, conta_tipo, conta_comentarios, conta_data_criacao FROM [User], conta WHERE conta_user_id = user_id AND conta_id = @conta_id";
            command.Parameters.AddWithValue("@conta_id", conta_id);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = conta_id.ToString();
                textBox2.Text = reader.GetValue(0).ToString();
                textBox3.Text = reader.GetValue(1).ToString();
                try
                {
                    dateTimePicker1.Value = DateTime.Parse(reader.GetValue(2).ToString());
                }
                catch (Exception) { }
                textBox4.Text = reader.GetValue(3).ToString();
                if (reader.GetInt32(4) == 0)
                {
                    textBox5.Text = "Secretaria";
                }
                else if (reader.GetInt32(4) == 1)
                {
                    textBox5.Text = "Medico";
                }
                else if (reader.GetInt32(4) == 2)
                {
                    textBox5.Text = "Paciente";
                }
                textBox6.Text = reader.GetValue(5).ToString();
                textBox7.Text = reader.GetValue(6).ToString();

            }

            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
