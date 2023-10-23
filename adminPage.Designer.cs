namespace Nursityy
{
    partial class adminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
            groupBox1 = new GroupBox();
            textBox12 = new TextBox();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            colorDialog1 = new ColorDialog();
            groupBox3 = new GroupBox();
            textBox13 = new TextBox();
            button2 = new Button();
            textBox11 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            textBox10 = new TextBox();
            label14 = new Label();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(288, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 455);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Criar Conta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.White;
            textBox12.ForeColor = Color.DarkSlateGray;
            textBox12.Location = new Point(86, 214);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(158, 162);
            textBox12.TabIndex = 9;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(73, 399);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 6;
            button1.Text = "Criar conta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(9, 212);
            label11.Name = "label11";
            label11.Size = new Size(77, 13);
            label11.TabIndex = 8;
            label11.Text = "Observação:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(43, 188);
            label10.Name = "label10";
            label10.Size = new Size(37, 13);
            label10.TabIndex = 7;
            label10.Text = "Tipo :";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Secretária", "Médico" });
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Tahoma", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.DarkSlateGray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1" });
            comboBox1.Location = new Point(86, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 21);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.DarkSlateGray;
            textBox3.Location = new Point(86, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 22);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(38, 154);
            label3.Name = "label3";
            label3.Size = new Size(42, 13);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(86, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 22);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(86, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 22);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(45, 13);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 84);
            label1.Name = "label1";
            label1.Size = new Size(53, 13);
            label1.TabIndex = 0;
            label1.Text = "Usuário:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Snow;
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.DarkSlateGray;
            groupBox2.Location = new Point(546, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 455);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pesquisar Conta";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.DarkSlateGray;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(12, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(240, 326);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 100);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.ForeColor = Color.DarkSlateGray;
            textBox6.Location = new Point(66, 49);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(186, 22);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(48, 13);
            label6.TabIndex = 0;
            label6.Text = "Buscar:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Snow;
            groupBox3.BackgroundImage = (Image)resources.GetObject("groupBox3.BackgroundImage");
            groupBox3.Controls.Add(textBox13);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox11);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(textBox10);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(textBox8);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.DarkSlateGray;
            groupBox3.Location = new Point(817, 161);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 455);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Exibir Conta";
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.FromArgb(224, 224, 224);
            textBox13.ForeColor = Color.DarkSlateGray;
            textBox13.Location = new Point(90, 213);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(162, 115);
            textBox13.TabIndex = 22;
            // 
            // button2
            // 
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(90, 377);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 9;
            button2.Text = "Excluir conta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(224, 224, 224);
            textBox11.ForeColor = Color.DarkSlateGray;
            textBox11.Location = new Point(90, 334);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(162, 22);
            textBox11.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(19, 338);
            label16.Name = "label16";
            label16.Size = new Size(64, 13);
            label16.TabIndex = 20;
            label16.Text = "Criado em";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(12, 213);
            label15.Name = "label15";
            label15.Size = new Size(74, 13);
            label15.TabIndex = 19;
            label15.Text = "Observação";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(224, 224, 224);
            textBox10.ForeColor = Color.DarkSlateGray;
            textBox10.Location = new Point(90, 185);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(162, 22);
            textBox10.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(19, 189);
            label14.Name = "label14";
            label14.Size = new Size(31, 13);
            label14.TabIndex = 17;
            label14.Text = "Tipo";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(224, 224, 224);
            textBox9.ForeColor = Color.DarkSlateGray;
            textBox9.Location = new Point(90, 159);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(162, 22);
            textBox9.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(19, 163);
            label13.Name = "label13";
            label13.Size = new Size(46, 13);
            label13.TabIndex = 15;
            label13.Text = "Celular";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(224, 224, 224);
            textBox8.ForeColor = Color.DarkSlateGray;
            textBox8.Location = new Point(90, 131);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 22);
            textBox8.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 135);
            label12.Name = "label12";
            label12.Size = new Size(72, 13);
            label12.TabIndex = 13;
            label12.Text = "Aniversário";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += label12_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(224, 224, 224);
            textBox7.ForeColor = Color.DarkSlateGray;
            textBox7.Location = new Point(90, 104);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(162, 22);
            textBox7.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(19, 108);
            label9.Name = "label9";
            label9.Size = new Size(39, 13);
            label9.TabIndex = 11;
            label9.Text = "Nome";
            label9.Click += label9_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(224, 224, 224);
            textBox5.ForeColor = Color.DarkSlateGray;
            textBox5.Location = new Point(90, 76);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 22);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(73, 100);
            label5.Name = "label5";
            label5.Size = new Size(0, 13);
            label5.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 81);
            label8.Name = "label8";
            label8.Size = new Size(50, 13);
            label8.TabIndex = 9;
            label8.Text = "Usuário";
            label8.Click += label8_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(224, 224, 224);
            textBox4.ForeColor = Color.DarkSlateGray;
            textBox4.Location = new Point(90, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 22);
            textBox4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 54);
            label7.Name = "label7";
            label7.Size = new Size(56, 13);
            label7.TabIndex = 0;
            label7.Text = "ID Conta";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // adminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "adminPage";
            Text = "adminPage";
            Load += adminPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label6;
        private ColorDialog colorDialog1;
        private Label label10;
        private ComboBox comboBox1;
        private Label label11;
        private Button button1;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox8;
        private Label label12;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox10;
        private Label label14;
        private TextBox textBox9;
        private Label label13;
        private Label label15;
        private Button button2;
        private TextBox textBox11;
        private Label label16;
        private TextBox textBox12;
        private TextBox textBox13;
        private ListBox listBox1;
    }
}