namespace Nursityy
{
    partial class agendaDeAtendimentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            comboBox6 = new ComboBox();
            label14 = new Label();
            comboBox5 = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            comboBox4 = new ComboBox();
            label11 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox6 = new GroupBox();
            textBox26 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            label40 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.tela_inicio___fundo;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(41, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1186, 588);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar atendimento";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(51, 508);
            button1.Name = "button1";
            button1.Size = new Size(109, 46);
            button1.TabIndex = 22;
            button1.Text = "Criar Atendimento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.tela_inicio___fundo;
            groupBox2.Controls.Add(comboBox6);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(comboBox5);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(36, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1105, 277);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agendamento";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(743, 132);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(62, 21);
            comboBox6.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(738, 117);
            label14.Name = "label14";
            label14.Size = new Size(59, 13);
            label14.TabIndex = 39;
            label14.Text = "Retorno?";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(663, 132);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(62, 21);
            comboBox5.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(658, 117);
            label13.Name = "label13";
            label13.Size = new Size(44, 13);
            label13.TabIndex = 37;
            label13.Text = "Visita?";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 158);
            label12.Name = "label12";
            label12.Size = new Size(173, 13);
            label12.TabIndex = 36;
            label12.Text = "Observações do atendimento";
            label12.Click += label12_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 174);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(786, 85);
            textBox5.TabIndex = 35;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(504, 132);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(145, 21);
            comboBox4.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(499, 117);
            label11.Name = "label11";
            label11.Size = new Size(124, 13);
            label11.TabIndex = 33;
            label11.Text = "Tipo de atendimento";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(348, 132);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(145, 21);
            comboBox3.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 117);
            label10.Name = "label10";
            label10.Size = new Size(83, 13);
            label10.TabIndex = 31;
            label10.Text = "Especialidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 116);
            label9.Name = "label9";
            label9.Size = new Size(99, 13);
            label9.TabIndex = 30;
            label9.Text = "Nome Médico(a)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(19, 132);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(318, 20);
            textBox4.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 73);
            label8.Name = "label8";
            label8.Size = new Size(38, 13);
            label8.TabIndex = 28;
            label8.Text = "Plano";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(520, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 20);
            textBox3.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 73);
            label7.Name = "label7";
            label7.Size = new Size(59, 13);
            label7.TabIndex = 26;
            label7.Text = "Convênio";
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 20);
            textBox2.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(192, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 21);
            comboBox2.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 73);
            label6.Name = "label6";
            label6.Size = new Size(65, 13);
            label6.TabIndex = 23;
            label6.Text = "Prioridade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 73);
            label5.Name = "label5";
            label5.Size = new Size(106, 13);
            label5.TabIndex = 22;
            label5.Text = "Condição Especial";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 21);
            comboBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 28);
            label4.Name = "label4";
            label4.Size = new Size(75, 13);
            label4.TabIndex = 20;
            label4.Text = "Slot Agenda";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 20);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 89);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 20);
            textBox1.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 13);
            label1.TabIndex = 17;
            label1.Text = "Data";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(936, 428);
            label2.Name = "label2";
            label2.Size = new Size(41, 13);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // groupBox6
            // 
            groupBox6.BackgroundImage = Properties.Resources.tela_inicio___fundo;
            groupBox6.Controls.Add(textBox26);
            groupBox6.Controls.Add(label3);
            groupBox6.Controls.Add(listBox1);
            groupBox6.Controls.Add(label40);
            groupBox6.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.DarkSlateGray;
            groupBox6.Location = new Point(36, 41);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1105, 142);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "Buscar Paciente";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(19, 64);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(164, 20);
            textBox26.TabIndex = 18;
            textBox26.TextChanged += textBox26_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 49);
            label3.Name = "label3";
            label3.Size = new Size(62, 13);
            label3.TabIndex = 17;
            label3.Text = "Pesquisar";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(202, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(873, 108);
            listBox1.TabIndex = 10;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(936, 428);
            label40.Name = "label40";
            label40.Size = new Size(48, 13);
            label40.TabIndex = 9;
            label40.Text = "label40";
            // 
            // agendaDeAtendimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tela_inicio___fundo;
            ClientSize = new Size(1280, 665);
            Controls.Add(groupBox1);
            Name = "agendaDeAtendimentos";
            Text = "agendaDeAtendimentos";
            Load += agendaDeAtendimentos_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox6;
        private TextBox textBox26;
        private Label label3;
        private ListBox listBox1;
        private Label label40;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox5;
        private ComboBox comboBox4;
        private Label label11;
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox5;
        private Label label13;
        private ComboBox comboBox6;
        private Label label14;
        private Button button1;
    }
}