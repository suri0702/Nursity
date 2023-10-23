namespace Nursityy
{
    partial class secretaryPage
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
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(718, 404);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(214, 104);
            button1.TabIndex = 0;
            button1.Text = "Editar Conta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(438, 241);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(214, 104);
            button2.TabIndex = 1;
            button2.Text = "Pacientes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(600, 23);
            label1.Name = "label1";
            label1.Size = new Size(170, 27);
            label1.TabIndex = 4;
            label1.Text = "Bem vindo(a)!";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LightYellow;
            button3.Location = new Point(718, 241);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(214, 104);
            button3.TabIndex = 5;
            button3.Text = "Agendar Atendimento";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.LightYellow;
            button4.Location = new Point(438, 404);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Size = new Size(214, 104);
            button4.TabIndex = 6;
            button4.Text = "Atendimentos agendados";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // secretaryPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "secretaryPage";
            Text = "secretaryPage";
            Load += secretaryPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}