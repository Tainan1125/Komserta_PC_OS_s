
namespace KomsertaPC_OS_s
{
    partial class CadastroCliente
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
            this.nomeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.listarButton = new System.Windows.Forms.Button();
            this.cpfText = new System.Windows.Forms.MaskedTextBox();
            this.telefoneText = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nomeText
            // 
            this.nomeText.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeText.Location = new System.Drawing.Point(360, 60);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(245, 32);
            this.nomeText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(146, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrarButton.Location = new System.Drawing.Point(146, 352);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(130, 32);
            this.cadastrarButton.TabIndex = 6;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // removerButton
            // 
            this.removerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removerButton.Location = new System.Drawing.Point(499, 352);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(105, 32);
            this.removerButton.TabIndex = 7;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // listarButton
            // 
            this.listarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listarButton.Location = new System.Drawing.Point(330, 352);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(118, 32);
            this.listarButton.TabIndex = 8;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // cpfText
            // 
            this.cpfText.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpfText.Location = new System.Drawing.Point(360, 163);
            this.cpfText.Mask = "000,000,000-00";
            this.cpfText.Name = "cpfText";
            this.cpfText.Size = new System.Drawing.Size(175, 32);
            this.cpfText.TabIndex = 9;
            // 
            // telefoneText
            // 
            this.telefoneText.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefoneText.Location = new System.Drawing.Point(360, 264);
            this.telefoneText.Mask = "(00) 00000-0000";
            this.telefoneText.Name = "telefoneText";
            this.telefoneText.Size = new System.Drawing.Size(189, 32);
            this.telefoneText.TabIndex = 10;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.telefoneText);
            this.Controls.Add(this.cpfText);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.MaskedTextBox cpfText;
        private System.Windows.Forms.MaskedTextBox telefoneText;
    }
}