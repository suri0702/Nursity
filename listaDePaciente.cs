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
    public partial class listaDePaciente : Form
    {
        public listaDePaciente()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;
        private void atualizarLista(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT conta_id, conta_data_criacao, conta_nome, conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF, conta_CNS, conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email FROM Conta WHERE conta_tipo=2 AND (conta_nome LIKE @query OR conta_CPF LIKE @query)";
            command.Parameters.AddWithValue("@query", query+"%");

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            listBox1.Items.Clear();


            while (reader.Read())
            { listBox1.Items.Add(new conta(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2))); }
            

            con.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void listaDePaciente_Load(object sender, EventArgs e)
        {
            atualizarLista("");
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void label26_Click(object sender, EventArgs e)
        {
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
        }

        private void label30_Click(object sender, EventArgs e)
        {
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
        }

        private void label33_Click(object sender, EventArgs e)
        {
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            atualizarLista(textBox26.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || listBox1.SelectedIndex >= listBox1.Items.Count)
                return;

            int conta_id = ((conta)listBox1.SelectedItem).getId();

            command = con.CreateCommand();
            command.CommandText = "SELECT conta_id, conta_data_criacao, conta_nome, conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF, conta_CNS, conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email FROM Conta WHERE conta_id = @id";
            command.Parameters.AddWithValue("@id", conta_id);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox27.Text = conta_id.ToString();
                textBox28.Text = reader.GetValue(0).ToString();
                textBox1.Text = reader.GetString(1);
                textBox4.Text = reader.GetString(2);

                DateTime aniversario = new DateTime();
                if (DateTime.TryParse(reader.GetValue(3).ToString(), out aniversario))
                    dateTimePicker1.Value = aniversario;

                comboBox2.SelectedItem = reader.GetString(4);
                textBox2.Text = reader.GetString(5);
                comboBox1.SelectedItem = reader.GetString(6);
                textBox3.Text = reader.GetString(7);
                comboBox3.SelectedItem = reader.GetString(8);
                textBox8.Text = reader.GetString(9);
                textBox5.Text = reader.GetString(10);
                textBox9.Text = reader.GetString(11);
                comboBox7.SelectedItem = reader.GetString(12);
                textBox10.Text = reader.GetString(13);
                textBox11.Text = reader.GetString(14);
                textBox12.Text = reader.GetString(15);
                textBox13.Text = reader.GetString(16);
                textBox14.Text = reader.GetString(17);
                textBox15.Text = reader.GetString(18);
                textBox16.Text = reader.GetString(19);
                textBox17.Text = reader.GetString(20);
                textBox18.Text = reader.GetString(21);
                textBox19.Text = reader.GetString(22);
                textBox20.Text = reader.GetString(23);
                textBox21.Text = reader.GetString(24);
                textBox22.Text = reader.GetString(25);
                textBox25.Text = reader.GetString(26);




            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Por favor, verificar as informações dos campos de cadastro do paciente!");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "UPDATE Conta SET conta_nome = @nome, conta_nome_social = @nomesocial, conta_aniversario = @aniversario, conta_sexo = @sexo, conta_nome_mae = @nomemae, conta_estado_civil = @estadocivil, conta_nome_conjuge = @nomeconjuge, conta_tipo_sanguineo = @tiposanguineo, conta_matricula_SAME = @matriculaSAME, conta_RG = @RG, conta_RG_orgao_emissor = @orgaoemissor, conta_RG_UF= @UFcep, conta_RG_expedicao = @expedicao, conta_CPF = @CPF, conta_CNS = CNS, conta_CEP = @CEP, conta_endereco = @endereco, conta_end_numero = @numero, conta_end_complemento = @complemento, conta_end_bairro = @bairro, conta_end_cidade = @cidade, conta_end_UF = @UFend, conta_end_pais = @pais, conta_celular = @celular, conta_celular2 = @celular2, conta_email = @email WHERE conta_id = @id";
            command.Parameters.AddWithValue("@nome", textBox1.Text);
            command.Parameters.AddWithValue("@nomesocial", textBox4.Text);
            command.Parameters.AddWithValue("@aniversario", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@sexo", comboBox2.SelectedIndex);
            command.Parameters.AddWithValue("@nomemae", textBox2.Text);
            command.Parameters.AddWithValue("@estadocivil", comboBox1.SelectedIndex);
            command.Parameters.AddWithValue("@nomeconjuge", textBox3.Text);
            command.Parameters.AddWithValue("@tiposanguineo", comboBox3.SelectedIndex);
            command.Parameters.AddWithValue("@matriculaSAME", textBox8.Text);
            command.Parameters.AddWithValue("@RG", textBox5.Text);
            command.Parameters.AddWithValue("@orgaoemissor", textBox9.Text);
            command.Parameters.AddWithValue("@UFcep", comboBox7.SelectedIndex);
            command.Parameters.AddWithValue("@expedicao", textBox10.Text);
            command.Parameters.AddWithValue("@CPF", textBox11.Text);
            command.Parameters.AddWithValue("@CNS", textBox12.Text);
            command.Parameters.AddWithValue("@CEP", textBox13.Text);
            command.Parameters.AddWithValue("@endereco", textBox14.Text);
            command.Parameters.AddWithValue("@numero", textBox15.Text);
            command.Parameters.AddWithValue("@complemento", textBox16.Text);
            command.Parameters.AddWithValue("@bairro", textBox17.Text);
            command.Parameters.AddWithValue("@cidade", textBox18.Text);
            command.Parameters.AddWithValue("@UFend", textBox19.Text);
            command.Parameters.AddWithValue("@pais", textBox20.Text);
            command.Parameters.AddWithValue("@celular", textBox21.Text);
            command.Parameters.AddWithValue("@celular2", textBox22.Text);
            command.Parameters.AddWithValue("@email", textBox25.Text);
            command.Parameters.AddWithValue("@id", textBox27.Text);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("A conta foi atualizada com sucesso!");
            else
                MessageBox.Show("Erro na atualização da conta!");

            con.Close();
        }
    }
}
