
namespace KomsertaPC_OS_s
{
    partial class ListagemClientes
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
            this.clienteListView = new System.Windows.Forms.ListView();
            this.nome = new System.Windows.Forms.ColumnHeader();
            this.cpf = new System.Windows.Forms.ColumnHeader();
            this.telefone = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // clienteListView
            // 
            this.clienteListView.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clienteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.cpf,
            this.telefone});
            this.clienteListView.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clienteListView.FullRowSelect = true;
            this.clienteListView.GridLines = true;
            this.clienteListView.HideSelection = false;
            this.clienteListView.Location = new System.Drawing.Point(0, 0);
            this.clienteListView.Name = "clienteListView";
            this.clienteListView.Size = new System.Drawing.Size(623, 350);
            this.clienteListView.TabIndex = 0;
            this.clienteListView.UseCompatibleStateImageBehavior = false;
            this.clienteListView.View = System.Windows.Forms.View.Details;
            this.clienteListView.SelectedIndexChanged += new System.EventHandler(this.clienteListView_SelectedIndexChanged);
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 220;
            // 
            // cpf
            // 
            this.cpf.Text = "CPF";
            this.cpf.Width = 200;
            // 
            // telefone
            // 
            this.telefone.Text = "Telefone";
            this.telefone.Width = 200;
            // 
            // ListagemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 349);
            this.Controls.Add(this.clienteListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListagemClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListagemClientes";
            this.Load += new System.EventHandler(this.ListagemCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView clienteListView;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.ColumnHeader telefone;
    }
}