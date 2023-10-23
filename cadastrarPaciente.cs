using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nursityy
{
    public partial class cadastrarPaciente : Form
    {
        public cadastrarPaciente()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Properties.Resources.connectionString);
        SqlCommand command;

        private void atualizarLista(string query)
        {
            command = con.CreateCommand();
            command.CommandText = "SELECT conta_nome, conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF, conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email FROM Conta WHERE conta_tipo=2 AND (conta_nome LIKE @query OR conta_CPF LIKE @query";

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox11.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "")
            {
                MessageBox.Show("Por favor, verificar as informações dos campos de cadastro do paciente!");
                return;
            }

            command = con.CreateCommand();
            command.CommandText = "INSERT INTO conta(conta_nome, conta_nome_social, conta_aniversario, conta_sexo, conta_nome_mae, conta_estado_civil, conta_nome_conjuge, conta_tipo_sanguineo, conta_matricula_SAME, conta_RG, conta_RG_orgao_emissor, conta_RG_UF, conta_RG_expedicao, conta_CPF, conta_CEP, conta_endereco, conta_end_numero, conta_end_complemento, conta_end_bairro, conta_end_cidade, conta_end_UF, conta_end_pais, conta_celular, conta_celular2, conta_email, conta_data_criacao, conta_tipo) VALUES (@nome, @nomesocial, @aniversario, @sexo, @nomemae, @estadocivil, @nomeconjuge, @tiposanguineo, @matriculaSAME, @RG, @orgaoemissor, @UFcep, @expedicao, @CPF, @CNS, @CEP, @endereco, @numero, @complemento, @bairro, @cidade, @UFend, @pais, @celular, @celular2, @email, @data, 2)";
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
            command.Parameters.AddWithValue("@email", textBox23.Text);
            command.Parameters.AddWithValue("@data", DateTime.Now);

            con.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Paciente cadastrado com sucesso!");
            }
            else
                MessageBox.Show("Erro no cadastro do paciente!");

            con.Close();
            atualizarLista("");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
