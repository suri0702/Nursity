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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void atualizaLista(string query)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            con.Open();
            command.CommandText = "SELECT conta_id, conta_nome, conta_tipo FROM Conta WHERE conta_tipo in (0, 1) AND (conta_nome LIKE @query OR conta_celular LIKE @query) ORDER BY conta_tipo";
            command.Parameters.AddWithValue("query", query + "%");

            SqlDataReader reader = command.ExecuteReader();

            listBox2.Items.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(new conta(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));

            }

            con.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void adminPage_Load(object sender, EventArgs e)
        {
            atualizaLista("");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            atualizaLista(textBox5.Text);

        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int conta_id;
            try
            {
                conta_id = ((conta)listBox2.SelectedItem).getId();
            }
            catch (Exception)
            {
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_nome, conta_nome, conta_aniversario, conta_celular, conta_tipo, conta_comentarios, conta_data_criacao FROM [User], conta WHERE user_id = conta_user_id AND conta_id = @id";
            command.Parameters.AddWithValue("@id", conta_id);
            con.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox4.Text = conta_id.ToString();
                textBox5.Text = reader.GetValue(0).ToString();
                textBox7.Text = reader.GetValue(1).ToString();
                textBox8.Text = reader.GetValue(2).ToString();
                textBox9.Text = reader.GetValue(3).ToString();

                if (reader.GetInt32(4) == 0)
                    textBox10.Text = "Secretaria";
                else
                    textBox10.Text = "Medico";

                textBox13.Text = reader.GetValue(5).ToString();
                textBox11.Text = reader.GetValue(6).ToString();
            }

            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validaInputs())
            {
                MessageBox.Show("Por favor, verificar as informações dos campos de criação de conta!");
                return;
            }

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "INSERT INTO [User] (user_nome, user_senha) VALUES(@username,@senha)";
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@senha", utilities.hashPassword(textBox2.Text));
            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                command.CommandText = "SELECT user_id FROM [User] WHERE user_nome = @username";
                int user_id = (int)command.ExecuteScalar();

                command.CommandText = "INSERT INTO conta (conta_user_id, conta_nome, conta_tipo, conta_comentarios, conta_data_criacao) VALUES (@user_id, @nome, @tipo, @comentarios, @data)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@user_id", user_id);
                command.Parameters.AddWithValue("@nome", textBox3.Text);
                command.Parameters.AddWithValue("@tipo", comboBox1.SelectedIndex);
                command.Parameters.AddWithValue("@comentarios", textBox12.Text);
                command.Parameters.AddWithValue("@data", DateTime.Now);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("A conta foi criada com sucesso!");

                }
                else
                    MessageBox.Show("Erro na criação da conta!");
            }
            else
                MessageBox.Show("Erro na criação da conta!");
            con.Close();
            atualizaLista("");

        }

        private bool validaInputs()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                return false;

            if (comboBox1.SelectedIndex < 0)
                return false;

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
                return;

            SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "DELETE FROM [User] WHERE user_nome = @username";
            command.Parameters.AddWithValue("@username", textBox7.Text);
            con.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("A conta foi deletada com sucesso!");
            else
                MessageBox.Show("Erro ao deletar a conta!");
            con.Close();
            atualizaLista("");
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox13.Clear();
            textBox11.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
