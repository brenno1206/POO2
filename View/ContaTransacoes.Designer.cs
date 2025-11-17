namespace Fintech.View
{
    partial class ContaTransacoes
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(148, 9);
            label2.Name = "label2";
            label2.Size = new Size(240, 54);
            label2.TabIndex = 4;
            label2.Text = "Fintech UVV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 5;
            label1.Text = "Olá XXXX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 207);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 23);
            textBox1.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(71, 173);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(53, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sacar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(188, 173);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Depositar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(281, 190);
            button1.Name = "button1";
            button1.Size = new Size(104, 49);
            button1.TabIndex = 11;
            button1.Text = "Realizar Transação";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 297);
            label6.Name = "label6";
            label6.Size = new Size(160, 15);
            label6.TabIndex = 13;
            label6.Text = "Número da conta a Transferir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 322);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 14;
            label7.Text = "Valor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 319);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 23);
            textBox3.TabIndex = 16;
            // 
            // button2
            // 
            button2.Location = new Point(281, 289);
            button2.Name = "button2";
            button2.Size = new Size(104, 49);
            button2.TabIndex = 17;
            button2.Text = "Realizar Transação";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(373, 83);
            label8.Name = "label8";
            label8.Size = new Size(163, 37);
            label8.TabIndex = 18;
            label8.Text = "Saldo: 00.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(22, 120);
            label9.Name = "label9";
            label9.Size = new Size(102, 19);
            label9.TabIndex = 19;
            label9.Text = "id da conta: xxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 267);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 12;
            label5.Text = "Transferência";
            // 
            // ContaTransacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 424);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ContaTransacoes";
            Text = "ContaTransacoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Label label8;
        private Label label9;
        private Label label5;
    }
}