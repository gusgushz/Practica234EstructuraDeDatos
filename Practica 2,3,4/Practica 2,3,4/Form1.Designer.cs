namespace Practica_2_3_4
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
            Factorial = new Label();
            Fibonacci = new Label();
            MáximoComúnDivisor = new Label();
            ResultFact = new Label();
            ResultFibo = new Label();
            ResultMCD = new Label();
            buttonFact = new Button();
            buttonFibo = new Button();
            buttonMCD = new Button();
            textBoxFact = new TextBox();
            textBoxFibo = new TextBox();
            textBoxMCD1 = new TextBox();
            textBoxMCD2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Factorial
            // 
            Factorial.AutoSize = true;
            Factorial.Location = new Point(86, 56);
            Factorial.Name = "Factorial";
            Factorial.Size = new Size(65, 20);
            Factorial.TabIndex = 0;
            Factorial.Text = "Factorial";
            // 
            // Fibonacci
            // 
            Fibonacci.Location = new Point(334, 56);
            Fibonacci.Name = "Fibonacci";
            Fibonacci.Size = new Size(74, 25);
            Fibonacci.TabIndex = 1;
            Fibonacci.Text = "Fibonacci";
            // 
            // MáximoComúnDivisor
            // 
            MáximoComúnDivisor.AutoSize = true;
            MáximoComúnDivisor.Location = new Point(558, 56);
            MáximoComúnDivisor.Name = "MáximoComúnDivisor";
            MáximoComúnDivisor.Size = new Size(164, 20);
            MáximoComúnDivisor.TabIndex = 2;
            MáximoComúnDivisor.Text = "Máximo Común Divisor";
            // 
            // ResultFact
            // 
            ResultFact.AutoSize = true;
            ResultFact.Location = new Point(50, 219);
            ResultFact.Name = "ResultFact";
            ResultFact.Size = new Size(135, 20);
            ResultFact.TabIndex = 3;
            ResultFact.Text = "Resultado Factorial";
            ResultFact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultFibo
            // 
            ResultFibo.AutoSize = true;
            ResultFibo.Location = new Point(315, 216);
            ResultFibo.Name = "ResultFibo";
            ResultFibo.Size = new Size(142, 20);
            ResultFibo.TabIndex = 4;
            ResultFibo.Text = "Resultado Fibonacci";
            ResultFibo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultMCD
            // 
            ResultMCD.AutoSize = true;
            ResultMCD.Location = new Point(580, 216);
            ResultMCD.Name = "ResultMCD";
            ResultMCD.Size = new Size(112, 20);
            ResultMCD.TabIndex = 5;
            ResultMCD.Text = "Resultado MCD";
            ResultMCD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonFact
            // 
            buttonFact.Location = new Point(75, 166);
            buttonFact.Name = "buttonFact";
            buttonFact.Size = new Size(94, 29);
            buttonFact.TabIndex = 6;
            buttonFact.Text = "Calcular";
            buttonFact.UseVisualStyleBackColor = true;
            buttonFact.Click += button1_Click;
            // 
            // buttonFibo
            // 
            buttonFibo.Location = new Point(334, 166);
            buttonFibo.Name = "buttonFibo";
            buttonFibo.Size = new Size(94, 29);
            buttonFibo.TabIndex = 7;
            buttonFibo.Text = "Calcular";
            buttonFibo.UseVisualStyleBackColor = true;
            buttonFibo.Click += buttonFibo_Click;
            // 
            // buttonMCD
            // 
            buttonMCD.Location = new Point(598, 166);
            buttonMCD.Name = "buttonMCD";
            buttonMCD.Size = new Size(94, 29);
            buttonMCD.TabIndex = 8;
            buttonMCD.Text = "Calcular";
            buttonMCD.UseVisualStyleBackColor = true;
            buttonMCD.Click += buttonMCD_Click;
            // 
            // textBoxFact
            // 
            textBoxFact.Location = new Point(50, 106);
            textBoxFact.Name = "textBoxFact";
            textBoxFact.Size = new Size(142, 27);
            textBoxFact.TabIndex = 9;
            textBoxFact.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxFibo
            // 
            textBoxFibo.Location = new Point(312, 100);
            textBoxFibo.Name = "textBoxFibo";
            textBoxFibo.Size = new Size(134, 27);
            textBoxFibo.TabIndex = 10;
            textBoxFibo.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxMCD1
            // 
            textBoxMCD1.Location = new Point(572, 106);
            textBoxMCD1.Name = "textBoxMCD1";
            textBoxMCD1.Size = new Size(61, 27);
            textBoxMCD1.TabIndex = 11;
            textBoxMCD1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxMCD2
            // 
            textBoxMCD2.Location = new Point(652, 106);
            textBoxMCD2.Name = "textBoxMCD2";
            textBoxMCD2.Size = new Size(61, 27);
            textBoxMCD2.TabIndex = 12;
            textBoxMCD2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 18);
            label1.Name = "label1";
            label1.Size = new Size(318, 20);
            label1.TabIndex = 13;
            label1.Text = "Ingresa un numero entero posito en las casillas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 295);
            Controls.Add(label1);
            Controls.Add(textBoxMCD2);
            Controls.Add(textBoxMCD1);
            Controls.Add(textBoxFibo);
            Controls.Add(textBoxFact);
            Controls.Add(buttonMCD);
            Controls.Add(buttonFibo);
            Controls.Add(buttonFact);
            Controls.Add(ResultMCD);
            Controls.Add(ResultFibo);
            Controls.Add(ResultFact);
            Controls.Add(MáximoComúnDivisor);
            Controls.Add(Fibonacci);
            Controls.Add(Factorial);
            Name = "Form1";
            Text = "Practica 2,3 y 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Factorial;
        private Label Fibonacci;
        private Label MáximoComúnDivisor;
        private Label ResultFact;
        private Label ResultFibo;
        private Label ResultMCD;
        private Button buttonFact;
        private Button buttonFibo;
        private Button buttonMCD;
        private TextBox textBoxFact;
        private TextBox textBoxFibo;
        private TextBox textBoxMCD1;
        private TextBox textBoxMCD2;
        private Label label1;
    }
}