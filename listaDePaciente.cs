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
            command.CommandText = "SELECT conta_id, conta_nome, conta_tipo, conta_data_criacao,conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF,conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email FROM Conta WHERE conta_tipo=2 AND (conta_nome LIKE @query OR conta_CPF LIKE @query)";
            command.Parameters.AddWithValue("@query", query + "%");

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
            command.CommandText = "SELECT conta_id, conta_data_criacao, conta_nome, conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF,conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email FROM Conta WHERE conta_id = @id";
            command.Parameters.AddWithValue("@id", conta_id);

            con.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox27.Text = conta_id.ToString();
                textBox28.Text = reader.GetValue(1).ToString();
                textBox1.Text = reader.GetString(2);
                textBox4.Text = reader.GetString(3);

                DateTime conta_aniversario = new DateTime();
                if (DateTime.TryParse(reader.GetValue(4).ToString(), out conta_aniversario))
                    dateTimePicker1.Value = conta_aniversario;

                if (reader.GetInt32(5) == 0)
                    comboBox2.SelectedItem = "Feminino";
                else
                    comboBox2.SelectedItem = "Masculino";

                textBox2.Text = reader.GetString(6);

                if (reader.GetInt32(7) == 0)
                    comboBox1.SelectedItem = "Solteiro";
                else if (reader.GetInt32(7) == 1)
                    comboBox1.SelectedItem = "Casado";
                else if (reader.GetInt32(7) == 2)
                    comboBox1.SelectedItem = "Separado";
                else if (reader.GetInt32(7) == 3)
                    comboBox1.SelectedItem = "Divorciado";
                else
                    comboBox1.SelectedItem = "Viúvo";


                textBox3.Text = reader.GetString(8);

                if (reader.GetInt32(9) == 0)
                    comboBox3.SelectedItem = "A+";
                else if (reader.GetInt32(9) == 1)
                    comboBox3.SelectedItem = "A-";
                else if (reader.GetInt32(9) == 2)
                    comboBox3.SelectedItem = "B+";
                else if (reader.GetInt32(9) == 3)
                    comboBox3.SelectedItem = "B-";
                else if (reader.GetInt32(9) == 4)
                    comboBox3.SelectedItem = "AB+";
                else if (reader.GetInt32(9) == 5)
                    comboBox3.SelectedItem = "AB-";
                else if (reader.GetInt32(9) == 6)
                    comboBox3.SelectedItem = "O+";
                else
                    comboBox3.SelectedItem = "O-";


                textBox8.Text = reader.GetString(10);
                textBox5.Text = reader.GetString(11);
                textBox9.Text = reader.GetString(12);

                if (reader.GetInt32(13) == 0)
                    comboBox7.SelectedItem = "RO";
                else if (reader.GetInt32(13) == 1)
                    comboBox3.SelectedItem = "AC";
                else if (reader.GetInt32(13) == 2)
                    comboBox3.SelectedItem = "AM";
                else if (reader.GetInt32(13) == 3)
                    comboBox3.SelectedItem = "RR";
                else if (reader.GetInt32(13) == 4)
                    comboBox3.SelectedItem = "PA";
                else if (reader.GetInt32(13) == 5)
                    comboBox3.SelectedItem = "AP";
                else if (reader.GetInt32(13) == 6)
                    comboBox3.SelectedItem = "TO";
                else if (reader.GetInt32(13) == 7)
                    comboBox3.SelectedItem = "MA";
                else if (reader.GetInt32(13) == 8)
                    comboBox3.SelectedItem = "PI";
                else if (reader.GetInt32(13) == 9)
                    comboBox3.SelectedItem = "CE";
                else if (reader.GetInt32(13) == 10)
                    comboBox3.SelectedItem = "RN";
                else if (reader.GetInt32(13) == 11)
                    comboBox3.SelectedItem = "PB";
                else if (reader.GetInt32(13) == 12)
                    comboBox3.SelectedItem = "PE";
                else if (reader.GetInt32(13) == 13)
                    comboBox3.SelectedItem = "AL";
                else if (reader.GetInt32(13) == 14)
                    comboBox3.SelectedItem = "SE";
                else if (reader.GetInt32(13) == 15)
                    comboBox3.SelectedItem = "BA";
                else if (reader.GetInt32(13) == 16)
                    comboBox3.SelectedItem = "MG";
                else if (reader.GetInt32(13) == 17)
                    comboBox3.SelectedItem = "ES";
                else if (reader.GetInt32(13) == 18)
                    comboBox3.SelectedItem = "RJ";
                else if (reader.GetInt32(13) == 19)
                    comboBox3.SelectedItem = "SP";
                else if (reader.GetInt32(13) == 20)
                    comboBox3.SelectedItem = "PR";
                else if (reader.GetInt32(13) == 21)
                    comboBox3.SelectedItem = "SC";
                else if (reader.GetInt32(13) == 22)
                    comboBox3.SelectedItem = "RS";
                else if (reader.GetInt32(13) == 23)
                    comboBox3.SelectedItem = "MS";
                else if (reader.GetInt32(13) == 24)
                    comboBox3.SelectedItem = "MT";
                else if (reader.GetInt32(13) == 25)
                    comboBox3.SelectedItem = "GO";
                else
                    comboBox3.SelectedItem = "DF";


                textBox10.Text = reader.GetString(14);
                textBox11.Text = reader.GetString(15);
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
            if (textBox1.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Por favor, verificar as informações dos campos de cadastro do paciente!");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "UPDATE Conta SET conta_nome = @nome, conta_nome_social = @nomesocial, conta_aniversario = @aniversario, conta_sexo = @sexo, conta_nome_mae = @nomemae, conta_estado_civil = @estadocivil, conta_nome_conjuge = @nomeconjuge, conta_tipo_sanguineo = @tiposanguineo, conta_matricula_SAME = @matriculaSAME, conta_RG = @RG, conta_RG_orgao_emissor = @orgaoemissor, conta_RG_UF= @UFcep, conta_RG_expedicao = @expedicao, conta_CPF = @CPF, conta_CEP = @CEP, conta_endereco = @endereco, conta_end_numero = @numero, conta_end_complemento = @complemento, conta_end_bairro = @bairro, conta_end_cidade = @cidade, conta_end_UF = @UFend, conta_end_pais = @pais, conta_celular = @celular, conta_celular2 = @celular2, conta_email = @email WHERE conta_id = @id";
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
