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
    public partial class secretaryPage : Form
    {
        int conta_id;
        public secretaryPage(int id)
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
            pacientePage pacientePage = new pacientePage();
            pacientePage.ShowDialog();
            Show();
        }

        private void secretaryPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            agendaDeAtendimentos agendaDeAtendimentos = new agendaDeAtendimentos(conta_id);
            agendaDeAtendimentos.ShowDialog();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
            atendimentosAgendados atendimentosAgendados = new atendimentosAgendados(conta_id);
            atendimentosAgendados.ShowDialog();
            Show();

        }
    }
}
