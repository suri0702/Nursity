﻿using System;
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
    public partial class Preescricao : Form
    {
        int conta_id, paciente_id, appointment_id;
        public Preescricao(int conta_id, int paciente_id, int appointment_id)
        {
            InitializeComponent();
            this.conta_id = conta_id;
            this.paciente_id = paciente_id;
            this.appointment_id = appointment_id;
        }

        private void Preescricao_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
