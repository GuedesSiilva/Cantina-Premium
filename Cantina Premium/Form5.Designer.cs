namespace Cantina_Premium
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(268, 62);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(475, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
            label2.Font = new Font("Inter SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 248);
            label2.Name = "label2";
            label2.Size = new Size(99, 39);
            label2.TabIndex = 11;
            label2.Text = "MENU";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(243, 241, 238);
            button3.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(220, 308);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(243, 97);
            button3.TabIndex = 12;
            button3.Text = "\U0001f9d1‍🍳 Acesso a Cozinha";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 241, 238);
            button1.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(563, 308);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(243, 97);
            button1.TabIndex = 13;
            button1.Text = "🏪 Acesso ao Balcão";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(243, 241, 238);
            button2.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(220, 431);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(243, 97);
            button2.TabIndex = 14;
            button2.Text = "📦 Estoque";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(243, 241, 238);
            button4.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(563, 431);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(243, 97);
            button4.TabIndex = 15;
            button4.Text = "💵 Administração";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1028, 660);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label2;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}