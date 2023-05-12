namespace WinFormsApp1
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
            label1 = new Label();
            txtPrimeiroNum = new TextBox();
            label2 = new Label();
            txtSegundoNum = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 34);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Primeiro número";
            // 
            // txtPrimeiroNum
            // 
            txtPrimeiroNum.Location = new Point(155, 31);
            txtPrimeiroNum.Name = "txtPrimeiroNum";
            txtPrimeiroNum.Size = new Size(100, 23);
            txtPrimeiroNum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Segundo número";
            // 
            // txtSegundoNum
            // 
            txtSegundoNum.Location = new Point(155, 86);
            txtSegundoNum.Name = "txtSegundoNum";
            txtSegundoNum.Size = new Size(100, 23);
            txtSegundoNum.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(155, 135);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(39, 197);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(141, 30);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 272);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtSegundoNum);
            Controls.Add(label2);
            Controls.Add(txtPrimeiroNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrimeiroNum;
        private Label label2;
        private TextBox txtSegundoNum;
        private Button btnCalcular;
        private Label lblResultado;
    }
}