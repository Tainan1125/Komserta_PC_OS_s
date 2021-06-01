
namespace KomsertaPC_OS_s
{
    partial class Home
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
            this.Clientes = new System.Windows.Forms.Button();
            this.Ordens_Serviço = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clientes.Location = new System.Drawing.Point(147, 80);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(243, 47);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Ordens_Serviço
            // 
            this.Ordens_Serviço.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ordens_Serviço.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ordens_Serviço.Location = new System.Drawing.Point(147, 198);
            this.Ordens_Serviço.Name = "Ordens_Serviço";
            this.Ordens_Serviço.Size = new System.Drawing.Size(243, 47);
            this.Ordens_Serviço.TabIndex = 1;
            this.Ordens_Serviço.Text = "Ordens de Serviços";
            this.Ordens_Serviço.UseVisualStyleBackColor = true;
            this.Ordens_Serviço.Click += new System.EventHandler(this.Ordens_Serviço_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 322);
            this.Controls.Add(this.Ordens_Serviço);
            this.Controls.Add(this.Clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KomsertaPC OS\'s";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Ordens_Serviço;
    }
}

