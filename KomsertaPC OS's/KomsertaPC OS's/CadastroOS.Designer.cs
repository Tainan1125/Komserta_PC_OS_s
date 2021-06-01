
namespace KomsertaPC_OS_s
{
    partial class CadastroOS
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
            this.listarButton = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.Label();
            this.Descrição = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.descricaoText = new System.Windows.Forms.TextBox();
            this.itemText = new System.Windows.Forms.TextBox();
            this.entradaDate = new System.Windows.Forms.DateTimePicker();
            this.Saida = new System.Windows.Forms.Label();
            this.saidaDate = new System.Windows.Forms.DateTimePicker();
            this.Valor = new System.Windows.Forms.Label();
            this.valorNumber = new System.Windows.Forms.NumericUpDown();
            this.listagemCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.clienteCBX = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.Label();
            this.idNumber = new System.Windows.Forms.NumericUpDown();
            this.saidaCKB = new System.Windows.Forms.CheckBox();
            this.pagoCKB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.valorNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // listarButton
            // 
            this.listarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listarButton.Location = new System.Drawing.Point(319, 419);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(157, 30);
            this.listarButton.TabIndex = 17;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = false;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // removerButton
            // 
            this.removerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.removerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removerButton.Location = new System.Drawing.Point(628, 419);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(144, 30);
            this.removerButton.TabIndex = 16;
            this.removerButton.Text = "Remover";
            this.removerButton.UseVisualStyleBackColor = false;
            this.removerButton.Click += new System.EventHandler(this.removerButton_Click);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarButton.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrarButton.Location = new System.Drawing.Point(12, 419);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(169, 30);
            this.cadastrarButton.TabIndex = 15;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Entrada.Location = new System.Drawing.Point(12, 195);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(96, 26);
            this.Entrada.TabIndex = 14;
            this.Entrada.Text = "Entrada";
            this.Entrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Descrição
            // 
            this.Descrição.AutoSize = true;
            this.Descrição.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Descrição.Location = new System.Drawing.Point(12, 115);
            this.Descrição.Name = "Descrição";
            this.Descrição.Size = new System.Drawing.Size(120, 26);
            this.Descrição.TabIndex = 13;
            this.Descrição.Text = "Descrição";
            this.Descrição.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Item.Location = new System.Drawing.Point(12, 67);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(60, 26);
            this.Item.TabIndex = 12;
            this.Item.Text = "Item";
            this.Item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Item.Click += new System.EventHandler(this.label1_Click);
            // 
            // descricaoText
            // 
            this.descricaoText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descricaoText.Location = new System.Drawing.Point(168, 117);
            this.descricaoText.Name = "descricaoText";
            this.descricaoText.Size = new System.Drawing.Size(200, 26);
            this.descricaoText.TabIndex = 10;
            // 
            // itemText
            // 
            this.itemText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemText.Location = new System.Drawing.Point(168, 69);
            this.itemText.Name = "itemText";
            this.itemText.Size = new System.Drawing.Size(200, 26);
            this.itemText.TabIndex = 9;
            // 
            // entradaDate
            // 
            this.entradaDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entradaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entradaDate.Location = new System.Drawing.Point(168, 194);
            this.entradaDate.Name = "entradaDate";
            this.entradaDate.Size = new System.Drawing.Size(200, 26);
            this.entradaDate.TabIndex = 19;
            this.entradaDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Saida
            // 
            this.Saida.AutoSize = true;
            this.Saida.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Saida.Location = new System.Drawing.Point(12, 241);
            this.Saida.Name = "Saida";
            this.Saida.Size = new System.Drawing.Size(72, 26);
            this.Saida.TabIndex = 20;
            this.Saida.Text = "Saída";
            this.Saida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Saida.Click += new System.EventHandler(this.saidaDate_Click);
            // 
            // saidaDate
            // 
            this.saidaDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saidaDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.saidaDate.Location = new System.Drawing.Point(168, 240);
            this.saidaDate.Name = "saidaDate";
            this.saidaDate.Size = new System.Drawing.Size(200, 26);
            this.saidaDate.TabIndex = 21;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Valor.Location = new System.Drawing.Point(12, 283);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(72, 26);
            this.Valor.TabIndex = 23;
            this.Valor.Text = "Valor";
            this.Valor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorNumber
            // 
            this.valorNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valorNumber.Location = new System.Drawing.Point(168, 286);
            this.valorNumber.Maximum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            0});
            this.valorNumber.Name = "valorNumber";
            this.valorNumber.Size = new System.Drawing.Size(200, 26);
            this.valorNumber.TabIndex = 24;
            // 
            // listagemCBX
            // 
            this.listagemCBX.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listagemCBX.FormattingEnabled = true;
            this.listagemCBX.Items.AddRange(new object[] {
            "Pago",
            "Não pago",
            "Com saída",
            "Sem saída"});
            this.listagemCBX.Location = new System.Drawing.Point(168, 334);
            this.listagemCBX.Name = "listagemCBX";
            this.listagemCBX.Size = new System.Drawing.Size(200, 27);
            this.listagemCBX.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Listagem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cliente.Location = new System.Drawing.Point(12, 20);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(96, 26);
            this.Cliente.TabIndex = 29;
            this.Cliente.Text = "Cliente";
            this.Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // clienteCBX
            // 
            this.clienteCBX.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clienteCBX.FormattingEnabled = true;
            this.clienteCBX.Location = new System.Drawing.Point(168, 22);
            this.clienteCBX.Name = "clienteCBX";
            this.clienteCBX.Size = new System.Drawing.Size(200, 27);
            this.clienteCBX.TabIndex = 30;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Consolas", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(394, 69);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(36, 26);
            this.Id.TabIndex = 31;
            this.Id.Text = "Id";
            // 
            // idNumber
            // 
            this.idNumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idNumber.Location = new System.Drawing.Point(436, 70);
            this.idNumber.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(40, 26);
            this.idNumber.TabIndex = 32;
            // 
            // saidaCKB
            // 
            this.saidaCKB.AutoSize = true;
            this.saidaCKB.Enabled = false;
            this.saidaCKB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saidaCKB.Location = new System.Drawing.Point(394, 245);
            this.saidaCKB.Name = "saidaCKB";
            this.saidaCKB.Size = new System.Drawing.Size(118, 23);
            this.saidaCKB.TabIndex = 33;
            this.saidaCKB.Text = "Com saída.";
            this.saidaCKB.UseVisualStyleBackColor = true;
            // 
            // pagoCKB
            // 
            this.pagoCKB.AutoSize = true;
            this.pagoCKB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pagoCKB.Location = new System.Drawing.Point(394, 287);
            this.pagoCKB.Name = "pagoCKB";
            this.pagoCKB.Size = new System.Drawing.Size(73, 23);
            this.pagoCKB.TabIndex = 34;
            this.pagoCKB.Text = "Pago.";
            this.pagoCKB.UseVisualStyleBackColor = true;
            this.pagoCKB.CheckedChanged += new System.EventHandler(this.pagoCKB_CheckedChanged);
            // 
            // CadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pagoCKB);
            this.Controls.Add(this.saidaCKB);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.clienteCBX);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listagemCBX);
            this.Controls.Add(this.valorNumber);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.saidaDate);
            this.Controls.Add(this.Saida);
            this.Controls.Add(this.entradaDate);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Descrição);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.descricaoText);
            this.Controls.Add(this.itemText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroOS";
            this.Load += new System.EventHandler(this.CadastroOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valorNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.Label Descrição;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.TextBox descricaoText;
        private System.Windows.Forms.TextBox itemText;
        private System.Windows.Forms.DateTimePicker entradaDate;
        private System.Windows.Forms.Label Saida;
        private System.Windows.Forms.DateTimePicker saidaDate;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.NumericUpDown valorNumber;
        private System.Windows.Forms.ComboBox listagemCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox clienteCBX;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.NumericUpDown idNumber;
        private System.Windows.Forms.CheckBox saidaCKB;
        private System.Windows.Forms.CheckBox pagoCKB;
    }
}