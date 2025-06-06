namespace Cantina_Premium
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            AddItem = new Button();
            button5 = new Button();
            Remove = new Button();
            Quant = new Button();
            EditItem = new Button();
            listEstoque = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 28);
            label1.Name = "label1";
            label1.Size = new Size(199, 41);
            label1.TabIndex = 8;
            label1.Text = "| 📦 Estoque";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 28);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // AddItem
            // 
            AddItem.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItem.Location = new Point(582, 95);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(301, 80);
            AddItem.TabIndex = 11;
            AddItem.Text = "➕ Adicionar Item";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 569);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "↩️";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Remove
            // 
            Remove.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.Location = new Point(582, 219);
            Remove.Name = "Remove";
            Remove.Size = new Size(301, 80);
            Remove.TabIndex = 16;
            Remove.Text = "🗑️ Remover Item";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // Quant
            // 
            Quant.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quant.Location = new Point(582, 340);
            Quant.Name = "Quant";
            Quant.Size = new Size(301, 80);
            Quant.TabIndex = 17;
            Quant.Text = "🔂 Alterar Quantidade";
            Quant.UseVisualStyleBackColor = true;
            Quant.Click += Quant_Click;
            // 
            // EditItem
            // 
            EditItem.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditItem.Location = new Point(582, 459);
            EditItem.Name = "EditItem";
            EditItem.Size = new Size(301, 80);
            EditItem.TabIndex = 18;
            EditItem.Text = "✏️ Editar Item";
            EditItem.UseVisualStyleBackColor = true;
            EditItem.Click += EditItem_Click;
            // 
            // listEstoque
            // 
            listEstoque.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listEstoque.FormattingEnabled = true;
            listEstoque.ItemHeight = 22;
            listEstoque.Location = new Point(33, 95);
            listEstoque.Name = "listEstoque";
            listEstoque.Size = new Size(495, 444);
            listEstoque.TabIndex = 10;
            listEstoque.SelectedIndexChanged += Estoque_SelectedIndexChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(930, 604);
            Controls.Add(EditItem);
            Controls.Add(Quant);
            Controls.Add(Remove);
            Controls.Add(button5);
            Controls.Add(AddItem);
            Controls.Add(listEstoque);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button AddItem;
        private Button button5;
        private Button Remove;
        private Button Quant;
        private Button EditItem;
        private ListBox listEstoque;
    }
}