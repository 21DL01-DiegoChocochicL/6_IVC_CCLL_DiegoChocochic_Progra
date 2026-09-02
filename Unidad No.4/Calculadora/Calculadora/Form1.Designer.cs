namespace Calculadora
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
            textBox1 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnDiv = new Button();
            btnMen = new Button();
            btnMulti = new Button();
            btnMas = new Button();
            btnIgual = new Button();
            btnPorce = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 190);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(68, 190);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(124, 190);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 134);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(68, 134);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(124, 134);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 78);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(68, 78);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(124, 78);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 246);
            btn0.Name = "btn0";
            btn0.Size = new Size(106, 50);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(124, 246);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(50, 50);
            btnDecimal.TabIndex = 11;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(194, 78);
            btnC.Name = "btnC";
            btnC.Size = new Size(50, 50);
            btnC.TabIndex = 12;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(250, 78);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(50, 50);
            btnCE.TabIndex = 13;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(197, 134);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(50, 50);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMen
            // 
            btnMen.Location = new Point(250, 134);
            btnMen.Name = "btnMen";
            btnMen.Size = new Size(50, 50);
            btnMen.TabIndex = 15;
            btnMen.Text = "-";
            btnMen.UseVisualStyleBackColor = true;
            btnMen.Click += btnMen_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(197, 190);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(50, 50);
            btnMulti.TabIndex = 16;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnMas
            // 
            btnMas.Location = new Point(250, 190);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(50, 50);
            btnMas.TabIndex = 17;
            btnMas.Text = "+";
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(253, 246);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(50, 50);
            btnIgual.TabIndex = 18;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnPorce
            // 
            btnPorce.Location = new Point(197, 246);
            btnPorce.Name = "btnPorce";
            btnPorce.Size = new Size(50, 50);
            btnPorce.TabIndex = 19;
            btnPorce.Text = "%";
            btnPorce.UseVisualStyleBackColor = true;
            btnPorce.Click += btnPorce_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 303);
            Controls.Add(btnPorce);
            Controls.Add(btnIgual);
            Controls.Add(btnMas);
            Controls.Add(btnMulti);
            Controls.Add(btnMen);
            Controls.Add(btnDiv);
            Controls.Add(btnCE);
            Controls.Add(btnC);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDecimal;
        private Button btnC;
        private Button btnCE;
        private Button btnDiv;
        private Button btnMen;
        private Button btnMulti;
        private Button btnMas;
        private Button btnIgual;
        private Button btnPorce;
    }
}
