﻿namespace Cantina_Premium
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            PedidosBalcao = new ListBox();
            ComandaBalcao = new ListBox();
            HistoricoBalcao = new ListBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(618, 305);
            label3.Name = "label3";
            label3.Size = new Size(139, 30);
            label3.TabIndex = 23;
            label3.Text = "🕑 Histórico";
            label3.Click += label3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 569);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 21;
            button4.Text = "↩️";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(469, 541);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(433, 50);
            button3.TabIndex = 20;
            button3.Text = "📤 Entregar Pedido";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 31);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 71);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 16;
            label2.Text = "📓 Comanda";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 71);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 14;
            label1.Text = " 🛎️ Pedidos";
            // 
            // PedidosBalcao
            // 
            PedidosBalcao.BackColor = Color.FromArgb(243, 241, 238);
            PedidosBalcao.DrawMode = DrawMode.OwnerDrawFixed;
            PedidosBalcao.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PedidosBalcao.FormattingEnabled = true;
            PedidosBalcao.ItemHeight = 18;
            PedidosBalcao.Location = new Point(33, 104);
            PedidosBalcao.Name = "PedidosBalcao";
            PedidosBalcao.Size = new Size(406, 436);
            PedidosBalcao.TabIndex = 24;
            PedidosBalcao.DrawItem += PedidosBalcao_DrawItem;
            PedidosBalcao.SelectedIndexChanged += PedidosBalcao_SelectedIndexChanged;
            // 
            // ComandaBalcao
            // 
            ComandaBalcao.BackColor = Color.FromArgb(243, 241, 238);
            ComandaBalcao.DrawMode = DrawMode.OwnerDrawFixed;
            ComandaBalcao.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComandaBalcao.FormattingEnabled = true;
            ComandaBalcao.ItemHeight = 22;
            ComandaBalcao.Location = new Point(469, 104);
            ComandaBalcao.Name = "ComandaBalcao";
            ComandaBalcao.Size = new Size(433, 180);
            ComandaBalcao.TabIndex = 25;
            ComandaBalcao.DrawItem += ComandaBalcao_DrawItem;
            ComandaBalcao.SelectedIndexChanged += ComandaBalcao_SelectedIndexChanged_1;
            // 
            // HistoricoBalcao
            // 
            HistoricoBalcao.BackColor = Color.FromArgb(243, 241, 238);
            HistoricoBalcao.DrawMode = DrawMode.OwnerDrawFixed;
            HistoricoBalcao.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HistoricoBalcao.FormattingEnabled = true;
            HistoricoBalcao.ItemHeight = 22;
            HistoricoBalcao.Location = new Point(469, 338);
            HistoricoBalcao.Name = "HistoricoBalcao";
            HistoricoBalcao.Size = new Size(433, 202);
            HistoricoBalcao.TabIndex = 26;
            HistoricoBalcao.DrawItem += HistoricoBalcao_DrawItem;
            HistoricoBalcao.SelectedIndexChanged += HistoricoBalcao_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 569);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 27;
            button5.Text = "↩️";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(930, 604);
            Controls.Add(button5);
            Controls.Add(HistoricoBalcao);
            Controls.Add(ComandaBalcao);
            Controls.Add(PedidosBalcao);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private ListBox HistoricoBalcao;
        private ListBox PedidosBalcao;
        private ListBox ComandaBalcao;
        private Button button5;
    }
}