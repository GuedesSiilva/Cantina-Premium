namespace Cantina_Premium
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            listBox1 = new ListBox();
            listBox3 = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button5 = new Button();
            listBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(243, 241, 238);
            listBox1.Cursor = Cursors.No;
            listBox1.Font = new Font("Inter SemiBold", 9.4F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(325, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(281, 454);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.FromArgb(243, 241, 238);
            listBox3.Cursor = Cursors.No;
            listBox3.Font = new Font("Inter SemiBold", 9.4F, FontStyle.Bold);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 18;
            listBox3.Location = new Point(33, 109);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(281, 454);
            listBox3.TabIndex = 2;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 3;
            label1.Text = "| 🖥️ Pedidos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 28);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 77);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 7;
            label2.Text = "🕑 Em Preparo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(405, 77);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 8;
            label3.Text = "\U0001f9fe Prontos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(685, 77);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 9;
            label4.Text = "✔️ Entregues";
            label4.Click += label4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 569);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "↩️";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(243, 241, 238);
            listBox2.Cursor = Cursors.No;
            listBox2.Font = new Font("Inter SemiBold", 9.4F, FontStyle.Bold);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 18;
            listBox2.Location = new Point(618, 109);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(281, 454);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(202, 196, 183);
            ClientSize = new Size(930, 604);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button5;
        private ListBox listBox2;
    }
}