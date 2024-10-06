
namespace Meu_Conhecimento_CSharp_1._0.Forms
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Carro = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(118, 212);
            this.lb_carros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro";
            // 
            // txt_Carro
            // 
            this.txt_Carro.Location = new System.Drawing.Point(139, 28);
            this.txt_Carro.Name = "txt_Carro";
            this.txt_Carro.Size = new System.Drawing.Size(95, 20);
            this.txt_Carro.TabIndex = 2;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(139, 54);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(95, 23);
            this.btn_Adicionar.TabIndex = 3;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(139, 83);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(95, 23);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(139, 112);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(95, 23);
            this.btn_Obter.TabIndex = 5;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(139, 141);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(95, 23);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 380);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_Carro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Carro;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button btn_Limpar;
    }
}