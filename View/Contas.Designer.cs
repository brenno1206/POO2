namespace Fintech.View
{
    partial class Contas
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 145);
            button1.Name = "button1";
            button1.Size = new Size(151, 165);
            button1.TabIndex = 0;
            button1.Text = "Conta Corrente de xxxxxxxx";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(528, 145);
            button2.Name = "button2";
            button2.Size = new Size(151, 165);
            button2.TabIndex = 1;
            button2.Text = "Conta Poupança de XXXXXXXX";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 2;
            label1.Text = "Suas Contas no Banco X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(236, 9);
            label2.Name = "label2";
            label2.Size = new Size(240, 54);
            label2.TabIndex = 3;
            label2.Text = "Fintech UVV";
            // 
            // button3
            // 
            button3.Location = new Point(41, 316);
            button3.Name = "button3";
            button3.Size = new Size(147, 23);
            button3.TabIndex = 4;
            button3.Text = "Adicione Conta Corrente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 8F);
            button4.Location = new Point(528, 316);
            button4.Name = "button4";
            button4.Size = new Size(151, 23);
            button4.TabIndex = 5;
            button4.Text = "Adicione Conta Poupança";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Contas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Contas";
            Text = "Contas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}