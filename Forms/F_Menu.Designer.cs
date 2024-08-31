
namespace Meu_Conhecimento_CSharp_1._0
{
    partial class F_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AdicionarVeiculo = new System.Windows.Forms.TextBox();
            this.txt_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.btb_Limpar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Veiculo";
            // 
            // txt_AdicionarVeiculo
            // 
            this.txt_AdicionarVeiculo.Location = new System.Drawing.Point(32, 76);
            this.txt_AdicionarVeiculo.Name = "txt_AdicionarVeiculo";
            this.txt_AdicionarVeiculo.Size = new System.Drawing.Size(212, 22);
            this.txt_AdicionarVeiculo.TabIndex = 1;
            // 
            // txt_ListaVeiculos
            // 
            this.txt_ListaVeiculos.Location = new System.Drawing.Point(32, 104);
            this.txt_ListaVeiculos.Multiline = true;
            this.txt_ListaVeiculos.Name = "txt_ListaVeiculos";
            this.txt_ListaVeiculos.Size = new System.Drawing.Size(293, 276);
            this.txt_ListaVeiculos.TabIndex = 2;
            // 
            // btb_Limpar
            // 
            this.btb_Limpar.Location = new System.Drawing.Point(32, 386);
            this.btb_Limpar.Name = "btb_Limpar";
            this.btb_Limpar.Size = new System.Drawing.Size(293, 23);
            this.btb_Limpar.TabIndex = 3;
            this.btb_Limpar.Text = "Limpar";
            this.btb_Limpar.UseVisualStyleBackColor = true;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(250, 76);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 428);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btb_Limpar);
            this.Controls.Add(this.txt_ListaVeiculos);
            this.Controls.Add(this.txt_AdicionarVeiculo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AdicionarVeiculo;
        private System.Windows.Forms.TextBox txt_ListaVeiculos;
        private System.Windows.Forms.Button btb_Limpar;
        private System.Windows.Forms.Button btn_Adicionar;
    }
}

