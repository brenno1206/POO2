namespace Fintech.View
{
    partial class Cadastro
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
            ButtonCadastrar = new Button();
            TextBoxSenha = new TextBox();
            TextBoxLogin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            radioButtonBancoB = new RadioButton();
            radioButtonBanestes = new RadioButton();
            radioButtonNubank = new RadioButton();
            label2 = new Label();
            radioButtonBradesco = new RadioButton();
            label1 = new Label();
            textBoxNome = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // ButtonCadastrar
            // 
            ButtonCadastrar.Location = new Point(245, 329);
            ButtonCadastrar.Name = "ButtonCadastrar";
            ButtonCadastrar.Size = new Size(227, 56);
            ButtonCadastrar.TabIndex = 21;
            ButtonCadastrar.Text = "Cadastrar";
            ButtonCadastrar.UseVisualStyleBackColor = true;
            ButtonCadastrar.Click += ButtonCadastrar_Click;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(134, 274);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(175, 23);
            TextBoxSenha.TabIndex = 20;
            // 
            // TextBoxLogin
            // 
            TextBoxLogin.Location = new Point(134, 233);
            TextBoxLogin.Name = "TextBoxLogin";
            TextBoxLogin.Size = new Size(175, 23);
            TextBoxLogin.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 277);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 18;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 236);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 17;
            label3.Text = "Login";
            // 
            // radioButtonBancoB
            // 
            radioButtonBancoB.AutoSize = true;
            radioButtonBancoB.Location = new Point(591, 144);
            radioButtonBancoB.Name = "radioButtonBancoB";
            radioButtonBancoB.Size = new Size(106, 19);
            radioButtonBancoB.TabIndex = 16;
            radioButtonBancoB.TabStop = true;
            radioButtonBancoB.Text = "Banco do Brasil";
            radioButtonBancoB.UseVisualStyleBackColor = true;
            // 
            // radioButtonBanestes
            // 
            radioButtonBanestes.AutoSize = true;
            radioButtonBanestes.Location = new Point(450, 144);
            radioButtonBanestes.Name = "radioButtonBanestes";
            radioButtonBanestes.Size = new Size(71, 19);
            radioButtonBanestes.TabIndex = 15;
            radioButtonBanestes.TabStop = true;
            radioButtonBanestes.Text = "Banestes";
            radioButtonBanestes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNubank
            // 
            radioButtonNubank.AutoSize = true;
            radioButtonNubank.Location = new Point(288, 144);
            radioButtonNubank.Name = "radioButtonNubank";
            radioButtonNubank.Size = new Size(67, 19);
            radioButtonNubank.TabIndex = 14;
            radioButtonNubank.TabStop = true;
            radioButtonNubank.Text = "Nubank";
            radioButtonNubank.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 112);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 13;
            label2.Text = "Escolha seu Banco";
            // 
            // radioButtonBradesco
            // 
            radioButtonBradesco.AutoSize = true;
            radioButtonBradesco.Location = new Point(134, 144);
            radioButtonBradesco.Name = "radioButtonBradesco";
            radioButtonBradesco.Size = new Size(73, 19);
            radioButtonBradesco.TabIndex = 12;
            radioButtonBradesco.TabStop = true;
            radioButtonBradesco.Text = "Bradesco";
            radioButtonBradesco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(135, 22);
            label1.Name = "label1";
            label1.Size = new Size(470, 54);
            label1.TabIndex = 11;
            label1.Text = "Fintech UVV - Cadatre-se";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(134, 193);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(175, 23);
            textBoxNome.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 196);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 22;
            label5.Text = "Nome";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxNome);
            Controls.Add(label5);
            Controls.Add(ButtonCadastrar);
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
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCadastrar;
        private TextBox TextBoxSenha;
        private TextBox TextBoxLogin;
        private Label label4;
        private Label label3;
        private RadioButton radioButtonBancoB;
        private RadioButton radioButtonBanestes;
        private RadioButton radioButtonNubank;
        private Label label2;
        private RadioButton radioButtonBradesco;
        private Label label1;
        private TextBox textBoxNome;
        private Label label5;
    }
}