using System.Data.SqlClient;
namespace Nursityy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void boasvindasLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Nursityy.Properties.Resources.connectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT user_id FROM [user] WHERE user_nome=@username AND user_senha=@password";
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", utilities.hashPassword(textBox2.Text));
            con.Open();
            var result = command.ExecuteScalar();
            con.Close();

            if (result != null)
            {
                if (textBox1.Text == "admin")
                {
                    Hide();
                    adminPage AdminPage = new adminPage();
                    AdminPage.ShowDialog();
                    Show();

                }
                else
                {
                    con.Open();
                    command.CommandText = "SELECT conta_id,conta_tipo FROM Conta WHERE conta_user_id=@user_id";
                    command.Parameters.AddWithValue("user_id", result.ToString());
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        int conta_id = reader.GetInt32(0);//primeira coluna
                        int conta_tipo = reader.GetInt32(1);//segunda coluna
                        con.Close();

                        if (conta_tipo == 0) //secretaria
                        {
                            Hide();
                            secretaryPage SecretaryPage = new secretaryPage(conta_id);
                            SecretaryPage.ShowDialog();
                            Show();
                        }
                        else if (conta_tipo == 1) //medico
                        {
                            Hide();
                            doctorPage DoctorPage = new doctorPage(conta_id);
                            DoctorPage.ShowDialog();
                            Show();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Falha na autenticação!");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}