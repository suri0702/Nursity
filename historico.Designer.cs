namespace Nursityy
{
    partial class historico
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
            label1 = new Label();
            groupBox6 = new GroupBox();
            textBox26 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            label40 = new Label();
            groupBox1 = new GroupBox();
            listBox2 = new ListBox();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(638, 20);
            label1.Name = "label1";
            label1.Size = new Size(184, 19);
            label1.TabIndex = 7;
            label1.Text = "Histórico De Paciente";
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
            groupBox6.Location = new Point(47, 56);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1128, 142);
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
            listBox1.Size = new Size(901, 108);
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
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.tela_inicio___fundo;
            groupBox1.Controls.Add(listBox2);
            groupBox1.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(47, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1128, 655);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(167, 603);
            listBox2.MaximumSize = new Size(2000, 2000);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(901, 108);
            listBox2.TabIndex = 19;
            // 
            // historico
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.tela_inicio___fundo;
            ClientSize = new Size(1203, 640);
            Controls.Add(groupBox1);
            Controls.Add(groupBox6);
            Controls.Add(label1);
            Name = "historico";
            Text = "historico";
            Load += historico_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox6;
        private TextBox textBox26;
        private Label label3;
        private ListBox listBox1;
        private Label label40;
        private GroupBox groupBox1;
        private ListBox listBox2;
    }
}