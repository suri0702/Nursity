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
    public partial class anamnese : Form
    {
        int conta_id, paciente_id, appointment_id;
        public anamnese(int conta_id, int paciente_id, int appointment_id)
        {
            InitializeComponent();

            this.conta_id = conta_id;
            this.paciente_id = paciente_id;
            this.appointment_id = appointment_id;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void anamnese_Load(object sender, EventArgs e)
        {

        }
    }
}
