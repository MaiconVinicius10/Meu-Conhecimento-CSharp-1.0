﻿
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
            this.btn_MostrarListaVeiculos = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ContagemTela = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btb_Limpar.Click += new System.EventHandler(this.btb_Limpar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(250, 76);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 4;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_MostrarListaVeiculos
            // 
            this.btn_MostrarListaVeiculos.Location = new System.Drawing.Point(32, 415);
            this.btn_MostrarListaVeiculos.Name = "btn_MostrarListaVeiculos";
            this.btn_MostrarListaVeiculos.Size = new System.Drawing.Size(293, 23);
            this.btn_MostrarListaVeiculos.TabIndex = 5;
            this.btn_MostrarListaVeiculos.Text = "Lista de Veiculos";
            this.btn_MostrarListaVeiculos.UseVisualStyleBackColor = true;
            this.btn_MostrarListaVeiculos.Click += new System.EventHandler(this.btn_MostrarListaVeiculos_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(32, 475);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(293, 23);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_ContagemTela
            // 
            this.btn_ContagemTela.Location = new System.Drawing.Point(32, 444);
            this.btn_ContagemTela.Name = "btn_ContagemTela";
            this.btn_ContagemTela.Size = new System.Drawing.Size(293, 23);
            this.btn_ContagemTela.TabIndex = 7;
            this.btn_ContagemTela.Text = "Contagem de Tela";
            this.btn_ContagemTela.UseVisualStyleBackColor = true;
            this.btn_ContagemTela.Click += new System.EventHandler(this.btn_ContagemTela_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(353, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem1,
            this.checkedListBoxToolStripMenuItem});
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.checkBoxToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem1
            // 
            this.checkBoxToolStripMenuItem1.Name = "checkBoxToolStripMenuItem1";
            this.checkBoxToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.checkBoxToolStripMenuItem1.Text = "CheckBox";
            this.checkBoxToolStripMenuItem1.Click += new System.EventHandler(this.checkBoxToolStripMenuItem1_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 527);
            this.Controls.Add(this.btn_ContagemTela);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_MostrarListaVeiculos);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btb_Limpar);
            this.Controls.Add(this.txt_ListaVeiculos);
            this.Controls.Add(this.txt_AdicionarVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AdicionarVeiculo;
        private System.Windows.Forms.Button btb_Limpar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_MostrarListaVeiculos;
        private System.Windows.Forms.Button btn_Sair;
        public System.Windows.Forms.TextBox txt_ListaVeiculos;
        private System.Windows.Forms.Button btn_ContagemTela;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
    }
}

