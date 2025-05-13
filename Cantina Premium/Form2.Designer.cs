namespace Cantina_Premium
{
    partial class Form2
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
            Cardapio = new ListBox();
            button1 = new Button();
            Pedindo = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.FromArgb(202, 196, 183);
            Cardapio.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cardapio.FormattingEnabled = true;
            Cardapio.ItemHeight = 24;
            Cardapio.Location = new Point(12, 2);
            Cardapio.Name = "Cardapio";
            Cardapio.Size = new Size(499, 412);
            Cardapio.TabIndex = 0;
            Cardapio.SelectedIndexChanged += Cardapio_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 255, 0);
            button1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(583, 257);
            button1.Name = "button1";
            button1.Size = new Size(146, 45);
            button1.TabIndex = 1;
            button1.Text = "➕ Adicionar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Pedindo
            // 
            Pedindo.BackColor = Color.FromArgb(202, 196, 183);
            Pedindo.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pedindo.FormattingEnabled = true;
            Pedindo.ItemHeight = 19;
            Pedindo.Location = new Point(528, 2);
            Pedindo.Name = "Pedindo";
            Pedindo.Size = new Size(260, 232);
            Pedindo.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(230, 255, 0);
            button2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(583, 320);
            button2.Name = "button2";
            button2.Size = new Size(146, 45);
            button2.TabIndex = 3;
            button2.Text = "➖ Remover";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(230, 255, 0);
            button3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(528, 385);
            button3.Name = "button3";
            button3.Size = new Size(260, 45);
            button3.TabIndex = 4;
            button3.Text = "✔️ Finalizar Pedido";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 241, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Pedindo);
            Controls.Add(button1);
            Controls.Add(Cardapio);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Cardapio;
        private Button button1;
        private ListBox Pedindo;
        private Button button2;
        private Button button3;
    }
}