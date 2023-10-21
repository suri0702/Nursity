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
    public partial class pacientePage : Form
    {
        public pacientePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            cadastrarPaciente cadastrarPaciente = new cadastrarPaciente();
            cadastrarPaciente.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            listaDePaciente listaDePaciente = new listaDePaciente();
            listaDePaciente.ShowDialog();
            Show();
        }
    }
}
