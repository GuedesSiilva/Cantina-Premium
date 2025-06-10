namespace Cantina_Premium
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Dinheiro = new RadioButton();
            Credito = new RadioButton();
            Debito = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pix = new RadioButton();
            Consumo = new RadioButton();
            label2 = new Label();
            Viagem = new RadioButton();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Dinheiro
            // 
            Dinheiro.AutoSize = true;
            Dinheiro.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dinheiro.ForeColor = SystemColors.ControlText;
            Dinheiro.Location = new Point(23, 233);
            Dinheiro.Name = "Dinheiro";
            Dinheiro.Size = new Size(150, 34);
            Dinheiro.TabIndex = 3;
            Dinheiro.TabStop = true;
            Dinheiro.Text = "💵 Dinheiro";
            Dinheiro.UseVisualStyleBackColor = true;
            Dinheiro.CheckedChanged += Dinheiro_CheckedChanged_1;
            // 
            // Credito
            // 
            Credito.AutoSize = true;
            Credito.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Credito.ForeColor = SystemColors.ControlText;
            Credito.Location = new Point(23, 180);
            Credito.Name = "Credito";
            Credito.Size = new Size(139, 34);
            Credito.TabIndex = 4;
            Credito.TabStop = true;
            Credito.Text = "💳 Crédito";
            Credito.UseVisualStyleBackColor = true;
            // 
            // Debito
            // 
            Debito.AutoSize = true;
            Debito.BackColor = Color.FromArgb(202, 196, 183);
            Debito.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Debito.ForeColor = SystemColors.ControlText;
            Debito.Location = new Point(23, 76);
            Debito.Margin = new Padding(5);
            Debito.Name = "Debito";
            Debito.Size = new Size(131, 34);
            Debito.TabIndex = 5;
            Debito.TabStop = true;
            Debito.Text = "💳 Débito";
            Debito.TextAlign = ContentAlignment.TopCenter;
            Debito.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(321, 27);
            label1.TabIndex = 6;
            label1.Text = "Selecione a forma de pagamento:";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(202, 196, 183);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pix);
            groupBox1.Controls.Add(Debito);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Credito);
            groupBox1.Controls.Add(Dinheiro);
            groupBox1.Location = new Point(-4, -25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 476);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(37, 297);
            button1.Name = "button1";
            button1.Size = new Size(280, 43);
            button1.TabIndex = 8;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pix
            // 
            pix.AutoSize = true;
            pix.BackColor = Color.FromArgb(202, 196, 183);
            pix.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pix.ForeColor = SystemColors.ControlText;
            pix.Location = new Point(23, 129);
            pix.Name = "pix";
            pix.Size = new Size(89, 34);
            pix.TabIndex = 7;
            pix.TabStop = true;
            pix.Text = "❖ Pix";
            pix.UseVisualStyleBackColor = false;
            pix.CheckedChanged += pix_CheckedChanged;
            // 
            // Consumo
            // 
            Consumo.AutoSize = true;
            Consumo.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Consumo.ForeColor = SystemColors.ControlText;
            Consumo.Location = new Point(30, 76);
            Consumo.Name = "Consumo";
            Consumo.Size = new Size(255, 34);
            Consumo.TabIndex = 9;
            Consumo.TabStop = true;
            Consumo.Text = "😋 Consumo imediato";
            Consumo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(30, 34);
            label2.Name = "label2";
            label2.Size = new Size(288, 27);
            label2.TabIndex = 9;
            label2.Text = "Selecione a forma de entrega:";
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Viagem.ForeColor = SystemColors.ControlText;
            Viagem.Location = new Point(30, 129);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(142, 34);
            Viagem.TabIndex = 10;
            Viagem.TabStop = true;
            Viagem.Text = "✈️ Viagem";
            Viagem.UseVisualStyleBackColor = true;
            Viagem.CheckedChanged += Viagem_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(168, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(202, 196, 183);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(Viagem);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Consumo);
            groupBox2.Location = new Point(349, -25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 377);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(713, 336);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de Pagamentos";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton Dinheiro;
        private RadioButton Credito;
        private RadioButton Debito;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton pix;
        private Button button1;
        private Label label2;
        private RadioButton Consumo;
        private RadioButton Viagem;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}