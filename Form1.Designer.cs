namespace Nursityy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            boasvindasLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // boasvindasLabel
            // 
            boasvindasLabel.Anchor = AnchorStyles.None;
            boasvindasLabel.AutoSize = true;
            boasvindasLabel.BackColor = Color.Transparent;
            boasvindasLabel.FlatStyle = FlatStyle.Flat;
            boasvindasLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            boasvindasLabel.ForeColor = Color.FromArgb(248, 237, 239);
            boasvindasLabel.Location = new Point(594, 264);
            boasvindasLabel.Name = "boasvindasLabel";
            boasvindasLabel.Size = new Size(184, 19);
            boasvindasLabel.TabIndex = 0;
            boasvindasLabel.Text = "Bem-vindo ao Nursity";
            boasvindasLabel.TextAlign = ContentAlignment.MiddleCenter;
            boasvindasLabel.Click += boasvindasLabel_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(248, 237, 239);
            textBox1.Font = new Font("Tahoma", 8.5F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(563, 308);
            textBox1.Margin = new Padding(5, 25, 5, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 21);
            textBox1.TabIndex = 2;
            textBox1.Text = "Usuário";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(248, 237, 239);
            textBox2.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(563, 339);
            textBox2.Margin = new Padding(3, 3, 3, 10);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(246, 21);
            textBox2.TabIndex = 3;
            textBox2.Text = "Senha";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(248, 237, 239);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(641, 380);
            button1.Margin = new Padding(3, 10, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1370, 749);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(boasvindasLabel);
            Name = "Form1";
            Text = "Nursity";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label boasvindasLabel;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}