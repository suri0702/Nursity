namespace Nursityy
{
    partial class editarReservaAtendimento
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
            button1 = new Button();
            textBox6 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            textBox27 = new TextBox();
            label14 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label38 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(744, 448);
            button1.Name = "button1";
            button1.Size = new Size(173, 84);
            button1.TabIndex = 28;
            button1.Text = "Editar reserva do atendimento";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(224, 224, 224);
            textBox6.Location = new Point(773, 41);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(299, 20);
            textBox6.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(773, 24);
            label13.Name = "label13";
            label13.Size = new Size(86, 13);
            label13.TabIndex = 23;
            label13.Text = "Agendado por";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(474, 24);
            label12.Name = "label12";
            label12.Size = new Size(91, 13);
            label12.TabIndex = 21;
            label12.Text = "Slot da agenda";
            // 
            // textBox27
            // 
            textBox27.BackColor = Color.FromArgb(224, 224, 224);
            textBox27.Location = new Point(30, 39);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(145, 20);
            textBox27.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 25);
            label14.Name = "label14";
            label14.Size = new Size(97, 13);
            label14.TabIndex = 17;
            label14.Text = "ID Atendimento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(473, 65);
            label10.Name = "label10";
            label10.Size = new Size(74, 13);
            label10.TabIndex = 16;
            label10.Text = "Nome social";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(224, 224, 224);
            textBox4.Location = new Point(472, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(406, 20);
            textBox4.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(29, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 20);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 65);
            label1.Name = "label1";
            label1.Size = new Size(108, 13);
            label1.TabIndex = 0;
            label1.Text = "Nome do Paciente";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.tela_inicio___fundo;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(textBox27);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(27, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1101, 123);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalhes do atendimento";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(472, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 21);
            comboBox1.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 20);
            dateTimePicker1.TabIndex = 32;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(193, 24);
            label38.Name = "label38";
            label38.Size = new Size(85, 13);
            label38.TabIndex = 19;
            label38.Text = "Data da visita";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(936, 428);
            label7.Name = "label7";
            label7.Size = new Size(41, 13);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(641, 64);
            label6.Name = "label6";
            label6.Size = new Size(0, 13);
            label6.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(108, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1155, 557);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(955, 448);
            button2.Name = "button2";
            button2.Size = new Size(173, 84);
            button2.TabIndex = 29;
            button2.Text = "Excluir reserva do atendimento";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(506, 25);
            label3.Name = "label3";
            label3.Size = new Size(359, 27);
            label3.TabIndex = 24;
            label3.Text = "Editar Reserva De Atendimento";
            // 
            // editarReservaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Name = "editarReservaAtendimento";
            Text = "editarReservaAtendimento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox6;
        private Label label13;
        private Label label12;
        private TextBox textBox27;
        private Label label14;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private Label label38;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label3;
    }
}