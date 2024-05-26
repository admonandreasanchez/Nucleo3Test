namespace Nucleo3Test
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HotTrack;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Transparent;
            textBox1.Location = new Point(209, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Transparent;
            textBox2.Location = new Point(330, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(209, 233);
            button1.Name = "button1";
            button1.Size = new Size(85, 35);
            button1.TabIndex = 2;
            button1.Text = "Suma";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(324, 233);
            button2.Name = "button2";
            button2.Size = new Size(100, 35);
            button2.TabIndex = 2;
            button2.Text = "Resta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HotTrack;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.MediumSpringGreen;
            textBox3.Location = new Point(345, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 160);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 4;
            label1.Text = "Dato 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Castellar", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(330, 160);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 5;
            label2.Text = "Dato 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Castellar", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(196, 271);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Castellar", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(196, 212);
            label4.Name = "label4";
            label4.Size = new Size(250, 18);
            label4.TabIndex = 7;
            label4.Text = "Operación Matemática";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(224, 18);
            label5.MaximumSize = new Size(200, 100);
            label5.Name = "label5";
            label5.Size = new Size(200, 100);
            label5.TabIndex = 8;
            label5.Text = "Welcome to Edmsoft";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Backscreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(655, 512);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Label label4;
        private Label label5;
    }
}
