using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nursityy
{
    public partial class doctorPage : Form
    {
        int conta_id;
        public doctorPage(int id)
        {
            InitializeComponent();
            conta_id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            EditarConta editarConta = new EditarConta(conta_id);
            editarConta.ShowDialog();
            Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            atendimentosAgendados atendimentosAgendados = new atendimentosAgendados(conta_id);
            atendimentosAgendados.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
