namespace Fintech
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
            radioButtonBradesco = new RadioButton();
            label2 = new Label();
            radioButtonNubank = new RadioButton();
            radioButtonBanestes = new RadioButton();
            radioButtonBancoB = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            TextBoxLogin = new TextBox();
            TextBoxSenha = new TextBox();
            ButtonEntrar = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(128, 22);
            label1.Name = "label1";
            label1.Size = new Size(383, 54);
            label1.TabIndex = 0;
            label1.Text = "Fintech UVV - Entrar";
            // 
            // radioButtonBradesco
            // 
            radioButtonBradesco.AutoSize = true;
            radioButtonBradesco.Location = new Point(72, 146);
            radioButtonBradesco.Name = "radioButtonBradesco";
            radioButtonBradesco.Size = new Size(73, 19);
            radioButtonBradesco.TabIndex = 1;
            radioButtonBradesco.TabStop = true;
            radioButtonBradesco.Text = "Bradesco";
            radioButtonBradesco.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 114);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Escolha seu Banco";
            // 
            // radioButtonNubank
            // 
            radioButtonNubank.AutoSize = true;
            radioButtonNubank.Location = new Point(226, 146);
            radioButtonNubank.Name = "radioButtonNubank";
            radioButtonNubank.Size = new Size(67, 19);
            radioButtonNubank.TabIndex = 3;
            radioButtonNubank.TabStop = true;
            radioButtonNubank.Text = "Nubank";
            radioButtonNubank.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanestes
            // 
            radioButtonBanestes.AutoSize = true;
            radioButtonBanestes.Location = new Point(388, 146);
            radioButtonBanestes.Name = "radioButtonBanestes";
            radioButtonBanestes.Size = new Size(71, 19);
            radioButtonBanestes.TabIndex = 4;
            radioButtonBanestes.TabStop = true;
            radioButtonBanestes.Text = "Banestes";
            radioButtonBanestes.UseVisualStyleBackColor = true;
            // 
            // radioButtonBancoB
            // 
            radioButtonBancoB.AutoSize = true;
            radioButtonBancoB.Location = new Point(529, 146);
            radioButtonBancoB.Name = "radioButtonBancoB";
            radioButtonBancoB.Size = new Size(106, 19);
            radioButtonBancoB.TabIndex = 5;
            radioButtonBancoB.TabStop = true;
            radioButtonBancoB.Text = "Banco do Brasil";
            radioButtonBancoB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 200);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 241);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Location = new Point(73, 197);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(175, 23);
            TextBoxLogin.TabIndex = 8;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(73, 238);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(175, 23);
            TextBoxSenha.TabIndex = 9;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Location = new Point(183, 331);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(227, 56);
            ButtonEntrar.TabIndex = 10;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = true;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(90, 264);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Não tem Conta? Cadastre-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 420);
            Controls.Add(linkLabel1);
            Controls.Add(ButtonEntrar);
            Controls.Add(TextBoxSenha);
            Controls.Add(TextBoxLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(radioButtonBancoB);
            Controls.Add(radioButtonBanestes);
            Controls.Add(radioButtonNubank);
            Controls.Add(label2);
            Controls.Add(radioButtonBradesco);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButtonBradesco;
        private Label label2;
        private RadioButton radioButtonNubank;
        private RadioButton radioButtonBanestes;
        private RadioButton radioButtonBancoB;
        private Label label3;
        private Label label4;
        private TextBox TextBoxLogin;
        private TextBox TextBoxSenha;
        private Button ButtonEntrar;
        private LinkLabel linkLabel1;
    }
}
