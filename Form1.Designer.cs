namespace CalculadoraRungeKuttaOrden4
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(208, 91, 15);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 86);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(770, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 33);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(90, 28);
            label6.Name = "label6";
            label6.Size = new Size(608, 28);
            label6.TabIndex = 13;
            label6.Text = "CALCULADORA METODO RUNGE-KUTTA DE ORDEN 4";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(241, 105, 16);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(162, 72, 13);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 105, 16);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(64, 426);
            button1.Name = "button1";
            button1.Size = new Size(151, 31);
            button1.TabIndex = 1;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 139);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 3;
            label1.Text = "y′(t)=f(t,y):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(113, 188);
            label2.Name = "label2";
            label2.Size = new Size(31, 21);
            label2.TabIndex = 5;
            label2.Text = "y0:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(160, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(114, 241);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 7;
            label3.Text = "x0:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(160, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(114, 296);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 9;
            label4.Text = "xF:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(160, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 23);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(121, 348);
            label5.Name = "label5";
            label5.Size = new Size(24, 21);
            label5.TabIndex = 11;
            label5.Text = "h:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(160, 350);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(122, 23);
            textBox5.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ControlLight;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(447, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 315);
            listBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(241, 105, 16);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(162, 72, 13);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 105, 16);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(235, 427);
            button2.Name = "button2";
            button2.Size = new Size(150, 31);
            button2.TabIndex = 14;
            button2.Text = "BORRAR TODO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 124);
            label7.Name = "label7";
            label7.Size = new Size(53, 16);
            label7.TabIndex = 15;
            label7.Text = "Funcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(114, 214);
            label8.Name = "label8";
            label8.Size = new Size(141, 15);
            label8.TabIndex = 16;
            label8.Text = "Condición inicial para y";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(121, 267);
            label9.Name = "label9";
            label9.Size = new Size(140, 15);
            label9.TabIndex = 17;
            label9.Text = "Condición inicial para x";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(121, 323);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 18;
            label10.Text = "Valor final de x";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(127, 376);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 19;
            label11.Text = "Tamaño del paso";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 500);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xF:";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private ListBox listBox1;
        private Label label6;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
